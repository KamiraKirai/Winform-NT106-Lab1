using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_22521648
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_CLick(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.ShowDialog();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            bai4.ShowDialog();
        }

        private void button5_CLick(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            bai5.ShowDialog();
        }
    }
}
