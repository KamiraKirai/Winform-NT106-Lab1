﻿using System;
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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged (object sender, EventArgs e)
        {
            int numb;
            if (!Int32.TryParse(textBox1.Text, out numb) && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng số thập phân");
                textBox1.Text = "";
            }
                      
        }
        private void textBox2_TextChanged (object sender, EventArgs e)
        {
            int numb;
            if (!Int32.TryParse(textBox2.Text, out numb) && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng số thập phân");
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            if (int.TryParse(textBox1.Text, out int Num1) && int.TryParse(textBox2.Text, out int Num2))
            {
                 Sum = Num1 + Num2;
                 textBox3.Text = Sum.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
