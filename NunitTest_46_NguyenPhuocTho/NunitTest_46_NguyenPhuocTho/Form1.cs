using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NunitTest_46_NguyenPhuocTho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btndx_46_NguyenPhuocTho_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtn_46_NguyenPhuocTho.Text);

            SoDoiXung_46_NguyenPhuocTho f = new SoDoiXung_46_NguyenPhuocTho(n);
            int sum = f.GetResultTong();
            txtkqt_46_NguyenPhuocTho.Text = sum.ToString();
            bool ispalindrome = f.GetResultDX();
            txtkqdx_46_NguyenPhuocTho.Text = ispalindrome.ToString();
            

        }
    }
}
