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
        
        int portNumber = 8000;
        static string ipNumber = "127.0.0.1";
        string userID = "Client";
        
        public Main()
        {
            InitializeComponent();
            
            LoginForm login = new LoginForm();
            login.DataPassEvent += new LoginForm.DataPassEventHandler(DataReceiveEvent);
            login.ShowDialog();
        }

        /// <summary>
        /// DataPassEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DataReceiveEvent(int login_portNumber, string login_ipNumber, string login_userID)
        {
            this.portNumber = login_portNumber;
            this.userID = login_userID;
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
            string Message = string.Empty;
            Message = "채팅 서버에 연결되었습니다.";
            DisplayText(Message);
            byte[] buffer = Encoding.Unicode.GetBytes(userID + "$");
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
                string[] user_list = null;
                
                int bytes = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                if (message.Contains("$"))
                {
                    user_list = message.Split('$');
                    //message = message.Substring(0, message.IndexOf("$"));
                    //DisplayText(user_list.Length.ToString() + " has entered chat.");
                    // 스레드 내부에서 처리하는 함수가 너무 많음 -> 채팅 속도가 저하될 것임. 스레드 하나 더 추가해서 컨트롤하기 혹은 동기 통신을 사용하여 일정 속도의 채팅 데이터만 받고 이외에는 무시하는 방식 사용

                    DisplayUsers(user_list);
                    foreach (var item in user_list)
                    {
                        if (item.Equals(""))
                            break;
                        DisplayText(item);
                    }
                }
                else
                {
                    DisplayText(message);
                }
            }
        }

        // Invoke ListBox
        private void DisplayUsers(string[] userList)
        {
            if(UsersList.InvokeRequired)
            {
                UsersList.BeginInvoke(new MethodInvoker(delegate
                {
                    UsersList.Items.Clear();
                    foreach (string item in userList)
                    {
                        if (item.Equals(""))
                            break;
                        UsersList.Items.Add(item);
                    }
                }));
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
            if(e.KeyCode == Keys.Enter && Chatting.Text != "")
            {
                WriteMessage(sender, e);
            }
        }

        // Add Users
        private void Add_Users(string others)
        {
            UsersList.Items.Add(others);
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

        private void SaveData_Click(object sender, EventArgs e)
        {

        }
    }
}
