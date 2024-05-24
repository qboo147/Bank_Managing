namespace BankManage
{
    partial class FHistory
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
            this.gvHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChoice = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // gvHistory
            // 
            this.gvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHistory.Location = new System.Drawing.Point(12, 64);
            this.gvHistory.Name = "gvHistory";
            this.gvHistory.RowHeadersWidth = 51;
            this.gvHistory.RowTemplate.Height = 24;
            this.gvHistory.Size = new System.Drawing.Size(881, 330);
            this.gvHistory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn loại giao dịch:";
            // 
            // cmbChoice
            // 
            this.cmbChoice.AutoRoundedCorners = true;
            this.cmbChoice.BackColor = System.Drawing.Color.Transparent;
            this.cmbChoice.BorderRadius = 17;
            this.cmbChoice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbChoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbChoice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbChoice.ForeColor = System.Drawing.Color.Black;
            this.cmbChoice.ItemHeight = 30;
            this.cmbChoice.Items.AddRange(new object[] {
            "Rút tiền",
            "Gửi tiền",
            "Chuyển khoản",
            "Chuyển khoản qua tín dụng",
            "Nhận tiền chuyển khoản",
            "Tất cả giao dịch"});
            this.cmbChoice.Location = new System.Drawing.Point(381, 12);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(313, 36);
            this.cmbChoice.StartIndex = 5;
            this.cmbChoice.TabIndex = 3;
            this.cmbChoice.SelectedIndexChanged += new System.EventHandler(this.cmbChoice_SelectedIndexChanged);
            // 
            // FHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(905, 406);
            this.Controls.Add(this.cmbChoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvHistory);
            this.Name = "FHistory";
            this.Text = "FHistory";
            this.Load += new System.EventHandler(this.FHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvHistory;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbChoice;
    }
}