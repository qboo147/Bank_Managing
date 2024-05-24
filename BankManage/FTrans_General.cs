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
    public partial class FTrans_General : Form
    {
        Customer customer = new Customer();
        DataTable dt = new DataTable();
        public FTrans_General(Customer choosedCustomer, DataTable dataTable)
        {
            InitializeComponent();
            customer = choosedCustomer;
            dt = dataTable;
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                FSend fSend = new FSend(customer);
                ShowFormOnPanel(fSend, tabSend);
            }
            else if (tabControl.SelectedIndex == 1)
            {
                FWithdraw fWithdraw = new FWithdraw(customer);
                ShowFormOnPanel(fWithdraw, tabWithdraw);
            }
            else
            {
                FTrans fTrans = new FTrans(customer, dt);
                ShowFormOnPanel(fTrans, tabTrans);
            }
        }

        private void ShowFormOnPanel(Form form, TabPage tab)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            tab.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void FTrans_General_Load(object sender, EventArgs e)
        {
            FSend fSend = new FSend(customer);
            ShowFormOnPanel(fSend, tabSend);
        }
    }
}
