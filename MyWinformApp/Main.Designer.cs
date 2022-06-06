
using System;
using System.Windows.Forms;

namespace MyWinformApp
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToForm_A = new System.Windows.Forms.Button();
            this.ToForm_B = new System.Windows.Forms.Button();
            this.SaveData = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ChatLog = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.UsersList = new System.Windows.Forms.ListBox();
            this.Chatting = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ToForm_A
            // 
            this.ToForm_A.BackColor = System.Drawing.Color.SlateGray;
            this.ToForm_A.Location = new System.Drawing.Point(570, 420);
            this.ToForm_A.Name = "ToForm_A";
            this.ToForm_A.Size = new System.Drawing.Size(106, 26);
            this.ToForm_A.TabIndex = 2;
            this.ToForm_A.Text = "To Form A";
            this.ToForm_A.UseVisualStyleBackColor = false;
            this.ToForm_A.Click += new System.EventHandler(this.ToForm_A_Click);
            // 
            // ToForm_B
            // 
            this.ToForm_B.BackColor = System.Drawing.Color.SlateGray;
            this.ToForm_B.Location = new System.Drawing.Point(682, 420);
            this.ToForm_B.Name = "ToForm_B";
            this.ToForm_B.Size = new System.Drawing.Size(106, 26);
            this.ToForm_B.TabIndex = 3;
            this.ToForm_B.Text = "To Form B";
            this.ToForm_B.UseVisualStyleBackColor = false;
            this.ToForm_B.Click += new System.EventHandler(this.ToForm_B_Click);
            // 
            // SaveData
            // 
            this.SaveData.BackColor = System.Drawing.Color.SlateGray;
            this.SaveData.Location = new System.Drawing.Point(570, 462);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(106, 26);
            this.SaveData.TabIndex = 4;
            this.SaveData.Text = "Save Data";
            this.SaveData.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.SlateGray;
            this.Exit.Location = new System.Drawing.Point(682, 462);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(106, 26);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Exit_ControlRemoved);
            // 
            // ChatLog
            // 
            this.ChatLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatLog.Location = new System.Drawing.Point(23, 12);
            this.ChatLog.Name = "ChatLog";
            this.ChatLog.ReadOnly = true;
            this.ChatLog.Size = new System.Drawing.Size(513, 434);
            this.ChatLog.TabIndex = 7;
            this.ChatLog.Text = "";
            this.ChatLog.TextChanged += new System.EventHandler(this.ChatLog_TextChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar1.Location = new System.Drawing.Point(537, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 434);
            this.vScrollBar1.TabIndex = 9;
            // 
            // UsersList
            // 
            this.UsersList.FormattingEnabled = true;
            this.UsersList.ItemHeight = 12;
            this.UsersList.Location = new System.Drawing.Point(570, 12);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(218, 388);
            this.UsersList.TabIndex = 10;
            // 
            // Chatting
            // 
            this.Chatting.Location = new System.Drawing.Point(23, 467);
            this.Chatting.Name = "Chatting";
            this.Chatting.Size = new System.Drawing.Size(531, 21);
            this.Chatting.TabIndex = 11;
            this.Chatting.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Chatting_KeyUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Chatting);
            this.Controls.Add(this.UsersList);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.ChatLog);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.ToForm_B);
            this.Controls.Add(this.ToForm_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Exit_ControlRemoved(object sender, ControlEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button ToForm_A;
        private System.Windows.Forms.Button ToForm_B;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RichTextBox ChatLog;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListBox UsersList;
        private System.Windows.Forms.TextBox Chatting;
    }
}

