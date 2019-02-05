namespace FilesRenamer
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
            this.txtOutputLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInpPath = new System.Windows.Forms.TextBox();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnSelectInputPath = new System.Windows.Forms.Button();
            this.btnSelectOutputPath = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.openInputDialog = new System.Windows.Forms.OpenFileDialog();
            this.openOutputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtOutputErrors = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoadingMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutputLog
            // 
            this.txtOutputLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOutputLog.Location = new System.Drawing.Point(12, 216);
            this.txtOutputLog.Name = "txtOutputLog";
            this.txtOutputLog.Size = new System.Drawing.Size(437, 317);
            this.txtOutputLog.TabIndex = 1;
            this.txtOutputLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Directory:";
            // 
            // txtInpPath
            // 
            this.txtInpPath.Location = new System.Drawing.Point(97, 117);
            this.txtInpPath.Name = "txtInpPath";
            this.txtInpPath.Size = new System.Drawing.Size(250, 20);
            this.txtInpPath.TabIndex = 4;
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(545, 117);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(250, 20);
            this.txtOutputPath.TabIndex = 5;
            // 
            // btnSelectInputPath
            // 
            this.btnSelectInputPath.Location = new System.Drawing.Point(353, 115);
            this.btnSelectInputPath.Name = "btnSelectInputPath";
            this.btnSelectInputPath.Size = new System.Drawing.Size(45, 23);
            this.btnSelectInputPath.TabIndex = 6;
            this.btnSelectInputPath.Text = "Select";
            this.btnSelectInputPath.UseVisualStyleBackColor = true;
            this.btnSelectInputPath.Click += new System.EventHandler(this.btnSelectInputPath_Click);
            // 
            // btnSelectOutputPath
            // 
            this.btnSelectOutputPath.Location = new System.Drawing.Point(801, 115);
            this.btnSelectOutputPath.Name = "btnSelectOutputPath";
            this.btnSelectOutputPath.Size = new System.Drawing.Size(45, 23);
            this.btnSelectOutputPath.TabIndex = 7;
            this.btnSelectOutputPath.Text = "Select";
            this.btnSelectOutputPath.UseVisualStyleBackColor = true;
            this.btnSelectOutputPath.Click += new System.EventHandler(this.btnSelectOutputPath_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.startBtn.Location = new System.Drawing.Point(771, 155);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // openInputDialog
            // 
            this.openInputDialog.FileName = "openInputFileDialog";
            // 
            // openOutputFileDialog
            // 
            this.openOutputFileDialog.FileName = "openOutputFileDialog";
            // 
            // txtOutputErrors
            // 
            this.txtOutputErrors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOutputErrors.Location = new System.Drawing.Point(455, 216);
            this.txtOutputErrors.Name = "txtOutputErrors";
            this.txtOutputErrors.Size = new System.Drawing.Size(396, 317);
            this.txtOutputErrors.TabIndex = 9;
            this.txtOutputErrors.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Logs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Errors / Warnings:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FilesRenamer.Properties.Resources.cooltext292885520997859;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 79);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLoadingMsg
            // 
            this.lblLoadingMsg.AutoSize = true;
            this.lblLoadingMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingMsg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLoadingMsg.Location = new System.Drawing.Point(656, 25);
            this.lblLoadingMsg.Name = "lblLoadingMsg";
            this.lblLoadingMsg.Size = new System.Drawing.Size(195, 17);
            this.lblLoadingMsg.TabIndex = 12;
            this.lblLoadingMsg.Text = "Processing, Please wait...";
            this.lblLoadingMsg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 547);
            this.Controls.Add(this.lblLoadingMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutputErrors);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.btnSelectOutputPath);
            this.Controls.Add(this.btnSelectInputPath);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.txtInpPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutputLog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Files Renamer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txtOutputLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInpPath;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnSelectInputPath;
        private System.Windows.Forms.Button btnSelectOutputPath;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.OpenFileDialog openInputDialog;
        private System.Windows.Forms.OpenFileDialog openOutputFileDialog;
        private System.Windows.Forms.RichTextBox txtOutputErrors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblLoadingMsg;
    }
}

