using GiaTriLonNhat_22_NguyenThiThanhMai;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Test_BaoCao_22_NguyenThiThanhMai
{
    [TestClass]
    public class PhanTuLonNhatTrongMangTests_22_NguyenThiThanhMai

    {
        private int[] arr;

        [TestInitialize]
        public void SetUp()
        {
            // Khởi tạo mảng test
            arr = new int[] { 3, 7, 1, 9, 5 };
        }

        [TestMethod]
        public void Test_TimPhanTuLonNhat_22_NguyenThiThanhMai()
        {
            // Kiểm tra xem phương thức tìm phần tử lớn nhất hoạt động chính xác
            int expectedMax_22_NguyenThiThanhMai = 9;
            int actualMax_22_NguyenThiThanhMai = PhanTuLonNhatTrongMang_22_NguyenThiThanhMai.TimPhanTuLonNhat_22_NguyenThiThanhMai(arr);
            Assert.AreEqual(expectedMax_22_NguyenThiThanhMai, actualMax_22_NguyenThiThanhMai);
        }
        // Thuộc tính TestContext để truy cập dữ liệu của bộ kiểm thử
        public TestContext TestContext { get; set; }

        // Phương thức kiểm thử để tìm phần tử lớn nhất trong mảng
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"|DataDirectory|\Data\TestGiaTriLonNhat.csv", "TestGiaTriLonNhat#csv", DataAccessMethod.Sequential)]
        public void TestTimPhanTuLonNhat_22_NguyenThiThanhMai()
        {
            // Lấy chuỗi các số nguyên từ DataRow và chuyển đổi thành mảng số nguyên
            string mangSoNguyenStr_22_NguyenThiThanhMai = TestContext.DataRow[0].ToString();
            int phanTuLonNhatDuKien_22_NguyenThiThanhMai = Convert.ToInt32(TestContext.DataRow[1]);

            // Chuyển đổi chuỗi thành mảng số nguyên
            int[] mangSoNguyen_22_NguyenThiThanhMai = mangSoNguyenStr_22_NguyenThiThanhMai.Split(',').Select(int.Parse).ToArray();

            // Gọi phương thức để tính phần tử lớn nhất từ mảng
            int ketQua_22_NguyenThiThanhMai = PhanTuLonNhatTrongMang_22_NguyenThiThanhMai.TimPhanTuLonNhat_22_NguyenThiThanhMai(mangSoNguyen_22_NguyenThiThanhMai);

            // Kiểm tra kết quả
            Assert.AreEqual(phanTuLonNhatDuKien_22_NguyenThiThanhMai, ketQua_22_NguyenThiThanhMai);
        }

    }
}
