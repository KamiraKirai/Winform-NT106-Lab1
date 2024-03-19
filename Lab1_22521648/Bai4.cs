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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            comboBox1.Text = "Binary";
            comboBox2.Text = "Hexadecimal";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập thông tin");
            }
            else
            {
                try
                {
                    if (comboBox1.Text == "Binary" && comboBox2.Text == "Decimal")
                        textBox2.Text = Convert.ToInt32(textBox1.Text, 2).ToString();

                    else if (comboBox1.Text == "Binary" && comboBox2.Text == "Hexadecimal")
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 16);

                    else if (comboBox1.Text == "Decimal" && comboBox2.Text == "Binary")
                        textBox2.Text = Convert.ToString(int.Parse(textBox1.Text), 2);

                    else if (comboBox1.Text == "Decimal" && comboBox2.Text == "Hexadecimal")
                        textBox2.Text = Convert.ToString(int.Parse(textBox1.Text), 16);

                    else if (comboBox1.Text == "Hexadecimal" && comboBox2.Text == "Binary")
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 2);

                    else if (comboBox1.Text == "Hexadecimal" && comboBox2.Text == "Decimal")
                        textBox2.Text = Convert.ToInt32(textBox1.Text, 16).ToString();

                    else
                        MessageBox.Show("Không hỗ trợ chuyển đổi từ " + comboBox1.Text + " sang " + comboBox2.Text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(FormatException)
                {
                    MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
        }

        private void button3_CLick(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
