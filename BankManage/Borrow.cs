using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManage
{
   public class Borrow
    {
        private int money;
        private string citizenID;
        private int salary;
        private int moneyborrow;
        private string kieutindung;
        private string taisanthechap;
        private string kyhan;
        private DateTime ngaychovay;
        private DateTime ngayhoantien;

        public int Money { get { return money; } set { money = value; } }
        public string CitizenID { get { return citizenID; }  set { citizenID = value; }}
        public int Salary { get { return salary; } set { salary = value; } }
        public int Moneyborrow { get { return moneyborrow; } set { moneyborrow = value; } }
        public string KieuTinDung { get { return kieutindung; } set { kieutindung = value; } }
        public string TaiSanTheChap { get { return taisanthechap; } set { taisanthechap = value; } }
        public string KyHan { get { return kyhan; } set { kyhan = value; } }
        public DateTime NgayChoVay { get { return ngaychovay; } set { ngaychovay = value; } }
        public DateTime NgayHoanTien { get { return ngayhoantien; } set { ngayhoantien = value; } }
        public Borrow(int money, string citizenID, int salary, int moneyborrow, string kieutindung,string taisanthechap,string kyhan, DateTime ngaychovay, DateTime ngayhoantien)
        {
            this.money = money;
            this.citizenID = citizenID;
            this.salary = salary;
            this.moneyborrow = moneyborrow;
            this.kieutindung = kieutindung;
            this.taisanthechap = taisanthechap;
            this.kyhan = kyhan;
            this.ngaychovay = ngaychovay;
            this.ngayhoantien = ngayhoantien;
        }
        public Borrow (string citizenID)
        {
            this.citizenID = citizenID;
        }
    }
}
