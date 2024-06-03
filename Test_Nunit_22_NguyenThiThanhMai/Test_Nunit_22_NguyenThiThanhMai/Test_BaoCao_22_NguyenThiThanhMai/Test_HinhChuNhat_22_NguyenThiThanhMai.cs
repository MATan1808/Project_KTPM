using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUNIT_22_NguyenThiThanhMai;

namespace Test_BaoCao_22_NguyenThiThanhMai
{
    [TestClass]
    public class Test_HinhChuNhat_22_NguyenThiThanhMai
    {      
            private HinhChuNhat_22_NguyenThiThanhMai hinhChuNhat;
            [TestInitialize]
            public void setUp()
            {
                // Khởi tạo đối tượng hình chữ nhật với chiều dài 5.0 và chiều rộng 10.0
                hinhChuNhat = new HinhChuNhat_22_NguyenThiThanhMai(5.0, 10.0);
            }

            [TestMethod]
            public void TestHinhChuNhatInitialization_22_NguyenThiThanhMai()
            {
                // Kiểm tra tính chính xác của chu vi
                Assert.AreEqual(30.0, hinhChuNhat.TinhChuVi_HinhChuNhat_22_NguyenThiThanhMai());
            }
        
        // Thuộc tính TestContext để truy cập dữ liệu của bộ kiểm thử
        public TestContext TestContext { get; set; }
        // Phương thức kiểm thử tính chu vi hình chữ nhật
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestHinhChuNhat.csv", "TestHinhChuNhat#csv", DataAccessMethod.Sequential)]
        public void TestTinhChuVi_22_NguyenThiThanhMai()
        {
            // Arrange
            // Lấy chiều dài và chiều rộng từ DataRow và chuyển đổi sang kiểu double
            double chieuDai_22_NguyenThiThanhMai = double.Parse(TestContext.DataRow[0].ToString());
            double chieuRong_22_NguyenThiThanhMai = double.Parse(TestContext.DataRow[1].ToString());
            // Lấy chu vi dự kiến từ DataRow
            double kq_mongdoi_ChuVi_22_NguyenThiThanhMai = double.Parse(TestContext.DataRow[2].ToString());

            // Act
            // Tạo đối tượng hình chữ nhật với chiều dài và chiều rộng đã có
            var hinhChuNhat_22_NguyenThiThanhMai = new HinhChuNhat_22_NguyenThiThanhMai(chieuDai_22_NguyenThiThanhMai, chieuRong_22_NguyenThiThanhMai);
            // Tính chu vi thực tế của hình chữ nhật
            double kq_thucte_ChuVi_22_NguyenThiThanhMai = hinhChuNhat_22_NguyenThiThanhMai.TinhChuVi_HinhChuNhat_22_NguyenThiThanhMai();

            // Assert
            // Kiểm tra kết quả tính được có khớp với kết quả mong đợi không
            Assert.AreEqual(kq_mongdoi_ChuVi_22_NguyenThiThanhMai, kq_thucte_ChuVi_22_NguyenThiThanhMai, 0.0001, "Chu vi tính được không chính xác.");
        }
        
    }
}
