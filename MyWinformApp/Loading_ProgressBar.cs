using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MyWinformApp
{
    public partial class Loading_ProgressBar : Form
    {
        public Loading_ProgressBar()
        {
            InitializeComponent();
            tempFunction(this, EventArgs.Empty);
        }

        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;

            var progressReport = new ProgressReport();

            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);

                    Thread.Sleep(5);
                }
            });
        }

        private async void tempFunction(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < 1000; i++)
            {
                list.Add(i.ToString());
            }

            label_load.Text = "로그인 중입니다..." + "";

            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                label_load.Text = string.Format("로그인 중 입니다... {0}%", report.PercentComplete);
                progressBar1.Value = report.PercentComplete;
                progressBar1.Update();
            };
            await ProcessData(list, progress);

            label_load.Text = "완료 되었습니다.";
            MessageBox.Show("완료!");
            this.Close();
        }
    }

    public class ProgressReport
    {
        public int PercentComplete { get; set; }
    }

}

