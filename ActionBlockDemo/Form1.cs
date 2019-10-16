using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace ActionBlockDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQueueTask_Click(object sender, EventArgs e)
        {
            lock (lockObject)
            {
                if (workQueue is null)
                {
                    WorkerCancelSource = new CancellationTokenSource();
                    workQueue = new ActionBlock<int>(async i =>
                    {
                        var ct = WorkerCancelSource.Token;
                        try
                        {
                            Interlocked.Increment(ref activeTasks);
                            Debug.WriteLine($"processing job {i}");
                            await Task.Delay(3_000, ct);
                            Interlocked.Increment(ref completedTasks);
                            return;
                        }
                        catch (TaskCanceledException)
                        {
                            Debug.WriteLine($"Job {i} was cancelled.");
                            // don't re-throw, or it will cause the completion Task to throw.  We would log this.
                            Interlocked.Increment(ref cancelledTasks);
                        }
                        catch (Exception)
                        {
                            // You just want to log this and do not throw.
                        }
                        finally
                        {
                            Interlocked.Decrement(ref activeTasks);
                        }
                    }, new ExecutionDataflowBlockOptions { MaxDegreeOfParallelism = maxDegreeOfParallelism, CancellationToken = WorkerCancelSource.Token });
                }
                var next = Interlocked.Increment(ref nextJobId);
                workQueue.Post(next);
            }
        }

        public ActionBlock<int> workQueue { get; set; }
        private int nextJobId = -1;
        private int activeTasks = 0;
        private int completedTasks = 0;
        private int cancelledTasks = 0;
        private const int maxDegreeOfParallelism = 4;
        private const int maxQueuedTasks = 10;

        private void Form1_Load(object sender, EventArgs e)
        {
            workQueue = null;
            uiTimer.Interval = 30;
            uiTimer.Start();
        }

        private void uiTimer_Tick(object sender, EventArgs e)
        {
            txtQueuedTasks.Text = workQueue?.InputCount.ToString() ?? "0";
            txtRunningTasks.Text = activeTasks.ToString();
            txtCompletedTasks.Text = completedTasks.ToString();
            txtCancelledTasks.Text = cancelledTasks.ToString();
            btnQueueTask.Enabled = workQueue is null || workQueue?.InputCount < maxQueuedTasks;
            btnCancelWorker.Enabled = !(WorkerCancelSource is null || WorkerCancelSource.IsCancellationRequested);
            if (workQueue is null)
            {
                lblStatus.Text = $"Worker is currently null.  Please queue a task.";
            }
            else
            {
                lblStatus.Text = $"Worker will process up to {maxDegreeOfParallelism} tasks at a time, with a max of {maxQueuedTasks} in the queue.";
            }
            var expectedNextJobId = activeTasks + completedTasks + cancelledTasks + (workQueue?.InputCount ?? 0) - 1;
            lblConsistency.Text = expectedNextJobId == nextJobId ? "system is consistent" : $"system lost {nextJobId - expectedNextJobId} tasks.";
        }

        private CancellationTokenSource WorkerCancelSource { get; set; }

        private async void btnCancelWorker_Click(object sender, EventArgs e)
        {
            if (workQueue is null)
            {
                return;
            }
            workQueue.Complete();
            var queuedToCancel = workQueue.InputCount;
            WorkerCancelSource.Cancel();

            try
            {
                await workQueue.Completion;
            }
            catch (TaskCanceledException)
            {
                // this exception is expected.  the queued tasks won't actuall fire their own cancel event,
                // so if we want to track them, we have to do it here.
                Interlocked.Add(ref cancelledTasks, queuedToCancel);
            }
            catch (Exception)
            {
                // this is unexpected.
                throw;
            }
            
            workQueue = null;
            WorkerCancelSource.Dispose();
            WorkerCancelSource = null;
        }

        private object lockObject = new object();

    }
}
