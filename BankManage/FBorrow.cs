using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public partial class FBorrow : Form
    {
        CustomerDAO customerDAO = new CustomerDAO();
        BorrowDAO borrowDAO = new BorrowDAO();
        DBConnection dBConnection = new DBConnection();
        Customer currentCustomer;
        public FBorrow(Customer choosedCustomer)
        {

            InitializeComponent();
            this.currentCustomer = choosedCustomer;
            txtMoneyRemain.Text = currentCustomer.Money.ToString();
            txtID.Text = currentCustomer.CitizenId.ToString();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            bool isMonthBorrow = cbTerm.Text.Contains("12");
            if (isMonthBorrow)
                dtpBack.Value = dtpAllow.Value.AddYears(1);
            else
                dtpBack.Value = dtpAllow.Value.AddMonths(8);
        }

        private void cbKyhan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbTerm.SelectedIndex == 0)
                dtpBack.Value = dtpAllow.Value.AddYears(1);
            else
                dtpBack.Value = dtpAllow.Value.AddMonths(8);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidForm())
            {
                Borrow borrow = new Borrow(Convert.ToInt32(txtMoneyRemain.Text), currentCustomer.CitizenId, Convert.ToInt32(txtEarnings.Text), Convert.ToInt32(txtMoneyBorrow.Text), cbTypeOfCredit.Text, cbCollateral.Text, cbTerm.Text, dtpAllow.Value.Date, dtpBack.Value.Date);

                if (Convert.ToInt32(txtMoneyBorrow.Text) > (15 * Convert.ToInt32(txtEarnings.Text)) + Convert.ToInt32(txtMoneyRemain.Text))
                {
                    MessageBox.Show("Bạn không được phép vay, bởi vì quá mức giới hạn chi trả của bạn");
                }
                else
                {
                    borrowDAO.Create(borrow);
                    MessageBox.Show("Chúc mừng bạn đã vay thành công với số tiền: " + txtMoneyBorrow.Text + "\nKỳ hạn: " + cbTerm.Text + "\nVui lòng thanh toán trước " + dtpBack.Value.Date);
                }
            }
        }

        private void cbTypeOfCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCollateral.Enabled = cbTypeOfCredit.SelectedIndex == 0;
        } 
        private void FBorrow_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData($" WHERE CitizenID = '{currentCustomer.CitizenId}'");
                if (txtMoneyBorrow.Text == "")
                {
                    MessageBox.Show("Hiện tại bạn không có khoản vay hay khoản nợ xấu nào.");
                    btnSubmit.Enabled = true;
                    btnPay.Enabled = false;

                }
                else if (DateTime.Compare(DateTime.Now, dtpBack.Value.Date) >= 0)
                {
                    MessageBox.Show("Hiện tại bạn đang có khoản nợ xấu, vui lòng thanh toán.");
                    btnSubmit.Enabled = false;
                    btnPay.Enabled = true;
                    btnCancel.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Bạn đã có một khoản vay với số tiền: " + txtMoneyBorrow.Text + " vào ngày: " + dtpAllow.Value.Date + "\nVui lòng thanh toán trước ngày: " + dtpBack.Value.Date + " để không phải đưa vào danh sách nợ xấu.");
                    btnSubmit.Enabled = false;
                    btnPay.Enabled = true;
                    btnCancel.Enabled = false;
                }
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEarnings.Clear();
            txtMoneyBorrow.Clear();           
        }

        private void LoadData(string condition)
        {
            try
            {
                var data = dBConnection.Load("Borrow", condition);
                if (data.Rows.Count > 0)
                {
                    txtEarnings.Text = data.Rows[0]["Salary"].ToString();
                    txtMoneyBorrow.Text = data.Rows[0]["MoneyBorrow"].ToString();
                    
                    string TypeOfCredit = data.Rows[0]["KieuTinDung"].ToString();
                    if (TypeOfCredit == "Vay thế chấp")
                    {
                        cbTypeOfCredit.StartIndex = 0;
                    }
                    else
                    {
                        cbTypeOfCredit.StartIndex = 1;
                    }

                    string Collateral = data.Rows[0]["TaiSanTheChap"].ToString();
                    if (Collateral == "Sổ hồng, sổ đỏ nhà")
                    {
                        cbCollateral.StartIndex = 0;
                    }
                    else if (Collateral == "Cà vẹt xe")
                    {
                        cbCollateral.StartIndex = 1;
                    }
                    else if (Collateral == "Giấy phép xây dựng")
                    {
                        cbCollateral.StartIndex = 2;
                    }
                    else
                    {
                        cbCollateral.StartIndex = 3;
                    }

                    string Term = data.Rows[0]["KyHan"].ToString();
                    if (Term.Contains("12") == true)
                    {
                        cbTerm.StartIndex = 0;
                    }
                    else
                    {
                        cbTerm.StartIndex = 1;
                    }

                    dtpAllow.Text = data.Rows[0]["NgayChoVay"].ToString();
                    dtpBack.Text = data.Rows[0]["NgayHoanTien"].ToString();
                }
            } catch { }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Borrow payBorrow = new Borrow(txtID.Text);
            int remainMoney = Convert.ToInt32(txtMoneyRemain.Text) - Convert.ToInt32(txtMoneyBorrow.Text);
            if (remainMoney < 0)
                MessageBox.Show("Số tiền trong tài khoản không đủ, vui lòng nạp thêm tiền");
            else
            {
                currentCustomer.Money = remainMoney;
                customerDAO.UpdateMoney(currentCustomer);
                borrowDAO.Delete(payBorrow);
                MessageBox.Show("Thanh toán khoản vay thành công");
            }
        }
        private bool isValidForm()
        {
            if (txtEarnings.Text == "")
            {
                MessageBox.Show("Vui long nhập thu nhập hàng tháng");
                return false;
            }
            else if (txtMoneyBorrow.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền muốn vay");
                return false;
            }
            else if (cbTypeOfCredit.Text == "")
            {
                MessageBox.Show("Vui lòng chọn kiểu tín dụng");
                return false;
            }
            else if (cbTerm.Text == "")
            {
                MessageBox.Show("Vui lòng chọn kỳ hạn vay");
                return false;
            }
            return true;
        }
    }
}
