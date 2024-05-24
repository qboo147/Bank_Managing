namespace BankManage
{
    partial class FTrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTrans));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMoneyRemain = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoneySend = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCheck = new Guna.UI2.WinForms.Guna2Button();
            this.dtpSend = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ngày gửi tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số tiền muốn gửi:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(24, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 18);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Số dư hiện tại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "STK người nhận:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(527, 143);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(0, 16);
            this.lblNote.TabIndex = 36;
            this.lblNote.Visible = false;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Phương thức thanh toán:";
            // 
            // cmbMethod
            // 
            this.cmbMethod.AutoRoundedCorners = true;
            this.cmbMethod.BackColor = System.Drawing.Color.Transparent;
            this.cmbMethod.BorderRadius = 17;
            this.cmbMethod.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.cmbMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMethod.ForeColor = System.Drawing.Color.Black;
            this.cmbMethod.ItemHeight = 30;
            this.cmbMethod.Items.AddRange(new object[] {
            "Tài khoản chính",
            "Thẻ tín dụng"});
            this.cmbMethod.Location = new System.Drawing.Point(406, 25);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(230, 36);
            this.cmbMethod.StartIndex = 0;
            this.cmbMethod.TabIndex = 39;
            this.cmbMethod.SelectedIndexChanged += new System.EventHandler(this.cmbMethod_SelectedIndexChanged);
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
            this.txtMoneyRemain.Location = new System.Drawing.Point(156, 95);
            this.txtMoneyRemain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoneyRemain.Name = "txtMoneyRemain";
            this.txtMoneyRemain.PasswordChar = '\0';
            this.txtMoneyRemain.PlaceholderText = "";
            this.txtMoneyRemain.ReadOnly = true;
            this.txtMoneyRemain.SelectedText = "";
            this.txtMoneyRemain.Size = new System.Drawing.Size(230, 36);
            this.txtMoneyRemain.TabIndex = 40;
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
            this.txtMoneySend.Enabled = false;
            this.txtMoneySend.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoneySend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoneySend.ForeColor = System.Drawing.Color.Black;
            this.txtMoneySend.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoneySend.Location = new System.Drawing.Point(156, 175);
            this.txtMoneySend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoneySend.Name = "txtMoneySend";
            this.txtMoneySend.PasswordChar = '\0';
            this.txtMoneySend.PlaceholderText = "";
            this.txtMoneySend.SelectedText = "";
            this.txtMoneySend.Size = new System.Drawing.Size(230, 36);
            this.txtMoneySend.TabIndex = 41;
            // 
            // txtSTK
            // 
            this.txtSTK.Animated = true;
            this.txtSTK.AutoRoundedCorners = true;
            this.txtSTK.BorderRadius = 17;
            this.txtSTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSTK.DefaultText = "";
            this.txtSTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSTK.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSTK.Enabled = false;
            this.txtSTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSTK.ForeColor = System.Drawing.Color.Black;
            this.txtSTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSTK.Location = new System.Drawing.Point(527, 95);
            this.txtSTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.PasswordChar = '\0';
            this.txtSTK.PlaceholderText = "";
            this.txtSTK.SelectedText = "";
            this.txtSTK.Size = new System.Drawing.Size(230, 36);
            this.txtSTK.TabIndex = 42;
            // 
            // btnCheck
            // 
            this.btnCheck.Animated = true;
            this.btnCheck.AutoRoundedCorners = true;
            this.btnCheck.BorderRadius = 17;
            this.btnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.ImageSize = new System.Drawing.Size(22, 22);
            this.btnCheck.Location = new System.Drawing.Point(781, 95);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(124, 36);
            this.btnCheck.TabIndex = 43;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dtpSend
            // 
            this.dtpSend.Animated = true;
            this.dtpSend.AutoRoundedCorners = true;
            this.dtpSend.BorderRadius = 17;
            this.dtpSend.Checked = true;
            this.dtpSend.FillColor = System.Drawing.Color.LightSkyBlue;
            this.dtpSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSend.Location = new System.Drawing.Point(527, 173);
            this.dtpSend.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSend.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSend.Name = "dtpSend";
            this.dtpSend.Size = new System.Drawing.Size(230, 36);
            this.dtpSend.TabIndex = 44;
            this.dtpSend.Value = new System.DateTime(2023, 5, 15, 15, 33, 55, 888);
            // 
            // txtNote
            // 
            this.txtNote.Animated = true;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.DefaultText = "";
            this.txtNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNote.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNote.ForeColor = System.Drawing.Color.Black;
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.Location = new System.Drawing.Point(156, 255);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderText = "";
            this.txtNote.SelectedText = "";
            this.txtNote.Size = new System.Drawing.Size(601, 47);
            this.txtNote.TabIndex = 45;
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
            this.btnOK.Enabled = false;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(291, 335);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 55);
            this.btnOK.TabIndex = 46;
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
            this.btnCancel.Location = new System.Drawing.Point(527, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 55);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(917, 402);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dtpSend);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtSTK);
            this.Controls.Add(this.txtMoneySend);
            this.Controls.Add(this.txtMoneyRemain);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Name = "FTrans";
            this.Text = "FTrans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMethod;
        private Guna.UI2.WinForms.Guna2TextBox txtMoneyRemain;
        private Guna.UI2.WinForms.Guna2TextBox txtMoneySend;
        private Guna.UI2.WinForms.Guna2TextBox txtSTK;
        private Guna.UI2.WinForms.Guna2Button btnCheck;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSend;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}