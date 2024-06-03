using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaTriLonNhat_22_NguyenThiThanhMai
{
    public class PhanTuLonNhatTrongMang_22_NguyenThiThanhMai
    {
        public static int TimPhanTuLonNhat_22_NguyenThiThanhMai(int[] mangSoNguyen_22_NguyenThiThanhMai)
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
