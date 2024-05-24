using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public partial class FSaving : Form
    {
        SavingDAO savingDAO = new SavingDAO();
        CustomerDAO customerDAO = new CustomerDAO();
        DBConnection dBConnection = new DBConnection();
        Customer currentCustomer;
        int loans;
        int laisuat;

        public FSaving(Customer choosedCustomer)
        {
            InitializeComponent();
            this.currentCustomer = choosedCustomer;
            txtName.Text = currentCustomer.Name;
            txtMoney.Text = currentCustomer.Money.ToString();
        }

        private void FSaving_Load(object sender, EventArgs e)
        {
            LoadCustomerData($" WHERE STK = '{currentCustomer.Stk}'");
        }
        private void LoadCustomerData(string condition)
        {
            gvSaving.DataSource = dBConnection.Load("Saving", condition);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string randomMaSo = RandomMaSo();
            Saving saving = new Saving(currentCustomer.Stk, randomMaSo, Convert.ToInt32(txtMoneySend.Text), cbTerm.Text, cbMethod.Text, dtpSend.Value.Date, dtpEnd.Value.Date);
            int remainMoneyAfterSaving = Convert.ToInt32(currentCustomer.Money) - Convert.ToInt32(txtMoneySend.Text);
            if (remainMoneyAfterSaving < 0)
            {
                MessageBox.Show("Số dư tài khoản không đủ để tạo sổ tiết kiệm, vui lòng nạp thêm tiền.");
            }
            else if (remainMoneyAfterSaving < 50000)
            {
                MessageBox.Show("Số dư tài khoản của bạn phải có ít nhất 50000, vui lòng nạp thêm tiền.");
            }
            else
            {
                currentCustomer.Money = remainMoneyAfterSaving;
                txtMoneySend.Clear();
                customerDAO.UpdateMoney(currentCustomer);
                savingDAO.Create(saving);
                MessageBox.Show($"Bạn đã tạo thành công sổ tiết kiệm số: " + txtSavingNumber.Text + "\nKỳ hạn: " + cbTerm.Text + "\nNgày đáo hạn: " + dtpEnd.Value.Date + " (" + cbMethod.Text +")");
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Saving withdrawsaving = new Saving(txtSavingNumber.Text);
            savingDAO.Delete(withdrawsaving);
            LoadCustomerData($" WHERE MaSo = '{txtSavingNumber.Text}'");
            MessageBox.Show("Lưu ý: Rút tiền sẽ bị mất phí 5%");
            currentCustomer.Money = currentCustomer.Money + (Convert.ToInt32(txtMoneySend.Text) * 95 / 100);
            ClearInfomation();
            customerDAO.UpdateMoney(currentCustomer);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInfomation();
        }
        
        private void cbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbTerm.SelectedItem.ToString() == "12 thang voi lai suat 8%/ nam")
                dtpEnd.Value = dtpSend.Value.AddYears(1);
            else
                dtpEnd.Value = dtpSend.Value.AddYears(3);
        }

        private void dtpSend_ValueChanged(object sender, EventArgs e)
        {
            bool isMonthBorrow = cbTerm.Text.Contains("12");
            if (isMonthBorrow)
                dtpEnd.Value = dtpSend.Value.AddYears(1);
            else
                dtpEnd.Value = dtpSend.Value.AddYears(3);
        }

        private void ClearInfomation()
        {
            txtSavingNumber.Clear();
            txtMoneySend.Clear();
        }
        private string RandomMaSo()
        {
            Random random = new Random();
            return random.NextString(10);
        }
        
        private void btnCheck_Click(object sender, EventArgs e)
        {
            TimeSpan Time = DateTime.Now - dtpSend.Value.Date;           
            int TongSoNgay = Time.Days;
            if (cbTerm.Text.Contains("8") == true)
                laisuat = 8;
            else
                laisuat = 12;
            loans = (Convert.ToInt32(txtMoneySend.Text) * laisuat / 100) * TongSoNgay / 365;
            string msg = string.Format("So tien loi cua ban la {0} dong", loans);
            MessageBox.Show(msg);
            if ((DateTime.Compare(DateTime.Now, dtpEnd.Value.Date) >= 0))
            {
                if (cbMethod.Text.Contains("Nhan tien lai vao tai khoan, chuyen tien goc sang ky han moi") == true)
                {
                    currentCustomer.Money = currentCustomer.Money + loans;
                    customerDAO.UpdateMoney(currentCustomer);
                    string randomMaSo = RandomMaSo();
                    Saving saving = new Saving(currentCustomer.Stk, randomMaSo, Convert.ToInt32(txtMoneySend.Text), cbTerm.Text, cbMethod.Text, dtpSend.Value.Date, dtpEnd.Value.Date);
                    savingDAO.Create(saving);
                    Saving withdrawsaving = new Saving(txtSavingNumber.Text);
                    savingDAO.Delete(withdrawsaving);
                    MessageBox.Show("Da tra lai vao tai khoan");
                }
                else if (cbMethod.Text.Contains("Toan bo tien goc và tien lai sang ky han moi") == true)
                {
                    string randomMaSo = RandomMaSo();
                    int txtMoneysend_update = Convert.ToInt32(txtMoneySend.Text) + loans;
                    Saving saving = new Saving(currentCustomer.Stk, randomMaSo, txtMoneysend_update, cbTerm.Text, cbMethod.Text, dtpSend.Value.Date, dtpEnd.Value.Date);
                    savingDAO.Create(saving);
                    Saving withdrawsaving = new Saving(txtSavingNumber.Text);
                    savingDAO.Delete(withdrawsaving);
                    MessageBox.Show("Da chuyen goc va lai sang ky han moi");
                }
            }
        }

        private void gvSaving_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;
            txtSavingNumber.Text = gvSaving.Rows[numRow].Cells["MaSo"].Value.ToString();
            txtName.Text = currentCustomer.Name;
            txtMoney.Text = currentCustomer.Money.ToString();
            txtMoneySend.Text = gvSaving.Rows[numRow].Cells["Money"].Value.ToString();
            cbTerm.Text = gvSaving.Rows[numRow].Cells["KyHan"].Value.ToString();
            string Method = gvSaving.Rows[numRow].Cells["PhuongThucDaoHan"].Value.ToString();
            if (Method == "Nhan ca tien lai va goc( tu dong so) ")
            {
                cbMethod.StartIndex = 0;
            }
            else if (Method == "Toan bo tien goc và tien lai sang ky han moi")
            {
                cbMethod.StartIndex = 2;
            }
            else
            {
                cbMethod.StartIndex = 1;
            }
            dtpSend.Text = gvSaving.Rows[numRow].Cells["NgayGui"].Value.ToString();
            dtpEnd.Text = gvSaving.Rows[numRow].Cells["NgayDaoHan"].Value.ToString();
            btnWithdraw.Enabled = true;
            btnCheck.Enabled = true;
            if (cbMethod.Text.Contains("Nhan ca tien lai va goc( tu dong so) "))
            {
                if (dtpEnd.Value.Date == DateTime.Now.Date)
                {
                    currentCustomer.Money = currentCustomer.Money + Convert.ToInt32(txtMoneySend.Text) + loans;
                    customerDAO.UpdateMoney(currentCustomer);
                    Saving withdrawsaving = new Saving(txtSavingNumber.Text);
                    savingDAO.Delete(withdrawsaving);
                    LoadCustomerData($" WHERE MaSo = '{txtSavingNumber.Text}'");
                    MessageBox.Show("DA XOA SO THANH CONG, TIEN LAI VA GOC DA DUOC NHAN TRONG TAI KHOAN");
                }
            }
        }
    }
}
