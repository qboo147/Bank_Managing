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
    public partial class FInformation : Form
    {
        CustomerDAO customerDAO = new CustomerDAO();
        DBConnection dBConnection = new DBConnection();
        Customer customer;
        DataTable datatable;

        public FInformation(Customer choosedCustomer, DataTable datatable)
        {
            InitializeComponent();
            customer = choosedCustomer;
            this.datatable = datatable;
        }

        private void FInformation_Load(object sender, EventArgs e)
        {
            LoadInformation();
            if (txtSTK.Text != "")
            {
                btnCreate.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string randomStk = RandomSTK();
            for (int i = 0; i < datatable.Rows.Count - 1; i++)
                while (randomStk == datatable.Rows[i]["STK"].ToString())
                    randomStk = RandomSTK();
            Customer newCustomer = new Customer(randomStk, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, 0)
            {
                CreatedAt = DateTime.Now
            };
            if (customerDAO.ValidateFormCreate(newCustomer))
                MessageBox.Show("Khong duoc de trong");
            customerDAO.Create(newCustomer);
            ClearInfomation();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer updatedCustomer = new Customer(txtSTK.Text, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, Convert.ToInt32(txtMoney.Text));
            updatedCustomer.UpdatedAt = DateTime.Now;
            if (customerDAO.ValidateFormCreate(updatedCustomer))
                MessageBox.Show("Khong duoc de trong");
            else
            {
                customerDAO.Update(updatedCustomer);
                ClearInfomation();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer deletetedCustomer = new Customer(txtSTK.Text);
            customerDAO.Delete(deletetedCustomer);
            ClearInfomation();
        }

        private void ClearInfomation()
        {
            txtSTK.Clear();
            txtName.Clear();
            txtAddr.Clear();
            txtID.Clear();
            txtPNum.Clear();
            txtMoney.Clear();
        }

        private string RandomSTK()
        {
            Random random = new Random();
            return random.NextString(10);
        }

        private void LoadInformation()
        {
            txtSTK.Text = customer.Stk;
            txtName.Text = customer.Name;
            txtAddr.Text = customer.Address;
            txtID.Text = customer.CitizenId;
            txtPNum.Text = customer.PhoneNumber;
            txtMoney.Text = customer.Money.ToString();
        }
    }
}
