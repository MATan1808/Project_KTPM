using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NunitTest_46_NguyenPhuocTho;
namespace UnitTest_46_NguyenPhuocTho
{
    [TestClass]
    public class UnitTest1
    {
        private SoDoiXung_46_NguyenPhuocTho KQDoiXung_46_NguyenPhuocTho, TongDayN_46_NguyenPhuocTho;
        [TestInitialize]
        public void SetUp()
        {
            KQDoiXung_46_NguyenPhuocTho = new SoDoiXung_46_NguyenPhuocTho(121);
            TongDayN_46_NguyenPhuocTho = new SoDoiXung_46_NguyenPhuocTho(1234);

        }
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
           @".\Data_46_NguyenPhuocTho\TestDX_46_NguyenPhuocTho.csv", "TestDX_46_NguyenPhuocTho#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestDX_DataSource_46NguyenPhuocTho()
        {
            int n = int.Parse(TestContext.DataRow[0].ToString());
           
            bool expected = bool.Parse(TestContext.DataRow[1].ToString());
            SoDoiXung_46_NguyenPhuocTho c = new SoDoiXung_46_NguyenPhuocTho(n);
               bool actual = c.GetResultDX();

               Assert.AreEqual(expected, actual);

        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
          @".\Data_46_NguyenPhuocTho\TestTong_46_NguyenPhuocTho.csv", "TestTong_46_NguyenPhuocTho#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestTong_DataSource_46NguyenPhuocTho()
        {
            int n = int.Parse(TestContext.DataRow[0].ToString());

            int expected = int.Parse(TestContext.DataRow[1].ToString());
            SoDoiXung_46_NguyenPhuocTho c = new SoDoiXung_46_NguyenPhuocTho(n);
            int actual = c.GetResultTong();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestDX_46_NguyenPhuocTho()
        {
            bool expected, actual;
            expected = true;
            KQDoiXung_46_NguyenPhuocTho.Execute("dx");
            actual = KQDoiXung_46_NguyenPhuocTho.GetResultDX();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestTongDayN_46_NguyenPhuocTho()
        {
            int expected, actual;
            expected = 10;

            TongDayN_46_NguyenPhuocTho.Execute("Tongn");
            actual = TongDayN_46_NguyenPhuocTho.GetResultTong();
            Assert.AreEqual(expected, actual);
        }

    }
}
