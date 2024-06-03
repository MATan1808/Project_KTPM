using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest_46_NguyenPhuocTho
{
    public class SoDoiXung_46_NguyenPhuocTho
    {
        private int n;
        public SoDoiXung_46_NguyenPhuocTho(int n)
        {
            this.n = n; 
        }
        public void Execute(string CalSymbol)
        {
            
            switch (CalSymbol)
            {
                case "dx":
                    KQDoiXung_46_NguyenPhuocTho(); break;
                case "Tongn":
                    TongDayN_46_NguyenPhuocTho(); break;
               
            }
            
        }
        private bool KQDoiXung_46_NguyenPhuocTho()
        {
            int orig_n = n;
            int reversed_n = 0;

            while (n > 0)
            {
                int digit = n % 10;
                reversed_n = reversed_n * 10 + digit;
                n /= 10;
            }

            return orig_n == reversed_n;
        }
        private int TongDayN_46_NguyenPhuocTho()
        {
            int sum=0, num=n;
            while (num > 0)
            {
                int digit = num % 10; 
                sum += digit;
                num /= 10; 
            }
            return sum;
        }
        public bool GetResultDX()
        {
            return KQDoiXung_46_NguyenPhuocTho();
        }
        //public string GetResultDX1()
        //{
        //    return KQDoiXung_46_NguyenPhuocTho().ToString();
        //}
        public int GetResultTong()
        {
            return TongDayN_46_NguyenPhuocTho();
        }
    }
}
