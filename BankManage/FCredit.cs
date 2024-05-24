using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankManage
{
    public partial class FCredit : Form
    {
        Customer customer;
        CustomerDAO customerDAO = new CustomerDAO();
        DBConnection DbConnection = new DBConnection();
        CreditDAO creditDAO = new CreditDAO();
        TransactionDAO transactionDAO = new TransactionDAO();
        Credit credit;

        public FCredit(Customer choosedCustomer)
        {
            InitializeComponent();
            customer = choosedCustomer;
        }

        private void FCredit_Load(object sender, EventArgs e)
        {
            LoadTransactionData($" WHERE STK = '{customer.Stk}' AND LoaiGD = 'Chuyen khoan Tin dung' OR STK = '{customer.Stk}' AND LoaiGD = 'Nhan tien Chuyen khoan'");

            credit = new Credit(customer.Stk);

            credit = creditDAO.Get(credit);

            txtSothe.Text = credit.ID;

            txtMoneyUsed.Text = credit.UsedMoney.ToString();

            if (DateTime.Now == credit.NgayDaoHan)
            {

                customer.Money = customer.Money - credit.UsedMoney;

                if (customer.Money < 50000)
                {
                    MessageBox.Show("Số tiền trong tài khoản gốc không đủ để trả thế chấp. Bạn sẽ bị khóa thẻ");
                    btnDelete.Enabled = false;
                    btnSubmit.Enabled = false;
                }
                else
                {
                    customerDAO.UpdateMoney(customer);
                }
            }

            if (credit.UsedMoney > credit.HanMuc)
            {
                MessageBox.Show("Bạn đã xài quá hạn mức. Vui lòng gửi tiền vào thẻ để tiếp tục sử dụng");
            }
            else
            {
                if (txtSothe.Text == "")
                {
                    btnSubmit.Enabled = true;
                    btnDelete.Enabled = false;
                    cmbHanMuc.Enabled = true;
                    cmbMethod.Enabled = true;
                    btnShowTrans.Enabled = false;
                }
                else
                {
                    string HanMuc = credit.HanMuc.ToString();
                    if (HanMuc.Contains("5") == true)
                    {
                        cmbHanMuc.StartIndex = 0;
                    }
                    else if (HanMuc.Contains("10") == true)
                    {
                        cmbHanMuc.StartIndex = 1;
                    }
                    else
                    {
                        cmbHanMuc.StartIndex = 2;
                    }

                    string Method = credit.Method;
                    if (Method == "Sao kê bảng lương")
                    {
                        cmbMethod.StartIndex = 0;
                    }
                    else if (Method == "Hợp đồng lao động")
                    {
                        cmbMethod.StartIndex = 1;
                    }
                    else
                    {
                        cmbMethod.StartIndex = 2;
                    }
                    btnDelete.Enabled = true;
                    btnSubmit.Enabled = false;
                    cmbHanMuc.Enabled = false;
                    cmbMethod.Enabled = false;
                    btnShowTrans.Enabled = true;
                }
            }
            if (txtMoneyUsed.Text == "0")
            {
                btnPay.Enabled = false;
            }
            else
            {
                btnPay.Enabled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string MaThe = random.NextString(10);

            if (cmbHanMuc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hạn mức thẻ");
            }
            else
            {
                int hanmuc = 0;

                switch (cmbHanMuc.SelectedIndex)
                {
                    case 0: 
                        hanmuc = 5000000; 
                        break;
                    case 1: 
                        hanmuc = 10000000; 
                        break;
                    case 2: 
                        hanmuc = 20000000; 
                        break;
                }
                credit = new Credit(customer.Stk, MaThe, hanmuc, 0, cmbMethod.Text, DateTime.Now, DateTime.Now.AddMonths(1));
                creditDAO.Create(credit);

                MessageBox.Show("Chúc mừng bạn đã mở thẻ tín dụng thành công:\nSố thẻ: " + MaThe + "\nHạn mức cho phép:" + hanmuc + "\nVui lòng thanh toán dư nợ vào ngày " + DateTime.Now.Day + " của tháng tiếp theo, nếu phát sinh giao dịch");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit(customer.Stk, txtSothe.Text);
            creditDAO.Delete(credit);
            transactionDAO.DeleteCredit(customer.Stk);
            FCredit_Load(sender, e);
            btnDelete.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInformation();
            btnDelete.Enabled = false;
            gvHistory.Visible = false;
        }
        private void btnShowTrans_Click(object sender, EventArgs e)
        {
            gvHistory.Visible = true;
        }
        private void ClearInformation()
        {
            cmbHanMuc.Items.Clear();
            txtMoneyUsed.Clear();
            txtSothe.Clear();
            cmbMethod.Text = "";
        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMethod.Text != "")
            {
                btnSubmit.Enabled = true;
            }
        }
        private void LoadTransactionData(string condition)
        {
            gvHistory.DataSource = DbConnection.Load("Trans", condition);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Credit paycredit = new Credit(customer.Stk);
            paycredit = creditDAO.Get(paycredit);
            int remainMoney = customer.Money - Convert.ToInt32(txtMoneyUsed.Text);
            if (remainMoney < 0)
                MessageBox.Show("Số tiền trong tài khoản không đủ, vui lòng nạp thêm tiền");
            else
            {
                customer.Money = remainMoney;
                customerDAO.UpdateMoney(customer);
                txtMoneyUsed.Text = "0";
                paycredit.UsedMoney = 0;
                creditDAO.Update(paycredit);
                transactionDAO.DeleteCredit(customer.Stk);
                MessageBox.Show("Thanh toán thành công");
                btnDelete.Enabled = false;
            }
        }
    }
}