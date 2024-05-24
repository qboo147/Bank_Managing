namespace BankManage
{
    partial class FWithdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FWithdraw));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoneyRemain = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoneySend = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpWithdraw = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số dư hiện tại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền muốn rút:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày rút tiền:";
            // 
            // txtMoneyRemain
            // 
            this.txtMoneyRemain.Animated = true;
            this.txtMoneyRemain.AutoRoundedCorners = true;
            this.txtMoneyRemain.BorderRadius = 17;
            this.txtMoneyRemain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoneyRemain.DefaultText = "";
            this.txtMoneyRemain.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoneyRemain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoneyRemain.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtMoneyRemain.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoneyRemain.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoneyRemain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoneyRemain.ForeColor = System.Drawing.Color.Black;
            this.txtMoneyRemain.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoneyRemain.Location = new System.Drawing.Point(385, 74);
            this.txtMoneyRemain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoneyRemain.Name = "txtMoneyRemain";
            this.txtMoneyRemain.PasswordChar = '\0';
            this.txtMoneyRemain.PlaceholderText = "";
            this.txtMoneyRemain.ReadOnly = true;
            this.txtMoneyRemain.SelectedText = "";
            this.txtMoneyRemain.Size = new System.Drawing.Size(230, 36);
            this.txtMoneyRemain.TabIndex = 10;
            // 
            // txtMoneySend
            // 
            this.txtMoneySend.Animated = true;
            this.txtMoneySend.AutoRoundedCorners = true;
            this.txtMoneySend.BorderRadius = 17;
            this.txtMoneySend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoneySend.DefaultText = "";
            this.txtMoneySend.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoneySend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoneySend.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtMoneySend.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoneySend.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoneySend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoneySend.ForeColor = System.Drawing.Color.Black;
            this.txtMoneySend.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoneySend.Location = new System.Drawing.Point(385, 134);
            this.txtMoneySend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoneySend.Name = "txtMoneySend";
            this.txtMoneySend.PasswordChar = '\0';
            this.txtMoneySend.PlaceholderText = "";
            this.txtMoneySend.SelectedText = "";
            this.txtMoneySend.Size = new System.Drawing.Size(230, 36);
            this.txtMoneySend.TabIndex = 11;
            // 
            // dtpWithdraw
            // 
            this.dtpWithdraw.Animated = true;
            this.dtpWithdraw.AutoRoundedCorners = true;
            this.dtpWithdraw.BorderRadius = 17;
            this.dtpWithdraw.Checked = true;
            this.dtpWithdraw.Enabled = false;
            this.dtpWithdraw.FillColor = System.Drawing.Color.LightSkyBlue;
            this.dtpWithdraw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpWithdraw.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWithdraw.Location = new System.Drawing.Point(385, 194);
            this.dtpWithdraw.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpWithdraw.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpWithdraw.Name = "dtpWithdraw";
            this.dtpWithdraw.Size = new System.Drawing.Size(230, 36);
            this.dtpWithdraw.TabIndex = 12;
            this.dtpWithdraw.Value = new System.DateTime(2023, 5, 15, 15, 41, 24, 632);
            // 
            // btnOK
            // 
            this.btnOK.Animated = true;
            this.btnOK.AutoRoundedCorners = true;
            this.btnOK.BorderRadius = 26;
            this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(312, 264);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 55);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 26;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(476, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 55);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(917, 402);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtpWithdraw);
            this.Controls.Add(this.txtMoneySend);
            this.Controls.Add(this.txtMoneyRemain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FWithdraw";
            this.Text = "FWithdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMoneyRemain;
        private Guna.UI2.WinForms.Guna2TextBox txtMoneySend;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpWithdraw;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}