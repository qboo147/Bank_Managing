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
    public partial class FMain : Form
    {
        DBConnection dBConnection = new DBConnection();
        Customer choosedCustomer = new Customer();
        public FMain()
        {
            InitializeComponent();
        }
        private void FMain_Load(object sender, EventArgs e)
        {
            LoadCustomerData("");
        }

        private void LoadCustomerData(string condition)
        {
            gvSTK.DataSource = dBConnection.Load("Customer", condition);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadCustomerData("");
            bool isShowGvCustomer = false;
            for (int i = 0; i < gvSTK.Rows.Count - 1; i++)
            {
                string CitizenId = gvSTK.Rows[i].Cells["CitizenId"].Value.ToString() ?? "";
                if (txtFilter.Text == CitizenId)
                {
                    LoadCustomerData($" WHERE CitizenId = '{txtFilter.Text}'");
                    isShowGvCustomer = true;
                    break;
                }
            }
            gvSTK.Visible = isShowGvCustomer;
            btnInfo.Enabled = isShowGvCustomer;
            btnHistory.Enabled = isShowGvCustomer;
            btnSaving.Enabled = isShowGvCustomer;
            btnBorrow.Enabled = isShowGvCustomer;
            btnCredit.Enabled = isShowGvCustomer;
            btnTrans.Enabled = isShowGvCustomer;
            if (!isShowGvCustomer)
            {
                MessageBox.Show("Invalid customer");
                choosedCustomer = new Customer("",txtFilter.Text);
                btnInfo_Click(sender, e);
            }
            else
                pnlOption.Controls.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFilter.Clear();
        }

        private void gvSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            string stk = gvSTK.Rows[numrow].Cells["STK"].Value.ToString();
            string name = gvSTK.Rows[numrow].Cells["Name"].Value.ToString();
            string address = gvSTK.Rows[numrow].Cells["Address"].Value.ToString();
            DateTime dob = DateTime.Parse(gvSTK.Rows[numrow].Cells["DoB"].Value.ToString());
            string id = gvSTK.Rows[numrow].Cells["CitizenId"].Value.ToString();
            string phoneNumber = gvSTK.Rows[numrow].Cells["PhoneNum"].Value.ToString();
            int money = Convert.ToInt32(gvSTK.Rows[numrow].Cells["Money"].Value.ToString());
            choosedCustomer = new Customer(stk, name, address, dob, id, phoneNumber, money);

            btnInfo_Click(sender, e);
        }

        private void ShowFormOnPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlOption.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            DataGrid dataGrid = new DataGrid
            {
                DataSource = dBConnection.Load("Customer")
            };
            DataTable datatable = (DataTable)dataGrid.DataSource;
            pnlOption.Controls.Clear();
            if (choosedCustomer != null)
            {
                FInformation fInformation = new FInformation(choosedCustomer, datatable);
                ShowFormOnPanel(fInformation);
            }
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            DataGrid dataGrid = new DataGrid
            {
                DataSource = dBConnection.Load("Customer")
            };
            DataTable datatable = (DataTable)dataGrid.DataSource;
            FTrans_General fTrans_General = new FTrans_General(choosedCustomer, datatable);
            ShowFormOnPanel(fTrans_General);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FBorrow fBorrow = new FBorrow(choosedCustomer);
            ShowFormOnPanel(fBorrow);
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FCredit fcredit = new FCredit(choosedCustomer);
            ShowFormOnPanel(fcredit);
        }

        private void btnSaving_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FSaving fSaving = new FSaving(choosedCustomer);
            ShowFormOnPanel(fSaving);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FHistory fHistory = new FHistory(choosedCustomer.Stk);
            ShowFormOnPanel(fHistory);
        }
    }
}