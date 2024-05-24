namespace BankManage
{
    partial class FWaiting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FWaiting));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pbHi = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHi = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbHi)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_NEGATIVE;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pbHi
            // 
            this.pbHi.BackColor = System.Drawing.Color.Transparent;
            this.pbHi.Image = ((System.Drawing.Image)(resources.GetObject("pbHi.Image")));
            this.pbHi.ImageRotate = 0F;
            this.pbHi.Location = new System.Drawing.Point(0, 1);
            this.pbHi.Name = "pbHi";
            this.pbHi.Size = new System.Drawing.Size(900, 509);
            this.pbHi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHi.TabIndex = 0;
            this.pbHi.TabStop = false;
            this.pbHi.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // lblHi
            // 
            this.lblHi.BackColor = System.Drawing.Color.Transparent;
            this.lblHi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHi.Font = new System.Drawing.Font("UVN Lac Long Quan", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.Location = new System.Drawing.Point(0, 0);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(899, 508);
            this.lblHi.TabIndex = 2;
            this.lblHi.Text = "Cảm ơn bạn đã sử dụng app Ngân Hàng\r\nBạn vui lòng đợi trong giây lát\r\n";
            this.lblHi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 6000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FWaiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 508);
            this.Controls.Add(this.lblHi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FWaiting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HI";
            ((System.ComponentModel.ISupportInitialize)(this.pbHi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox pbHi;
        private System.Windows.Forms.Timer timer;
    }
}