using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using WinCEUtility;

namespace TestProject
{
    public partial class Form1 : Form
    {
        UCMessageBox ucMessageBox1 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

            ucMessageBox1 = new UCMessageBox(panel3);
        }


        private void btn_show1_Click(object sender, EventArgs e)
        {
            ucMessageBox1.Show("Hello", "This is test message!", MsgButtons.YesNo, DisplayState.FullScreen, 0);
        }

        private void btn_show2_Click(object sender, EventArgs e)
        {
            ucMessageBox1.DefaultWidth = 400;
            ucMessageBox1.DefaultHeight = 300;
            ucMessageBox1.Show("Hello", "This is test message!", MsgButtons.OK, DisplayState.Normal, 10);
        }

        private void btn_show3_Click(object sender, EventArgs e)
        {
            ucMessageBox1.Show("WARNING", "Please Waiting...", MsgButtons.None, DisplayState.FullScreen, 1);
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            ucMessageBox1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCMessageBox boc = new UCMessageBox(this);
            boc.Show("DENEME", "DENEME 2", MsgButtons.OK, DisplayState.Normal, 30);
        }
    }
}