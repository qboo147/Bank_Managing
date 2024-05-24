using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManage
{
    public class Saving
    {
        private string stk;
        private string maso;
        private int money;
        private string kyhan;
        private string phuongthucdaohan;      
        private DateTime ngaygui;
        private DateTime ngaydaohan;
        public string STK { get { return stk; } set { stk = value; } }
        public string MaSo { get { return maso; } set { maso = value; } }
        public int Money { get { return money; } set { money = value; } }
        public string KyHan { get { return kyhan; } set { kyhan = value; } }
        public string PhuongThucDaoHan { get { return phuongthucdaohan; } set { phuongthucdaohan = value; } }
        public DateTime NgayGui { get { return ngaygui; } set { ngaygui = value; } }
        public DateTime NgayDaoHan { get { return ngaydaohan; } set { ngaydaohan = value; } }

        public Saving(string stk, string maso, int money, string kyhan, string phuongthucdaohan, DateTime ngaygui, DateTime ngaydaohan)
        {   
            this.stk = stk;
            this.maso = maso;
            this.money = money;
            this.kyhan = kyhan;
            this.phuongthucdaohan = phuongthucdaohan;
            this.ngaygui = ngaygui;
            this.ngaydaohan = ngaydaohan;

        }
        public Saving(string maso)
        {
            this.maso = maso;
        }
    }
}
