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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hello");
            listBox1.Items.Add("Hi");   
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        
    }
}
