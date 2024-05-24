
namespace BankManage
{
    partial class FCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCredit));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gvHistory = new System.Windows.Forms.DataGridView();
            this.txtSothe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoneyUsed = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbHanMuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpOpen = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowTrans = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ngày mở thẻ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Số thẻ: ";
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 39);
            this.label7.TabIndex = 64;
            this.label7.Text = "Hồ sơ chứng minh năng lực tài chính: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Hạn mức thẻ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Số tiền đã dùng:";
            // 
            // gvHistory
            // 
            this.gvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHistory.Location = new System.Drawing.Point(331, 194);
            this.gvHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvHistory.Name = "gvHistory";
            this.gvHistory.RowHeadersWidth = 51;
            this.gvHistory.RowTemplate.Height = 24;
            this.gvHistory.Size = new System.Drawing.Size(539, 187);
            this.gvHistory.TabIndex = 77;
            this.gvHistory.Visible = false;
            // 
            // txtSothe
            // 
            this.txtSothe.Animated = true;
            this.txtSothe.AutoRoundedCorners = true;
            this.txtSothe.BorderRadius = 17;
            this.txtSothe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSothe.DefaultText = "";
            this.txtSothe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSothe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSothe.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSothe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSothe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSothe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSothe.ForeColor = System.Drawing.Color.Black;
            this.txtSothe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSothe.Location = new System.Drawing.Point(167, 13);
            this.txtSothe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSothe.Name = "txtSothe";
            this.txtSothe.PasswordChar = '\0';
            this.txtSothe.PlaceholderText = "";
            this.txtSothe.ReadOnly = true;
            this.txtSothe.SelectedText = "";
            this.txtSothe.Size = new System.Drawing.Size(233, 36);
            this.txtSothe.TabIndex = 79;
            // 
            // txtMoneyUsed
            // 
            this.txtMoneyUsed.Animated = true;
            this.txtMoneyUsed.AutoRoundedCorners = true;
            this.txtMoneyUsed.BorderRadius = 17;
            this.txtMoneyUsed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoneyUsed.DefaultText = "";
            this.txtMoneyUsed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoneyUsed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoneyUsed.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtMoneyUsed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoneyUsed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoneyUsed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoneyUsed.ForeColor = System.Drawing.Color.Black;
            this.txtMoneyUsed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoneyUsed.Location = new System.Drawing.Point(167, 65);
            this.txtMoneyUsed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoneyUsed.Name = "txtMoneyUsed";
            this.txtMoneyUsed.PasswordChar = '\0';
            this.txtMoneyUsed.PlaceholderText = "";
            this.txtMoneyUsed.ReadOnly = true;
            this.txtMoneyUsed.SelectedText = "";
            this.txtMoneyUsed.Size = new System.Drawing.Size(233, 36);
            this.txtMoneyUsed.TabIndex = 80;
            // 
            // cmbHanMuc
            // 
            this.cmbHanMuc.AutoRoundedCorners = true;
            this.cmbHanMuc.BackColor = System.Drawing.Color.Transparent;
            this.cmbHanMuc.BorderRadius = 17;
            this.cmbHanMuc.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.cmbHanMuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHanMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHanMuc.Enabled = false;
            this.cmbHanMuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbHanMuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbHanMuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHanMuc.ForeColor = System.Drawing.Color.Black;
            this.cmbHanMuc.ItemHeight = 30;
            this.cmbHanMuc.Items.AddRange(new object[] {
            "5 triệu",
            "10 triệu",
            "20 triệu"});
            this.cmbHanMuc.Location = new System.Drawing.Point(167, 120);
            this.cmbHanMuc.Name = "cmbHanMuc";
            this.cmbHanMuc.Size = new System.Drawing.Size(233, 36);
            this.cmbHanMuc.TabIndex = 81;
            // 
            // dtpOpen
            // 
            this.dtpOpen.Animated = true;
            this.dtpOpen.AutoRoundedCorners = true;
            this.dtpOpen.BorderRadius = 17;
            this.dtpOpen.Checked = true;
            this.dtpOpen.Enabled = false;
            this.dtpOpen.FillColor = System.Drawing.Color.LightSkyBlue;
            this.dtpOpen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpOpen.ForeColor = System.Drawing.Color.Black;
            this.dtpOpen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOpen.Location = new System.Drawing.Point(637, 65);
            this.dtpOpen.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpOpen.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpOpen.Name = "dtpOpen";
            this.dtpOpen.Size = new System.Drawing.Size(233, 36);
            this.dtpOpen.TabIndex = 82;
            this.dtpOpen.Value = new System.DateTime(2023, 5, 15, 14, 56, 42, 956);
            // 
            // cmbMethod
            // 
            this.cmbMethod.AutoRoundedCorners = true;
            this.cmbMethod.BackColor = System.Drawing.Color.Transparent;
            this.cmbMethod.BorderRadius = 17;
            this.cmbMethod.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.cmbMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.Enabled = false;
            this.cmbMethod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMethod.ForeColor = System.Drawing.Color.Black;
            this.cmbMethod.ItemHeight = 30;
            this.cmbMethod.Items.AddRange(new object[] {
            "Sao kê bảng lương",
            "Hợp đồng lao động",
            "Hợp đồng thuê tài sản"});
            this.cmbMethod.Location = new System.Drawing.Point(636, 120);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(234, 36);
            this.cmbMethod.TabIndex = 83;
            this.cmbMethod.SelectedIndexChanged += new System.EventHandler(this.cmbMethod_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Animated = true;
            this.btnSubmit.AutoRoundedCorners = true;
            this.btnSubmit.BorderRadius = 21;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSubmit.Location = new System.Drawing.Point(16, 194);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 45);
            this.btnSubmit.TabIndex = 84;
            this.btnSubmit.Text = "Mở thẻ";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderRadius = 21;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(167, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 45);
            this.btnDelete.TabIndex = 85;
            this.btnDelete.Text = "Xóa thẻ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 21;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCancel.Location = new System.Drawing.Point(167, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 45);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.Animated = true;
            this.btnPay.AutoRoundedCorners = true;
            this.btnPay.BorderRadius = 21;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPay.Location = new System.Drawing.Point(16, 264);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(120, 45);
            this.btnPay.TabIndex = 87;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnShowTrans
            // 
            this.btnShowTrans.Animated = true;
            this.btnShowTrans.AutoRoundedCorners = true;
            this.btnShowTrans.BorderRadius = 21;
            this.btnShowTrans.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowTrans.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowTrans.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowTrans.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowTrans.Enabled = false;
            this.btnShowTrans.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowTrans.ForeColor = System.Drawing.Color.White;
            this.btnShowTrans.Image = ((System.Drawing.Image)(resources.GetObject("btnShowTrans.Image")));
            this.btnShowTrans.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShowTrans.Location = new System.Drawing.Point(16, 336);
            this.btnShowTrans.Name = "btnShowTrans";
            this.btnShowTrans.Size = new System.Drawing.Size(271, 45);
            this.btnShowTrans.TabIndex = 88;
            this.btnShowTrans.Text = "Thống kê thẻ tín dụng";
            this.btnShowTrans.Click += new System.EventHandler(this.btnShowTrans_Click);
            // 
            // FCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(905, 406);
            this.Controls.Add(this.btnShowTrans);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.dtpOpen);
            this.Controls.Add(this.cmbHanMuc);
            this.Controls.Add(this.txtMoneyUsed);
            this.Controls.Add(this.txtSothe);
            this.Controls.Add(this.gvHistory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FCredit";
            this.Text = "FCredit";
            this.Load += new System.EventHandler(this.FCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvHistory;
        private Guna.UI2.WinForms.Guna2TextBox txtSothe;
        private Guna.UI2.WinForms.Guna2TextBox txtMoneyUsed;
        private Guna.UI2.WinForms.Guna2ComboBox cmbHanMuc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpOpen;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMethod;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnShowTrans;
    }
}