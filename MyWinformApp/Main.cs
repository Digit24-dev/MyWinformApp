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
using System.Net;
using System.Net.Sockets;

namespace MyWinformApp
{
    public partial class Main : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream stream = default(NetworkStream);
        string Message = string.Empty;
        static int portNumber = 8000;
        static string ipNumber = "127.0.0.1";

        public Main()
        {
            InitializeComponent();
        }
        //
        // Main Form Load
        //
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                clientSocket.Connect(ipNumber, portNumber);
                stream = clientSocket.GetStream();
            }
            catch (Exception)
            {
                MessageBox.Show("연결 실패!");
                Application.Exit();
                //throw;
            }

            Message = "채팅 서버에 연결되었습니다.";
            DisplayText(Message);
            byte[] buffer = Encoding.Unicode.GetBytes("Client2112" + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();

            // Start Thread
            Thread thread = new Thread(Receive);
            thread.IsBackground = true;
            thread.Start();

        }

        private void ToForm_A_Click(object sender, EventArgs e)
        {
            FormA formA = new FormA();
            formA.Show();
        }

        private void ToForm_B_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB();
            formB.Show();
        }

        private void ChatLog_TextChanged(object sender, EventArgs e)
        {
            ChatLog.Show();
        }

        //
        //  Methods 
        //

        // Get Message
        private void Receive()
        {
            while (true)
            {
                stream = clientSocket.GetStream();
                int BUFFERSIZE = 1024;
                byte[] buffer = new byte[BUFFERSIZE];
                
                int bytes = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                if(!message.Equals(""))
                    DisplayText(message);
            }
        }

        // Invoke TextBox
        private void DisplayText(string msg)
        {
            if(ChatLog.InvokeRequired)
            {
                ChatLog.BeginInvoke(new MethodInvoker(delegate
                {
                    ChatLog.AppendText(msg + Environment.NewLine);
                }));
            }
            else
            {
                ChatLog.AppendText(msg + Environment.NewLine);
            }
        }

        // Write Chatting Message
        private void WriteMessage(object sender, EventArgs e)
        {
            Chatting.Focus();
            byte[] buffer = Encoding.Unicode.GetBytes(Chatting.Text + "$");
            this.stream.Write(buffer, 0, buffer.Length);
            this.stream.Flush();
            Chatting.Text = "";
        }

        // Key Event
        private void Chatting_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                WriteMessage(sender, e);
            }
        }

        // Add Users
        private void Add_Users()
        {

        }
        
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Exit_Click(sender, e);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Unicode.GetBytes("/exit" + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            this.Close();
        }
    }
}
