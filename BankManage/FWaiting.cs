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
    public partial class FWaiting : Form
    {
        public FWaiting()
        {
            InitializeComponent();
            lblHi.Parent = pbHi;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Hide();
            FMain fmain = new FMain();
            fmain.ShowDialog();
            Close();
        }
    }
}
