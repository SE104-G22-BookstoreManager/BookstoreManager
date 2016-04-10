namespace PassbookManagement
{
    partial class PhieuGuiTien
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
            this.MA_PG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Gui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Tien_Gui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Tiengui = new System.Windows.Forms.TextBox();
            this.txt_Ngaygui = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaKH = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.bnt_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_PG,
            this.HoTen,
            this.Ngay_Gui,
            this.So_Tien_Gui});
            this.dataGridView1.Location = new System.Drawing.Point(3, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 208);
            this.dataGridView1.TabIndex = 4;
            // 
            // MA_PG
            // 
            this.MA_PG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MA_PG.HeaderText = "MA_PG";
            this.MA_PG.Name = "MA_PG";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.HeaderText = "Ho Ten";
            this.HoTen.Name = "HoTen";
            // 
            // Ngay_Gui
            // 
            this.Ngay_Gui.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngay_Gui.HeaderText = "Ngay Gui";
            this.Ngay_Gui.Name = "Ngay_Gui";
            // 
            // So_Tien_Gui
            // 
            this.So_Tien_Gui.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.So_Tien_Gui.HeaderText = "So  Tien Gui";
            this.So_Tien_Gui.Name = "So_Tien_Gui";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Tiengui);
            this.groupBox1.Controls.Add(this.txt_Ngaygui);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Hoten);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MaKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phieu Gui Tien";
            // 
            // txt_Tiengui
            // 
            this.txt_Tiengui.Location = new System.Drawing.Point(618, 42);
            this.txt_Tiengui.Name = "txt_Tiengui";
            this.txt_Tiengui.Size = new System.Drawing.Size(247, 26);
            this.txt_Tiengui.TabIndex = 7;
            // 
            // txt_Ngaygui
            // 
            this.txt_Ngaygui.Location = new System.Drawing.Point(618, 10);
            this.txt_Ngaygui.Name = "txt_Ngaygui";
            this.txt_Ngaygui.Size = new System.Drawing.Size(247, 26);
            this.txt_Ngaygui.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Tiền Gửi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngay Gui";
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(134, 59);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(247, 26);
            this.txt_Hoten.TabIndex = 3;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(134, 27);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(247, 26);
            this.txt_ma.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ho Ten";
            // 
            // MaKH
            // 
            this.MaKH.AutoSize = true;
            this.MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKH.Location = new System.Drawing.Point(12, 33);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(116, 20);
            this.MaKH.TabIndex = 0;
            this.MaKH.Text = "Ma Phieu Gui";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(510, 337);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(125, 48);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(375, 337);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 48);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // bnt_insert
            // 
            this.bnt_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_insert.Location = new System.Drawing.Point(218, 337);
            this.bnt_insert.Name = "bnt_insert";
            this.bnt_insert.Size = new System.Drawing.Size(125, 48);
            this.bnt_insert.TabIndex = 7;
            this.bnt_insert.Text = "INSERT ";
            this.bnt_insert.UseVisualStyleBackColor = true;
            // 
            // PhieuGuiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 388);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.bnt_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhieuGuiTien";
            this.Text = "PhieuGuiTien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_PG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Gui;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Tien_Gui;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Tiengui;
        private System.Windows.Forms.TextBox txt_Ngaygui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaKH;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button bnt_insert;
    }
}