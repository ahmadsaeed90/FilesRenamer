using FilesRenamer.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesRenamer
{
    public partial class Form1 : Form
    {
        private IFilesRenameService _filesRenameService;

        public Form1()
        {
            InitializeComponent();

            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

            //TODO: Uncomment
            //this.txtInpPath.Text = "E:\\Zaha\\Files Rename\\Specs\\fwdrollimages\\no rename\\no rename";
            //this.txtOutputPath.Text = "E:\\Zaha\\Files Rename\\Output";

            var logger = new Logger();
            logger.OnLogMessage += LogMessage;
            logger.OnLogError += LogError;

            _filesRenameService = new FilesRenameService(logger);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _filesRenameService.RenameFiles(this.txtInpPath.Text, this.txtOutputPath.Text);
        }

        private void backgroundWorker1_RunWorkerCompleted(
            object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("Cancelled");
            }
            else
            {
                this.lblLoadingMsg.Hide();
                MessageBox.Show("Processing Completed.", "Processing Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.txtOutputErrors.Clear();
            this.txtOutputLog.Clear();

            if (string.IsNullOrWhiteSpace(this.txtInpPath.Text) || string.IsNullOrWhiteSpace(this.txtOutputPath.Text))
            {
                this.txtOutputErrors.Text = "Please select input and output directories!!!";
            }
            else
            {
                this.lblLoadingMsg.Show();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        public void LogMessage(string message)
        {
            this.txtOutputLog.Text += $"{Environment.NewLine}{Environment.NewLine}{message}";
            //txtOutputLog.SelectionStart = txtOutputLog.Text.Length;
            //txtOutputLog.ScrollToCaret();
        }

        public void LogError(string message)
        {
            this.txtOutputErrors.Text += $"{Environment.NewLine}{message}";
        }

        private void btnSelectInputPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtInpPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnSelectOutputPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtOutputPath.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
