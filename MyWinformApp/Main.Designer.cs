﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ToForm_A = new System.Windows.Forms.Button();
            this.ToForm_B = new System.Windows.Forms.Button();
            this.SaveData = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToForm_A
            // 
            this.ToForm_A.Location = new System.Drawing.Point(645, 42);
            this.ToForm_A.Name = "ToForm_A";
            this.ToForm_A.Size = new System.Drawing.Size(106, 26);
            this.ToForm_A.TabIndex = 2;
            this.ToForm_A.Text = "To Form A";
            this.ToForm_A.UseVisualStyleBackColor = true;
            // 
            // ToForm_B
            // 
            this.ToForm_B.Location = new System.Drawing.Point(645, 86);
            this.ToForm_B.Name = "ToForm_B";
            this.ToForm_B.Size = new System.Drawing.Size(106, 26);
            this.ToForm_B.TabIndex = 3;
            this.ToForm_B.Text = "To Form B";
            this.ToForm_B.UseVisualStyleBackColor = true;
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(645, 136);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(106, 26);
            this.SaveData.TabIndex = 4;
            this.SaveData.Text = "Save Data";
            this.SaveData.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(645, 183);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(106, 26);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyWinformApp.Properties.Resources.lore_riven;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 585);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.ToForm_B);
            this.Controls.Add(this.ToForm_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToForm_A;
        private System.Windows.Forms.Button ToForm_B;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

