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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int numb;
            if (!Int32.TryParse(textBox1.Text, out numb) && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng số thập phân");
                textBox1.Text = "";
            }
        }

        static string[] ones = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        static string[] teens = { "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
        static string[] tens = { "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        static string[] hundreds = {"", "", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm"};

        static string ConvertToVietnamese(int number)
        {
            switch (number)
            {
                case int n when n < 10:
                    return ones[n];
                    break;
                case int n when n < 20:
                    return teens[n % 10];
                    break;
                case int n when n < 100:
                    return tens[n / 10] + " " + ones[n % 10];
                    break;
                case 100:
                    return "một trăm";
                    break;
                case int n when n < 1000:
                    if (n % 100 == 0)
                        return hundreds[n / 100];
                    else if (n % 100 < 10)
                        return hundreds[n / 100] + " lẻ " + ones[n % 10];
                    else if (n % 100 < 20)
                        return hundreds[n / 100] + " " + teens[n % 10];
                    else
                        return hundreds[n / 100] + " " + tens[(n % 100) / 10] + " " + ones[(n % 100) % 10];
                default:
                    return "Error";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numb = Int32.Parse(textBox1.Text);
            if (ConvertToVietnamese(numb) == "Error")
            {
                MessageBox.Show("Vui lòng nhập đúng số nguyên từ 0 đến 999");
                textBox2.Text = "";
            }
            textBox2.Text = ConvertToVietnamese(numb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
