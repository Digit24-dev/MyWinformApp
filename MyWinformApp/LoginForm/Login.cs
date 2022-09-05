using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinformApp
{
    public partial class LoginForm : Form
    {
        private int portNumber;
        private string temp_portNumber;
        private string ipNumber;
        private string userID;

        // 대리자 이벤트
        public delegate void DataPassEventHandler(int portNumber, string ipNumber, string userID);
        public event DataPassEventHandler DataPassEvent;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_ip_TextChanged(object sender, EventArgs e)
        {
            this.ipNumber = textBox_ip.Text;
        }

        private void textBox_portNumber_TextChanged(object sender, EventArgs e)
        {
            this.temp_portNumber = textBox_portNumber.Text;
        }

        private void textBox_userID_TextChanged(object sender, EventArgs e)
        {
            this.userID = textBox_userID.Text;
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                portNumber = int.Parse(temp_portNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Port 번호에 숫자만 입력해 주세요.");
                return;
                // throw;
            }
            DataPassEvent(this.portNumber, this.ipNumber, this.userID);
            Loading_ProgressBar loading_ProgressBar = new Loading_ProgressBar();
            loading_ProgressBar.ShowDialog();
            this.Close();
        }
    }
}
