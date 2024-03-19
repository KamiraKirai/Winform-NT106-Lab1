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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {
            double numb;
            if (!double.TryParse(textBox1.Text, out numb) && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng số thập phân");
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged (object sender, EventArgs e)
        {
            double numb;
            if (!double.TryParse(textBox2.Text, out numb) && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng số thập phân");
                textBox2.Text = "";
            }
        }

        private void textBox3_TextChanged (object sender, EventArgs e)
        {
            double numb;
            if (!Double.TryParse(textBox3.Text,out numb) && string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng số thập phân");
                textBox3.Text = "";
            }
        }

        private double FindMax(double num1, double num2, double num3)
        {
            return Math.Max(num1, Math.Max(num2, num3));
        }

        private double FindMin(double num1, double num2, double num3)
        {
            return Math.Min(num1, Math.Min(num2, num3));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0, num3 = 0, Min = 0, Max = 0;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            num3 = Convert.ToDouble(textBox3.Text);
            Max = FindMax(num1, num2, num3);
            Min = FindMin(num1, num2, num3);
            textBox4.Text = Convert.ToString(Max);
            textBox5.Text = Convert.ToString(Min);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
