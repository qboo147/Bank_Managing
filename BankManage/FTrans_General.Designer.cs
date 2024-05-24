namespace BankManage
{
    partial class FTrans_General
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.tabWithdraw = new System.Windows.Forms.TabPage();
            this.tabTrans = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSend);
            this.tabControl.Controls.Add(this.tabWithdraw);
            this.tabControl.Controls.Add(this.tabTrans);
            this.tabControl.Location = new System.Drawing.Point(-5, -1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(935, 472);
            this.tabControl.TabIndex = 0;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // tabSend
            // 
            this.tabSend.BackColor = System.Drawing.Color.LightBlue;
            this.tabSend.Location = new System.Drawing.Point(4, 25);
            this.tabSend.Margin = new System.Windows.Forms.Padding(0);
            this.tabSend.Name = "tabSend";
            this.tabSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabSend.Size = new System.Drawing.Size(927, 443);
            this.tabSend.TabIndex = 0;
            this.tabSend.Text = "Gửi tiền";
            // 
            // tabWithdraw
            // 
            this.tabWithdraw.BackColor = System.Drawing.Color.LightBlue;
            this.tabWithdraw.Location = new System.Drawing.Point(4, 25);
            this.tabWithdraw.Name = "tabWithdraw";
            this.tabWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tabWithdraw.Size = new System.Drawing.Size(789, 410);
            this.tabWithdraw.TabIndex = 1;
            this.tabWithdraw.Text = "Rút tiền";
            // 
            // tabTrans
            // 
            this.tabTrans.BackColor = System.Drawing.Color.LightBlue;
            this.tabTrans.Location = new System.Drawing.Point(4, 25);
            this.tabTrans.Name = "tabTrans";
            this.tabTrans.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrans.Size = new System.Drawing.Size(789, 410);
            this.tabTrans.TabIndex = 2;
            this.tabTrans.Text = "Chuyển khoản";
            // 
            // FTrans_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(922, 431);
            this.Controls.Add(this.tabControl);
            this.Name = "FTrans_General";
            this.Text = "FTrans_General";
            this.Load += new System.EventHandler(this.FTrans_General_Load);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSend;
        private System.Windows.Forms.TabPage tabWithdraw;
        private System.Windows.Forms.TabPage tabTrans;
    }
}