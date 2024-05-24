using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManage
{
    public class Transaction
    {
        private string stk;
        private string maGD;
        private string loaiGD;
        private int money;
        private DateTime thoigianGD;
        private string receivedSTK;
        private string note;

        public string STK { get { return stk; } set { stk = value; } }
        public string MaGD { get { return maGD; } set { maGD = value; } }
        public string LoaiGD { get { return loaiGD; } set { loaiGD = value; } }
        public int Money { get { return money; } set { money = value; } }
        public DateTime ThoigianGD { get { return thoigianGD; } set { thoigianGD = value; } }
        public string ReceivedSTK { get { return receivedSTK; } set { receivedSTK = value; } }

        public string Note { get { return note; } set { note = value; } }

        public Transaction(string stk, string maGD, string loaiGD, int money, DateTime thoigianGD, string receivedSTK, string note)
        {
            this.stk = stk;
            this.maGD = maGD;
            this.loaiGD = loaiGD;
            this.money = money;
            this.thoigianGD = thoigianGD;
            this.receivedSTK = receivedSTK;
            this.note = note;
        }
    }
}
