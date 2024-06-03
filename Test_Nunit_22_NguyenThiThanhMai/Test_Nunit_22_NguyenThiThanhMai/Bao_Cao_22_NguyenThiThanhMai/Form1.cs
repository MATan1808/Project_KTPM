using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bao_Cao_22_NguyenThiThanhMai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtkq_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có thể chuyển đổi dữ liệu trong TextBox sang số nguyên không
            if (int.TryParse(txt1.Text, out int width) && int.TryParse(txt2.Text, out int height))
            {
                // Tính chu vi hình chữ nhật
                int perimeter = 2 * (width + height);
                // Hiển thị kết quả chu vi trong TextBox kết quả
                txtkq.Text = perimeter.ToString();
            }
            else
            {
                // Nếu không thể chuyển đổi, hiển thị thông báo lỗi
                txtkq.Text = "Invalid input";
            }
        }
    }
}
