namespace PassbookManagement
{
    partial class BaoCaoDoanhThuHangNgay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong_thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chenhlech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngay,
            this.Tong_thu,
            this.tong_chi,
            this.chenhlech});
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 432);
            this.dataGridView1.TabIndex = 1;
            // 
            // ngay
            // 
            this.ngay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngay.HeaderText = "Ngay";
            this.ngay.Name = "ngay";
            // 
            // Tong_thu
            // 
            this.Tong_thu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tong_thu.HeaderText = "Tong Thu";
            this.Tong_thu.Name = "Tong_thu";
            // 
            // tong_chi
            // 
            this.tong_chi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tong_chi.HeaderText = "Tong Chi";
            this.tong_chi.Name = "tong_chi";
            // 
            // chenhlech
            // 
            this.chenhlech.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chenhlech.HeaderText = "Chenh Lech";
            this.chenhlech.Name = "chenhlech";
            // 
            // BaoCaoDoanhThuHangNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 433);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BaoCaoDoanhThuHangNgay";
            this.Text = "BaoCaoDoanhThuHangNgay";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong_thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn chenhlech;
    }
}