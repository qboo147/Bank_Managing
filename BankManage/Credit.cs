using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManage
{
    internal class Credit
    {
        private string stk;
        private string id;
        private int hanmuc;
        private int usedmoney;
        private string method;
        private DateTime ngaymo;
        private DateTime ngaydaohan;

        public string STK { get { return stk; } set { stk = value; } }
        public string ID { get { return id; } set { id = value; } }
        public int HanMuc { get { return hanmuc; } set { hanmuc = value; } }
        public int UsedMoney { get { return usedmoney; } set { usedmoney = value; } }
        public string Method { get { return method; } set { method = value; } }
        public DateTime NgayMo { get { return ngaymo; } set { ngaymo = value; } }
        public DateTime NgayDaoHan { get { return ngaydaohan; } set { ngaydaohan = value; } }

        public Credit(string stk, string id, int hanmuc, int usedmoney, string method, DateTime ngaymo, DateTime ngaydaohan)
        {
            this.stk = stk;
            this.id = id;
            this.hanmuc = hanmuc;
            this.usedmoney = usedmoney;
            Method = method;
            this.ngaymo = ngaymo;
            this.ngaydaohan = ngaydaohan;
        }
        public Credit(string stk)
        {
            this.stk = stk;
        }
        public Credit(string stk, string id)
        {
            this.id = id;
        }
    }
}
