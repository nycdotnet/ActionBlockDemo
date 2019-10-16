namespace ActionBlockDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnQueueTask = new System.Windows.Forms.Button();
            this.txtQueuedTasks = new System.Windows.Forms.TextBox();
            this.txtRunningTasks = new System.Windows.Forms.TextBox();
            this.txtCompletedTasks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelWorker = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.uiTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtCancelledTasks = new System.Windows.Forms.TextBox();
            this.lblConsistency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQueueTask
            // 
            this.btnQueueTask.Location = new System.Drawing.Point(46, 42);
            this.btnQueueTask.Name = "btnQueueTask";
            this.btnQueueTask.Size = new System.Drawing.Size(217, 54);
            this.btnQueueTask.TabIndex = 0;
            this.btnQueueTask.Text = "Queue Task";
            this.btnQueueTask.UseVisualStyleBackColor = true;
            this.btnQueueTask.Click += new System.EventHandler(this.btnQueueTask_Click);
            // 
            // txtQueuedTasks
            // 
            this.txtQueuedTasks.Location = new System.Drawing.Point(511, 42);
            this.txtQueuedTasks.Name = "txtQueuedTasks";
            this.txtQueuedTasks.ReadOnly = true;
            this.txtQueuedTasks.Size = new System.Drawing.Size(100, 31);
            this.txtQueuedTasks.TabIndex = 1;
            this.txtQueuedTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRunningTasks
            // 
            this.txtRunningTasks.Location = new System.Drawing.Point(511, 81);
            this.txtRunningTasks.Name = "txtRunningTasks";
            this.txtRunningTasks.ReadOnly = true;
            this.txtRunningTasks.Size = new System.Drawing.Size(100, 31);
            this.txtRunningTasks.TabIndex = 2;
            this.txtRunningTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCompletedTasks
            // 
            this.txtCompletedTasks.Location = new System.Drawing.Point(511, 118);
            this.txtCompletedTasks.Name = "txtCompletedTasks";
            this.txtCompletedTasks.ReadOnly = true;
            this.txtCompletedTasks.Size = new System.Drawing.Size(100, 31);
            this.txtCompletedTasks.TabIndex = 3;
            this.txtCompletedTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Queued Tasks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Running Tasks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Completed Tasks";
            // 
            // btnCancelWorker
            // 
            this.btnCancelWorker.Location = new System.Drawing.Point(46, 102);
            this.btnCancelWorker.Name = "btnCancelWorker";
            this.btnCancelWorker.Size = new System.Drawing.Size(217, 54);
            this.btnCancelWorker.TabIndex = 7;
            this.btnCancelWorker.Text = "Cancel Worker";
            this.btnCancelWorker.UseVisualStyleBackColor = true;
            this.btnCancelWorker.Click += new System.EventHandler(this.btnCancelWorker_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(333, 190);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(153, 25);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Worker is {0}...";
            // 
            // uiTimer
            // 
            this.uiTimer.Tick += new System.EventHandler(this.uiTimer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cancelled Tasks";
            // 
            // txtCancelledTasks
            // 
            this.txtCancelledTasks.Location = new System.Drawing.Point(511, 152);
            this.txtCancelledTasks.Name = "txtCancelledTasks";
            this.txtCancelledTasks.ReadOnly = true;
            this.txtCancelledTasks.Size = new System.Drawing.Size(100, 31);
            this.txtCancelledTasks.TabIndex = 9;
            this.txtCancelledTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblConsistency
            // 
            this.lblConsistency.AutoSize = true;
            this.lblConsistency.Location = new System.Drawing.Point(333, 233);
            this.lblConsistency.Name = "lblConsistency";
            this.lblConsistency.Size = new System.Drawing.Size(126, 25);
            this.lblConsistency.TabIndex = 11;
            this.lblConsistency.Text = "consistency";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 305);
            this.Controls.Add(this.lblConsistency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCancelledTasks);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCancelWorker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompletedTasks);
            this.Controls.Add(this.txtRunningTasks);
            this.Controls.Add(this.txtQueuedTasks);
            this.Controls.Add(this.btnQueueTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQueueTask;
        private System.Windows.Forms.TextBox txtQueuedTasks;
        private System.Windows.Forms.TextBox txtRunningTasks;
        private System.Windows.Forms.TextBox txtCompletedTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelWorker;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer uiTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCancelledTasks;
        private System.Windows.Forms.Label lblConsistency;
    }
}

