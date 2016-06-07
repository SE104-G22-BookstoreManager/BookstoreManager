﻿namespace PassbookManagement.src
{
	partial class EditCondition
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
			this.tab_control_edit = new MaterialSkin.Controls.MaterialTabControl();
			this.tab_cash_edit = new System.Windows.Forms.TabPage();
			this.btn_ok_edit_cash = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_apply_edit_cast = new MaterialSkin.Controls.MaterialRaisedButton();
			this.txt_min_edit_cash = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_add_min_edit_cash = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.tab_period_edit = new System.Windows.Forms.TabPage();
			this.lbl_id_edit_period = new MaterialSkin.Controls.MaterialLabel();
			this.txt_date_edit_period = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_name_edit_period = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_rate_edit_period = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.btn_edit_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_remove_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_add_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.txt_type_edit_period = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.cbb_type_edit_period = new System.Windows.Forms.ComboBox();
			this.btn_apply_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_ok_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.tab_selector_edit = new MaterialSkin.Controls.MaterialTabSelector();
			this.tab_control_edit.SuspendLayout();
			this.tab_cash_edit.SuspendLayout();
			this.tab_period_edit.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab_control_edit
			// 
			this.tab_control_edit.Controls.Add(this.tab_cash_edit);
			this.tab_control_edit.Controls.Add(this.tab_period_edit);
			this.tab_control_edit.Depth = 0;
			this.tab_control_edit.Location = new System.Drawing.Point(12, 114);
			this.tab_control_edit.MouseState = MaterialSkin.MouseState.HOVER;
			this.tab_control_edit.Name = "tab_control_edit";
			this.tab_control_edit.SelectedIndex = 0;
			this.tab_control_edit.Size = new System.Drawing.Size(576, 232);
			this.tab_control_edit.TabIndex = 0;
			// 
			// tab_cash_edit
			// 
			this.tab_cash_edit.BackColor = System.Drawing.Color.White;
			this.tab_cash_edit.Controls.Add(this.btn_ok_edit_cash);
			this.tab_cash_edit.Controls.Add(this.btn_apply_edit_cast);
			this.tab_cash_edit.Controls.Add(this.txt_min_edit_cash);
			this.tab_cash_edit.Controls.Add(this.txt_add_min_edit_cash);
			this.tab_cash_edit.Location = new System.Drawing.Point(4, 22);
			this.tab_cash_edit.Name = "tab_cash_edit";
			this.tab_cash_edit.Padding = new System.Windows.Forms.Padding(3);
			this.tab_cash_edit.Size = new System.Drawing.Size(568, 206);
			this.tab_cash_edit.TabIndex = 0;
			this.tab_cash_edit.Text = "Cash";
			// 
			// btn_ok_edit_cash
			// 
			this.btn_ok_edit_cash.Depth = 0;
			this.btn_ok_edit_cash.Location = new System.Drawing.Point(487, 160);
			this.btn_ok_edit_cash.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_ok_edit_cash.Name = "btn_ok_edit_cash";
			this.btn_ok_edit_cash.Primary = true;
			this.btn_ok_edit_cash.Size = new System.Drawing.Size(75, 40);
			this.btn_ok_edit_cash.TabIndex = 3;
			this.btn_ok_edit_cash.Text = "OK";
			this.btn_ok_edit_cash.UseVisualStyleBackColor = true;
			this.btn_ok_edit_cash.Click += new System.EventHandler(this.btn_ok_edit_cash_Click);
			// 
			// btn_apply_edit_cast
			// 
			this.btn_apply_edit_cast.Depth = 0;
			this.btn_apply_edit_cast.Location = new System.Drawing.Point(406, 160);
			this.btn_apply_edit_cast.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_apply_edit_cast.Name = "btn_apply_edit_cast";
			this.btn_apply_edit_cast.Primary = true;
			this.btn_apply_edit_cast.Size = new System.Drawing.Size(75, 40);
			this.btn_apply_edit_cast.TabIndex = 2;
			this.btn_apply_edit_cast.Text = "Apply";
			this.btn_apply_edit_cast.UseVisualStyleBackColor = true;
			this.btn_apply_edit_cast.Click += new System.EventHandler(this.btn_apply_edit_cast_Click);
			// 
			// txt_min_edit_cash
			// 
			this.txt_min_edit_cash.Depth = 0;
			this.txt_min_edit_cash.Hint = "Min cash";
			this.txt_min_edit_cash.Location = new System.Drawing.Point(31, 81);
			this.txt_min_edit_cash.MaxLength = 32767;
			this.txt_min_edit_cash.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_min_edit_cash.Name = "txt_min_edit_cash";
			this.txt_min_edit_cash.PasswordChar = '\0';
			this.txt_min_edit_cash.SelectedText = "";
			this.txt_min_edit_cash.SelectionLength = 0;
			this.txt_min_edit_cash.SelectionStart = 0;
			this.txt_min_edit_cash.Size = new System.Drawing.Size(250, 23);
			this.txt_min_edit_cash.TabIndex = 1;
			this.txt_min_edit_cash.TabStop = false;
			this.txt_min_edit_cash.UseSystemPasswordChar = false;
			// 
			// txt_add_min_edit_cash
			// 
			this.txt_add_min_edit_cash.Depth = 0;
			this.txt_add_min_edit_cash.Hint = "Min addition cash";
			this.txt_add_min_edit_cash.Location = new System.Drawing.Point(31, 31);
			this.txt_add_min_edit_cash.MaxLength = 32767;
			this.txt_add_min_edit_cash.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_add_min_edit_cash.Name = "txt_add_min_edit_cash";
			this.txt_add_min_edit_cash.PasswordChar = '\0';
			this.txt_add_min_edit_cash.SelectedText = "";
			this.txt_add_min_edit_cash.SelectionLength = 0;
			this.txt_add_min_edit_cash.SelectionStart = 0;
			this.txt_add_min_edit_cash.Size = new System.Drawing.Size(250, 23);
			this.txt_add_min_edit_cash.TabIndex = 0;
			this.txt_add_min_edit_cash.TabStop = false;
			this.txt_add_min_edit_cash.UseSystemPasswordChar = false;
			// 
			// tab_period_edit
			// 
			this.tab_period_edit.BackColor = System.Drawing.Color.White;
			this.tab_period_edit.Controls.Add(this.lbl_id_edit_period);
			this.tab_period_edit.Controls.Add(this.txt_date_edit_period);
			this.tab_period_edit.Controls.Add(this.txt_name_edit_period);
			this.tab_period_edit.Controls.Add(this.txt_rate_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_edit_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_remove_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_add_edit_period);
			this.tab_period_edit.Controls.Add(this.txt_type_edit_period);
			this.tab_period_edit.Controls.Add(this.cbb_type_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_apply_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_ok_edit_period);
			this.tab_period_edit.Location = new System.Drawing.Point(4, 22);
			this.tab_period_edit.Name = "tab_period_edit";
			this.tab_period_edit.Padding = new System.Windows.Forms.Padding(3);
			this.tab_period_edit.Size = new System.Drawing.Size(568, 206);
			this.tab_period_edit.TabIndex = 2;
			this.tab_period_edit.Text = "Period";
			// 
			// lbl_id_edit_period
			// 
			this.lbl_id_edit_period.AutoSize = true;
			this.lbl_id_edit_period.Depth = 0;
			this.lbl_id_edit_period.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_id_edit_period.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_id_edit_period.Location = new System.Drawing.Point(146, 81);
			this.lbl_id_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_id_edit_period.Name = "lbl_id_edit_period";
			this.lbl_id_edit_period.Size = new System.Drawing.Size(23, 19);
			this.lbl_id_edit_period.TabIndex = 14;
			this.lbl_id_edit_period.Text = "ID";
			// 
			// txt_date_edit_period
			// 
			this.txt_date_edit_period.Depth = 0;
			this.txt_date_edit_period.Hint = "Dates_withdrawal";
			this.txt_date_edit_period.Location = new System.Drawing.Point(150, 139);
			this.txt_date_edit_period.MaxLength = 32767;
			this.txt_date_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_date_edit_period.Name = "txt_date_edit_period";
			this.txt_date_edit_period.PasswordChar = '\0';
			this.txt_date_edit_period.SelectedText = "";
			this.txt_date_edit_period.SelectionLength = 0;
			this.txt_date_edit_period.SelectionStart = 0;
			this.txt_date_edit_period.Size = new System.Drawing.Size(200, 23);
			this.txt_date_edit_period.TabIndex = 10;
			this.txt_date_edit_period.TabStop = false;
			this.txt_date_edit_period.UseSystemPasswordChar = false;
			// 
			// txt_name_edit_period
			// 
			this.txt_name_edit_period.Depth = 0;
			this.txt_name_edit_period.Hint = "Name";
			this.txt_name_edit_period.Location = new System.Drawing.Point(186, 81);
			this.txt_name_edit_period.MaxLength = 32767;
			this.txt_name_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_name_edit_period.Name = "txt_name_edit_period";
			this.txt_name_edit_period.PasswordChar = '\0';
			this.txt_name_edit_period.SelectedText = "";
			this.txt_name_edit_period.SelectionLength = 0;
			this.txt_name_edit_period.SelectionStart = 0;
			this.txt_name_edit_period.Size = new System.Drawing.Size(164, 23);
			this.txt_name_edit_period.TabIndex = 9;
			this.txt_name_edit_period.TabStop = false;
			this.txt_name_edit_period.UseSystemPasswordChar = false;
			// 
			// txt_rate_edit_period
			// 
			this.txt_rate_edit_period.Depth = 0;
			this.txt_rate_edit_period.Hint = "Rate";
			this.txt_rate_edit_period.Location = new System.Drawing.Point(150, 110);
			this.txt_rate_edit_period.MaxLength = 32767;
			this.txt_rate_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_rate_edit_period.Name = "txt_rate_edit_period";
			this.txt_rate_edit_period.PasswordChar = '\0';
			this.txt_rate_edit_period.SelectedText = "";
			this.txt_rate_edit_period.SelectionLength = 0;
			this.txt_rate_edit_period.SelectionStart = 0;
			this.txt_rate_edit_period.Size = new System.Drawing.Size(200, 23);
			this.txt_rate_edit_period.TabIndex = 8;
			this.txt_rate_edit_period.TabStop = false;
			this.txt_rate_edit_period.UseSystemPasswordChar = false;
			// 
			// btn_edit_edit_period
			// 
			this.btn_edit_edit_period.Depth = 0;
			this.btn_edit_edit_period.Location = new System.Drawing.Point(25, 56);
			this.btn_edit_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_edit_edit_period.Name = "btn_edit_edit_period";
			this.btn_edit_edit_period.Primary = true;
			this.btn_edit_edit_period.Size = new System.Drawing.Size(75, 23);
			this.btn_edit_edit_period.TabIndex = 7;
			this.btn_edit_edit_period.Text = "Edit";
			this.btn_edit_edit_period.UseVisualStyleBackColor = true;
			this.btn_edit_edit_period.Click += new System.EventHandler(this.btn_edit_edit_period_Click);
			// 
			// btn_remove_edit_period
			// 
			this.btn_remove_edit_period.Depth = 0;
			this.btn_remove_edit_period.Location = new System.Drawing.Point(25, 85);
			this.btn_remove_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_remove_edit_period.Name = "btn_remove_edit_period";
			this.btn_remove_edit_period.Primary = true;
			this.btn_remove_edit_period.Size = new System.Drawing.Size(75, 23);
			this.btn_remove_edit_period.TabIndex = 6;
			this.btn_remove_edit_period.Text = "Remove";
			this.btn_remove_edit_period.UseVisualStyleBackColor = true;
			this.btn_remove_edit_period.Click += new System.EventHandler(this.btn_remove_edit_period_Click);
			// 
			// btn_add_edit_period
			// 
			this.btn_add_edit_period.Depth = 0;
			this.btn_add_edit_period.Location = new System.Drawing.Point(25, 25);
			this.btn_add_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_add_edit_period.Name = "btn_add_edit_period";
			this.btn_add_edit_period.Primary = true;
			this.btn_add_edit_period.Size = new System.Drawing.Size(75, 25);
			this.btn_add_edit_period.TabIndex = 5;
			this.btn_add_edit_period.Text = "Add";
			this.btn_add_edit_period.UseVisualStyleBackColor = true;
			this.btn_add_edit_period.Click += new System.EventHandler(this.btn_add_edit_period_Click);
			// 
			// txt_type_edit_period
			// 
			this.txt_type_edit_period.Depth = 0;
			this.txt_type_edit_period.Hint = "Type";
			this.txt_type_edit_period.Location = new System.Drawing.Point(150, 52);
			this.txt_type_edit_period.MaxLength = 32767;
			this.txt_type_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_type_edit_period.Name = "txt_type_edit_period";
			this.txt_type_edit_period.PasswordChar = '\0';
			this.txt_type_edit_period.SelectedText = "";
			this.txt_type_edit_period.SelectionLength = 0;
			this.txt_type_edit_period.SelectionStart = 0;
			this.txt_type_edit_period.Size = new System.Drawing.Size(200, 23);
			this.txt_type_edit_period.TabIndex = 4;
			this.txt_type_edit_period.TabStop = false;
			this.txt_type_edit_period.UseSystemPasswordChar = false;
			// 
			// cbb_type_edit_period
			// 
			this.cbb_type_edit_period.FormattingEnabled = true;
			this.cbb_type_edit_period.Location = new System.Drawing.Point(150, 25);
			this.cbb_type_edit_period.Name = "cbb_type_edit_period";
			this.cbb_type_edit_period.Size = new System.Drawing.Size(200, 21);
			this.cbb_type_edit_period.TabIndex = 2;
			this.cbb_type_edit_period.SelectedIndexChanged += new System.EventHandler(this.cbb_type_edit_period_SelectedIndexChanged);
			// 
			// btn_apply_edit_period
			// 
			this.btn_apply_edit_period.Depth = 0;
			this.btn_apply_edit_period.Location = new System.Drawing.Point(406, 160);
			this.btn_apply_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_apply_edit_period.Name = "btn_apply_edit_period";
			this.btn_apply_edit_period.Primary = true;
			this.btn_apply_edit_period.Size = new System.Drawing.Size(75, 40);
			this.btn_apply_edit_period.TabIndex = 1;
			this.btn_apply_edit_period.Text = "Apply";
			this.btn_apply_edit_period.UseVisualStyleBackColor = true;
			this.btn_apply_edit_period.Click += new System.EventHandler(this.btn_apply_edit_type_Click);
			// 
			// btn_ok_edit_period
			// 
			this.btn_ok_edit_period.Depth = 0;
			this.btn_ok_edit_period.Location = new System.Drawing.Point(487, 160);
			this.btn_ok_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_ok_edit_period.Name = "btn_ok_edit_period";
			this.btn_ok_edit_period.Primary = true;
			this.btn_ok_edit_period.Size = new System.Drawing.Size(75, 40);
			this.btn_ok_edit_period.TabIndex = 0;
			this.btn_ok_edit_period.Text = "OK";
			this.btn_ok_edit_period.UseVisualStyleBackColor = true;
			this.btn_ok_edit_period.Click += new System.EventHandler(this.btn_ok_edit_type_Click);
			// 
			// tab_selector_edit
			// 
			this.tab_selector_edit.BaseTabControl = this.tab_control_edit;
			this.tab_selector_edit.Depth = 0;
			this.tab_selector_edit.Location = new System.Drawing.Point(0, 64);
			this.tab_selector_edit.MouseState = MaterialSkin.MouseState.HOVER;
			this.tab_selector_edit.Name = "tab_selector_edit";
			this.tab_selector_edit.Size = new System.Drawing.Size(1500, 45);
			this.tab_selector_edit.TabIndex = 1;
			this.tab_selector_edit.Text = "TabSelector";
			// 
			// EditCondition
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 350);
			this.Controls.Add(this.tab_selector_edit);
			this.Controls.Add(this.tab_control_edit);
			this.Name = "EditCondition";
			this.Text = "EditCondition";
			this.tab_control_edit.ResumeLayout(false);
			this.tab_cash_edit.ResumeLayout(false);
			this.tab_period_edit.ResumeLayout(false);
			this.tab_period_edit.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MaterialSkin.Controls.MaterialTabControl tab_control_edit;
		private System.Windows.Forms.TabPage tab_cash_edit;
		private MaterialSkin.Controls.MaterialTabSelector tab_selector_edit;
		private System.Windows.Forms.TabPage tab_period_edit;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_min_edit_cash;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_add_min_edit_cash;
		private MaterialSkin.Controls.MaterialRaisedButton btn_ok_edit_cash;
		private MaterialSkin.Controls.MaterialRaisedButton btn_apply_edit_cast;
		private MaterialSkin.Controls.MaterialRaisedButton btn_apply_edit_period;
		private MaterialSkin.Controls.MaterialRaisedButton btn_ok_edit_period;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_type_edit_period;
		private System.Windows.Forms.ComboBox cbb_type_edit_period;
		private MaterialSkin.Controls.MaterialRaisedButton btn_edit_edit_period;
		private MaterialSkin.Controls.MaterialRaisedButton btn_remove_edit_period;
		private MaterialSkin.Controls.MaterialRaisedButton btn_add_edit_period;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_rate_edit_period;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_date_edit_period;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_name_edit_period;
		private MaterialSkin.Controls.MaterialLabel lbl_id_edit_period;
	}
}