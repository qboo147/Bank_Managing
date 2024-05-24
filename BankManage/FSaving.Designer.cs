namespace BankManage
{
    partial class FSaving
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSaving));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gvSaving = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSavingNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoneySend = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbTerm = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpSend = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheck = new Guna.UI2.WinForms.Guna2Button();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.cbMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaving)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số tiền gửi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kỳ hạn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phương thức đáo hạn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày gửi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày đáo hạn:";
            // 
            // gvSaving
            // 
            this.gvSaving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSaving.Location = new System.Drawing.Point(414, 243);
            this.gvSaving.Name = "gvSaving";
            this.gvSaving.RowHeadersWidth = 51;
            this.gvSaving.RowTemplate.Height = 24;
            this.gvSaving.Size = new System.Drawing.Size(479, 140);
            this.gvSaving.TabIndex = 15;
            this.gvSaving.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSaving_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Khách hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Số tiền khả dụng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sổ tiết kiệm số: ";
            // 
            // txtSavingNumber
            // 
            this.txtSavingNumber.Animated = true;
            this.txtSavingNumber.AutoRoundedCorners = true;
            this.txtSavingNumber.BorderRadius = 17;
            this.txtSavingNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSavingNumber.DefaultText = "";
            this.txtSavingNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSavingNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSavingNumber.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSavingNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSavingNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSavingNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSavingNumber.ForeColor = System.Drawing.Color.Black;
            this.txtSavingNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSavingNumber.Location = new System.Drawing.Point(176, 6);
            this.txtSavingNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSavingNumber.Name = "txtSavingNumber";
            this.txtSavingNumber.PasswordChar = '\0';
            this.txtSavingNumber.PlaceholderText = "";
            this.txtSavingNumber.ReadOnly = true;
            this.txtSavingNumber.SelectedText = "";
            this.txtSavingNumber.Size = new System.Drawing.Size(218, 36);
            this.txtSavingNumber.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.AutoRoundedCorners = true;
            this.txtName.BorderRadius = 17;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(175, 66);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(218, 36);
            this.txtName.TabIndex = 24;
            // 
            // txtMoney
            // 
            this.txtMoney.Animated = true;
            this.txtMoney.AutoRoundedCorners = true;
            this.txtMoney.BorderRadius = 17;
            this.txtMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoney.DefaultText = "";
            this.txtMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoney.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoney.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoney.ForeColor = System.Drawing.Color.Black;
            this.txtMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoney.Location = new System.Drawing.Point(175, 126);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.PasswordChar = '\0';
            this.txtMoney.PlaceholderText = "";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.SelectedText = "";
            this.txtMoney.Size = new System.Drawing.Size(218, 36);
            this.txtMoney.TabIndex = 25;
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
            this.txtMoneySend.Location = new System.Drawing.Point(175, 186);
            this.txtMoneySend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoneySend.Name = "txtMoneySend";
            this.txtMoneySend.PasswordChar = '\0';
            this.txtMoneySend.PlaceholderText = "";
            this.txtMoneySend.SelectedText = "";
            this.txtMoneySend.Size = new System.Drawing.Size(218, 36);
            this.txtMoneySend.TabIndex = 26;
            // 
            // cbTerm
            // 
            this.cbTerm.AutoRoundedCorners = true;
            this.cbTerm.BackColor = System.Drawing.Color.Transparent;
            this.cbTerm.BorderRadius = 17;
            this.cbTerm.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.cbTerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerm.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTerm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTerm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTerm.ForeColor = System.Drawing.Color.Black;
            this.cbTerm.ItemHeight = 30;
            this.cbTerm.Items.AddRange(new object[] {
            "12 thang voi lai suat 8%/ nam",
            "36 thang voi lai suat 12%/ nam"});
            this.cbTerm.Location = new System.Drawing.Point(620, 6);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(218, 36);
            this.cbTerm.TabIndex = 27;
            this.cbTerm.SelectedIndexChanged += new System.EventHandler(this.cbTerm_SelectedIndexChanged);
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
            this.dtpSend.Location = new System.Drawing.Point(620, 126);
            this.dtpSend.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSend.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSend.Name = "dtpSend";
            this.dtpSend.Size = new System.Drawing.Size(218, 36);
            this.dtpSend.TabIndex = 29;
            this.dtpSend.Value = new System.DateTime(2023, 5, 15, 15, 17, 35, 876);
            this.dtpSend.ValueChanged += new System.EventHandler(this.dtpSend_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Animated = true;
            this.dtpEnd.AutoRoundedCorners = true;
            this.dtpEnd.BorderRadius = 17;
            this.dtpEnd.Checked = true;
            this.dtpEnd.Enabled = false;
            this.dtpEnd.FillColor = System.Drawing.Color.LightSkyBlue;
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(621, 186);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(218, 36);
            this.dtpEnd.TabIndex = 30;
            this.dtpEnd.Value = new System.DateTime(2023, 5, 15, 15, 17, 35, 876);
            // 
            // btnCreate
            // 
            this.btnCreate.Animated = true;
            this.btnCreate.AutoRoundedCorners = true;
            this.btnCreate.BorderRadius = 24;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageSize = new System.Drawing.Size(23, 23);
            this.btnCreate.Location = new System.Drawing.Point(220, 243);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 50);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Animated = true;
            this.btnCheck.AutoRoundedCorners = true;
            this.btnCheck.BorderRadius = 24;
            this.btnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheck.Enabled = false;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.ImageSize = new System.Drawing.Size(23, 23);
            this.btnCheck.Location = new System.Drawing.Point(16, 244);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(120, 50);
            this.btnCheck.TabIndex = 32;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Animated = true;
            this.btnWithdraw.AutoRoundedCorners = true;
            this.btnWithdraw.BorderRadius = 24;
            this.btnWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWithdraw.Enabled = false;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Image = ((System.Drawing.Image)(resources.GetObject("btnWithdraw.Image")));
            this.btnWithdraw.ImageSize = new System.Drawing.Size(23, 23);
            this.btnWithdraw.Location = new System.Drawing.Point(16, 333);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(120, 50);
            this.btnWithdraw.TabIndex = 33;
            this.btnWithdraw.Text = "Tất toán";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AnimatedGIF = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 24;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageSize = new System.Drawing.Size(23, 23);
            this.btnCancel.Location = new System.Drawing.Point(220, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbMethod
            // 
            this.cbMethod.AutoRoundedCorners = true;
            this.cbMethod.BackColor = System.Drawing.Color.Transparent;
            this.cbMethod.BorderRadius = 17;
            this.cbMethod.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.cbMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMethod.ForeColor = System.Drawing.Color.Black;
            this.cbMethod.ItemHeight = 30;
            this.cbMethod.Items.AddRange(new object[] {
            "Nhan ca tien lai va goc( tu dong so) ",
            "Nhan tien lai vao tai khoan, chuyen tien goc sang ky han moi",
            "Toan bo tien goc và tien lai sang ky han moi"});
            this.cbMethod.Location = new System.Drawing.Point(621, 66);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(218, 36);
            this.cbMethod.TabIndex = 35;
            // 
            // FSaving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(905, 396);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpSend);
            this.Controls.Add(this.cbTerm);
            this.Controls.Add(this.txtMoneySend);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSavingNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvSaving);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FSaving";
            this.Text = "FSaving";
            this.Load += new System.EventHandler(this.FSaving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSaving)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gvSaving;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtSavingNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtMoney;
        private Guna.UI2.WinForms.Guna2TextBox txtMoneySend;
        private Guna.UI2.WinForms.Guna2ComboBox cbTerm;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSend;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnCheck;
        private Guna.UI2.WinForms.Guna2Button btnWithdraw;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2ComboBox cbMethod;
    }
}