namespace BankManage
{
    partial class FMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.pnlFind = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.gvSTK = new System.Windows.Forms.DataGridView();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlOption = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Animate_Win = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Borderless_Form = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnQuit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaving = new Guna.UI2.WinForms.Guna2Button();
            this.btnCredit = new Guna.UI2.WinForms.Guna2Button();
            this.btnBorrow = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrans = new Guna.UI2.WinForms.Guna2Button();
            this.btnInfo = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSTK)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFind
            // 
            this.pnlFind.AutoSize = true;
            this.pnlFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFind.Location = new System.Drawing.Point(286, 12);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(0, 0);
            this.pnlFind.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập CMND/CCCD:";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Location = new System.Drawing.Point(238, 265);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.gvSTK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 176);
            this.panel1.TabIndex = 14;
            // 
            // txtFilter
            // 
            this.txtFilter.Animated = true;
            this.txtFilter.AutoRoundedCorners = true;
            this.txtFilter.BorderRadius = 15;
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.DefaultText = "";
            this.txtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilter.ForeColor = System.Drawing.Color.Black;
            this.txtFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Location = new System.Drawing.Point(16, 52);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(434, 33);
            this.txtFilter.TabIndex = 0;
            // 
            // gvSTK
            // 
            this.gvSTK.BackgroundColor = System.Drawing.Color.Cyan;
            this.gvSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSTK.Location = new System.Drawing.Point(472, 13);
            this.gvSTK.Name = "gvSTK";
            this.gvSTK.RowHeadersWidth = 51;
            this.gvSTK.RowTemplate.Height = 24;
            this.gvSTK.Size = new System.Drawing.Size(451, 145);
            this.gvSTK.TabIndex = 13;
            this.gvSTK.Visible = false;
            this.gvSTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSTK_CellClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AnimatedGIF = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(265, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 43);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Animated = true;
            this.btnFilter.AnimatedGIF = true;
            this.btnFilter.AutoRoundedCorners = true;
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.BorderRadius = 20;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(74, 108);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(118, 43);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Tìm kiếm";
            this.btnFilter.UseTransparentBackground = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.pnlOption);
            this.panel2.Location = new System.Drawing.Point(276, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 478);
            this.panel2.TabIndex = 0;
            // 
            // pnlOption
            // 
            this.pnlOption.Location = new System.Drawing.Point(11, 17);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(923, 453);
            this.pnlOption.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(76, 101);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(130, 130);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // Animate_Win
            // 
            this.Animate_Win.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE;
            this.Animate_Win.TargetForm = this;
            // 
            // Borderless_Form
            // 
            this.Borderless_Form.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_NEGATIVE;
            this.Borderless_Form.BorderRadius = 2;
            this.Borderless_Form.ContainerControl = this;
            this.Borderless_Form.DockIndicatorTransparencyValue = 0.6D;
            this.Borderless_Form.ResizeForm = false;
            this.Borderless_Form.TransparentWhileDrag = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Animated = true;
            this.btnQuit.AnimatedGIF = true;
            this.btnQuit.AutoRoundedCorners = true;
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BorderRadius = 24;
            this.btnQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuit.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnQuit.Location = new System.Drawing.Point(49, 690);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(180, 50);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.panel1);
            this.guna2Panel2.FillColor = System.Drawing.Color.Cyan;
            this.guna2Panel2.Location = new System.Drawing.Point(276, -11);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(947, 202);
            this.guna2Panel2.TabIndex = 18;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.btnHistory);
            this.guna2GradientPanel1.Controls.Add(this.btnSaving);
            this.guna2GradientPanel1.Controls.Add(this.btnCredit);
            this.guna2GradientPanel1.Controls.Add(this.btnBorrow);
            this.guna2GradientPanel1.Controls.Add(this.btnTrans);
            this.guna2GradientPanel1.Controls.Add(this.btnInfo);
            this.guna2GradientPanel1.Controls.Add(this.btnQuit);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.SkyBlue;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, -89);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(280, 767);
            this.guna2GradientPanel1.TabIndex = 19;
            // 
            // btnHistory
            // 
            this.btnHistory.Animated = true;
            this.btnHistory.AutoRoundedCorners = true;
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BorderRadius = 24;
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.Enabled = false;
            this.btnHistory.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.ImageSize = new System.Drawing.Size(28, 28);
            this.btnHistory.Location = new System.Drawing.Point(20, 600);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(245, 50);
            this.btnHistory.TabIndex = 8;
            this.btnHistory.Text = "Xem lịch sử giao dịch";
            this.btnHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnSaving
            // 
            this.btnSaving.Animated = true;
            this.btnSaving.AutoRoundedCorners = true;
            this.btnSaving.BackColor = System.Drawing.Color.Transparent;
            this.btnSaving.BorderRadius = 24;
            this.btnSaving.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaving.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaving.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaving.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaving.Enabled = false;
            this.btnSaving.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnSaving.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnSaving.ForeColor = System.Drawing.Color.White;
            this.btnSaving.Image = ((System.Drawing.Image)(resources.GetObject("btnSaving.Image")));
            this.btnSaving.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaving.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaving.Location = new System.Drawing.Point(20, 530);
            this.btnSaving.Name = "btnSaving";
            this.btnSaving.Size = new System.Drawing.Size(245, 50);
            this.btnSaving.TabIndex = 7;
            this.btnSaving.Text = "Tài khoản tiết kiệm";
            this.btnSaving.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaving.Click += new System.EventHandler(this.btnSaving_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Animated = true;
            this.btnCredit.AutoRoundedCorners = true;
            this.btnCredit.BackColor = System.Drawing.Color.Transparent;
            this.btnCredit.BorderRadius = 24;
            this.btnCredit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCredit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCredit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCredit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCredit.Enabled = false;
            this.btnCredit.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnCredit.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCredit.ForeColor = System.Drawing.Color.White;
            this.btnCredit.Image = ((System.Drawing.Image)(resources.GetObject("btnCredit.Image")));
            this.btnCredit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCredit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCredit.Location = new System.Drawing.Point(20, 460);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(245, 50);
            this.btnCredit.TabIndex = 6;
            this.btnCredit.Text = "Tín dụng";
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Animated = true;
            this.btnBorrow.AutoRoundedCorners = true;
            this.btnBorrow.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrow.BorderRadius = 24;
            this.btnBorrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBorrow.Enabled = false;
            this.btnBorrow.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrow.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.Image")));
            this.btnBorrow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBorrow.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBorrow.Location = new System.Drawing.Point(20, 390);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(245, 50);
            this.btnBorrow.TabIndex = 5;
            this.btnBorrow.Text = "Vay";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnTrans
            // 
            this.btnTrans.Animated = true;
            this.btnTrans.AutoRoundedCorners = true;
            this.btnTrans.BackColor = System.Drawing.Color.Transparent;
            this.btnTrans.BorderRadius = 24;
            this.btnTrans.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrans.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrans.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrans.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrans.Enabled = false;
            this.btnTrans.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnTrans.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnTrans.ForeColor = System.Drawing.Color.White;
            this.btnTrans.Image = ((System.Drawing.Image)(resources.GetObject("btnTrans.Image")));
            this.btnTrans.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrans.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTrans.Location = new System.Drawing.Point(20, 320);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(245, 50);
            this.btnTrans.TabIndex = 4;
            this.btnTrans.Text = "Giao dịch";
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Animated = true;
            this.btnInfo.AutoRoundedCorners = true;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BorderRadius = 24;
            this.btnInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfo.Enabled = false;
            this.btnInfo.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInfo.Location = new System.Drawing.Point(20, 250);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(245, 50);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Thông tin khách hàng";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1222, 679);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFind);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ngân hàng";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSTK)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2AnimateWindow Animate_Win;
        private Guna.UI2.WinForms.Guna2BorderlessForm Borderless_Form;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.DataGridView gvSTK;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2Panel pnlOption;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnQuit;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button btnSaving;
        private Guna.UI2.WinForms.Guna2Button btnCredit;
        private Guna.UI2.WinForms.Guna2Button btnBorrow;
        private Guna.UI2.WinForms.Guna2Button btnTrans;
        private Guna.UI2.WinForms.Guna2Button btnInfo;
    }
}