using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUNIT_22_NguyenThiThanhMai
{
    public class HinhChuNhat_22_NguyenThiThanhMai
    {
        // Thuộc tính ChieuDai dùng để lưu trữ chiều dài của hình chữ nhật
        public double ChieuDai_22_NguyenThiThanhMai { get; set; }

        // Thuộc tính ChieuRong dùng để lưu trữ chiều rộng của hình chữ nhật
        public double ChieuRong_22_NguyenThiThanhMai { get; set; }

        // Constructor: Phương thức khởi tạo 
        public HinhChuNhat_22_NguyenThiThanhMai(double chieuDai, double chieuRong)
        {
            ChieuDai_22_NguyenThiThanhMai = chieuDai;
            ChieuRong_22_NguyenThiThanhMai = chieuRong;
        }
        // Phương thức để tính chu vi của hình chữ nhật
        public double TinhChuVi_HinhChuNhat_22_NguyenThiThanhMai()
        {
            return 2 * (ChieuDai_22_NguyenThiThanhMai + ChieuRong_22_NguyenThiThanhMai);
        }
    }

}

