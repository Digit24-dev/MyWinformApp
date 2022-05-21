
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(23, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(513, 434);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar1.Location = new System.Drawing.Point(537, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 434);
            this.vScrollBar1.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(570, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 388);
            this.listBox1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 467);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(531, 21);
            this.textBox1.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.ToForm_B);
            this.Controls.Add(this.ToForm_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToForm_A;
        private System.Windows.Forms.Button ToForm_B;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

