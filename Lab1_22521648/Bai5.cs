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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            l_caonhat.Text = "";
            l_dau.Text = "";
            l_diem.Text= "";
            l_hocluc.Text = "";
            l_k_dau.Text = "";
            l_thapnhat.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text.Trim();

            
            if (!input.Split(' ').All(x => double.TryParse(x, out _)))
            {
                MessageBox.Show("Định dạng không hợp lệ!");
                return;
            }

            
            double[] diem = input.Split(' ').Select(double.Parse).ToArray();

            
            flowLayoutPanelDiem.Controls.Clear();

           
            for (int i = 0; i < diem.Length; i++)
            {
                Label label = new Label();
                label.Text = $"Môn {i + 1}: {diem[i]}";
                label.AutoSize = true;
                label.Top = 20 + i * 25;
                flowLayoutPanelDiem.Controls.Add(label);
            }

           
            double diemTB = diem.Average();
            l_diem.Text = $"{diemTB}";

            
            double diemCaoNhat = diem.Max();
            double diemThapNhat = diem.Min();
            l_caonhat.Text = $"{diemCaoNhat}";
            l_thapnhat.Text = $"{diemThapNhat}";

            
            int somondau = diem.Count(x => x >= 5);
            int somontruot = diem.Length - somondau;
            l_dau.Text = $"{somondau}";
            l_k_dau.Text = $"{somontruot}";

            
            string hocluc;
            if (diemTB >= 8 && diem.All(x => x >= 6.5))
            {
                hocluc = "Giỏi";
            }
            else if (diemTB >= 3.5 && diem.All(x => x >= 2))
            {
                hocluc = "Yếu";
            }
            else if (diemTB >= 6.5 && diem.All(x => x >= 5))
            {
                hocluc = "Khá";
            }
            else if (diemTB >= 5 && diem.All(x => x >= 3.5))
            {
                hocluc = "Trung bình";
            }
            else
            {
                hocluc = "Kém";
            }
            l_hocluc.Text = $"{hocluc}";
        
    }
    }
}
