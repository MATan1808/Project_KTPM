using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaTriLonNhat_22_NguyenThiThanhMai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_22_NguyenThiThanhMai_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem dữ liệu nhập vào từ TextBox có hợp lệ không
            if (!string.IsNullOrWhiteSpace(txta_22_NguyenThiThanhMai.Text))
            {
                // Tách chuỗi nhập vào thành các phần tử của mảng
                string[] inputValues = txta_22_NguyenThiThanhMai.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Tạo mảng số nguyên với kích thước bằng độ dài của chuỗi nhập vào
                int[] numbers = new int[inputValues.Length];

                // Nhập dữ liệu vào mảng từ chuỗi nhập vào
                for (int i = 0; i < inputValues.Length; i++)
                {
                    // Kiểm tra xem giá trị nhập vào có hợp lệ không
                    if (int.TryParse(inputValues[i], out int value))
                    {
                        numbers[i] = value; // Gán giá trị vào mảng
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu nhập vào không hợp lệ!"); // Thông báo lỗi nếu dữ liệu không hợp lệ
                        return;
                    }
                }
                // Gọi hàm TimPhanTuLonNhat để tìm giá trị lớn nhất trong mảng
                int max = TimPhanTuLonNhat_22_NguyenThiThanhMai(numbers);

                // Hiển thị giá trị lớn nhất tìm được trên TextBox txtb
                txtb_22_NguyenThiThanhMai.Text = max.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên!"); // Thông báo lỗi nếu dữ liệu nhập vào không hợp lệ
            }
        }

        private int TimPhanTuLonNhat_22_NguyenThiThanhMai(int[] mangSoNguyen_22_NguyenThiThanhMai)
        {
            if (mangSoNguyen_22_NguyenThiThanhMai == null || mangSoNguyen_22_NguyenThiThanhMai.Length == 0)
                throw new ArgumentException("Mảng rỗng hoặc không tồn tại");

            int max = mangSoNguyen_22_NguyenThiThanhMai[0];
            foreach (var phanTu in mangSoNguyen_22_NguyenThiThanhMai)
            {
                if (phanTu > max)
                    max = phanTu;
            }
            return max;
        }

    }
}
