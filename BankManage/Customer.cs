using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManage
{
    public class Customer
    {
        private string stk;
        private string name;
        private string address;
        private DateTime dob;
        private string citizenId;
        private string phoneNumber;
        private int money;
        private DateTime createdAt;
        private DateTime updatedAt;

        public string Stk { get { return stk; } }
        public string Name { get { return name; } }
        public string Address { get { return address; } }
        public DateTime Dob { get { return dob; } }
        public string CitizenId { get { return citizenId; } }
        public string PhoneNumber { get { return phoneNumber; } }
        public int Money { get { return money; } set { money = value; } }
        public DateTime CreatedAt { get { return createdAt; } set { createdAt = value; } }
        public DateTime UpdatedAt { get { return updatedAt; } set { updatedAt = value; } }

        public Customer()
        {

        }

        public Customer(string stk, string name, string address, DateTime dob, string citizenId, string phoneNumber, int money)
        {
            this.stk = stk;
            this.name = name;
            this.address = address;
            this.dob = dob;
            this.citizenId = citizenId;
            this.phoneNumber = phoneNumber;
            this.money = money;
        }

        public Customer(string stk)
        {
            this.stk = stk;
        }
        public Customer(string STK, string citizenId)
        {
            this.citizenId = citizenId;
        }
    }
}
