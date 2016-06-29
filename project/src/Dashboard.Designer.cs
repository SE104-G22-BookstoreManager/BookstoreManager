namespace PassbookManagement.src
{
	partial class Dashboard
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
			this.txt_period_edit_period = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_name_edit_period = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_rate_edit_period = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.btn_edit_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_remove_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_add_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.cbb_period_edit_period = new System.Windows.Forms.ComboBox();
			this.btn_apply_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_ok_edit_period = new MaterialSkin.Controls.MaterialRaisedButton();
			this.tab_manage_staffs = new System.Windows.Forms.TabPage();
			this.tab_selector_edit = new MaterialSkin.Controls.MaterialTabSelector();
			this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
			this.col_order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_phone_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tab_control_edit.SuspendLayout();
			this.tab_cash_edit.SuspendLayout();
			this.tab_period_edit.SuspendLayout();
			this.tab_manage_staffs.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab_control_edit
			// 
			this.tab_control_edit.Controls.Add(this.tab_cash_edit);
			this.tab_control_edit.Controls.Add(this.tab_period_edit);
			this.tab_control_edit.Controls.Add(this.tab_manage_staffs);
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
			this.txt_min_edit_cash.Hint = "Min cash (VND)";
			this.txt_min_edit_cash.Location = new System.Drawing.Point(31, 27);
			this.txt_min_edit_cash.MaxLength = 32767;
			this.txt_min_edit_cash.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_min_edit_cash.Name = "txt_min_edit_cash";
			this.txt_min_edit_cash.PasswordChar = '\0';
			this.txt_min_edit_cash.SelectedText = "";
			this.txt_min_edit_cash.SelectionLength = 0;
			this.txt_min_edit_cash.SelectionStart = 0;
			this.txt_min_edit_cash.Size = new System.Drawing.Size(250, 23);
			this.txt_min_edit_cash.TabIndex = 0;
			this.txt_min_edit_cash.TabStop = false;
			this.txt_min_edit_cash.UseSystemPasswordChar = false;
			// 
			// txt_add_min_edit_cash
			// 
			this.txt_add_min_edit_cash.Depth = 0;
			this.txt_add_min_edit_cash.Hint = "Min income (VND)";
			this.txt_add_min_edit_cash.Location = new System.Drawing.Point(31, 67);
			this.txt_add_min_edit_cash.MaxLength = 32767;
			this.txt_add_min_edit_cash.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_add_min_edit_cash.Name = "txt_add_min_edit_cash";
			this.txt_add_min_edit_cash.PasswordChar = '\0';
			this.txt_add_min_edit_cash.SelectedText = "";
			this.txt_add_min_edit_cash.SelectionLength = 0;
			this.txt_add_min_edit_cash.SelectionStart = 0;
			this.txt_add_min_edit_cash.Size = new System.Drawing.Size(250, 23);
			this.txt_add_min_edit_cash.TabIndex = 1;
			this.txt_add_min_edit_cash.TabStop = false;
			this.txt_add_min_edit_cash.UseSystemPasswordChar = false;
			// 
			// tab_period_edit
			// 
			this.tab_period_edit.BackColor = System.Drawing.Color.White;
			this.tab_period_edit.Controls.Add(this.lbl_id_edit_period);
			this.tab_period_edit.Controls.Add(this.txt_period_edit_period);
			this.tab_period_edit.Controls.Add(this.txt_name_edit_period);
			this.tab_period_edit.Controls.Add(this.txt_rate_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_edit_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_remove_edit_period);
			this.tab_period_edit.Controls.Add(this.btn_add_edit_period);
			this.tab_period_edit.Controls.Add(this.cbb_period_edit_period);
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
			this.lbl_id_edit_period.Location = new System.Drawing.Point(146, 53);
			this.lbl_id_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_id_edit_period.Name = "lbl_id_edit_period";
			this.lbl_id_edit_period.Size = new System.Drawing.Size(23, 19);
			this.lbl_id_edit_period.TabIndex = 4;
			this.lbl_id_edit_period.Text = "ID";
			// 
			// txt_period_edit_period
			// 
			this.txt_period_edit_period.Depth = 0;
			this.txt_period_edit_period.Hint = "Period (days)";
			this.txt_period_edit_period.Location = new System.Drawing.Point(150, 111);
			this.txt_period_edit_period.MaxLength = 32767;
			this.txt_period_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_period_edit_period.Name = "txt_period_edit_period";
			this.txt_period_edit_period.PasswordChar = '\0';
			this.txt_period_edit_period.SelectedText = "";
			this.txt_period_edit_period.SelectionLength = 0;
			this.txt_period_edit_period.SelectionStart = 0;
			this.txt_period_edit_period.Size = new System.Drawing.Size(200, 23);
			this.txt_period_edit_period.TabIndex = 7;
			this.txt_period_edit_period.TabStop = false;
			this.txt_period_edit_period.UseSystemPasswordChar = false;
			// 
			// txt_name_edit_period
			// 
			this.txt_name_edit_period.Depth = 0;
			this.txt_name_edit_period.Hint = "Name";
			this.txt_name_edit_period.Location = new System.Drawing.Point(175, 53);
			this.txt_name_edit_period.MaxLength = 32767;
			this.txt_name_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_name_edit_period.Name = "txt_name_edit_period";
			this.txt_name_edit_period.PasswordChar = '\0';
			this.txt_name_edit_period.SelectedText = "";
			this.txt_name_edit_period.SelectionLength = 0;
			this.txt_name_edit_period.SelectionStart = 0;
			this.txt_name_edit_period.Size = new System.Drawing.Size(175, 23);
			this.txt_name_edit_period.TabIndex = 5;
			this.txt_name_edit_period.TabStop = false;
			this.txt_name_edit_period.UseSystemPasswordChar = false;
			// 
			// txt_rate_edit_period
			// 
			this.txt_rate_edit_period.Depth = 0;
			this.txt_rate_edit_period.Hint = "Rate (%)";
			this.txt_rate_edit_period.Location = new System.Drawing.Point(150, 82);
			this.txt_rate_edit_period.MaxLength = 32767;
			this.txt_rate_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_rate_edit_period.Name = "txt_rate_edit_period";
			this.txt_rate_edit_period.PasswordChar = '\0';
			this.txt_rate_edit_period.SelectedText = "";
			this.txt_rate_edit_period.SelectionLength = 0;
			this.txt_rate_edit_period.SelectionStart = 0;
			this.txt_rate_edit_period.Size = new System.Drawing.Size(200, 23);
			this.txt_rate_edit_period.TabIndex = 6;
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
			this.btn_edit_edit_period.TabIndex = 1;
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
			this.btn_remove_edit_period.TabIndex = 2;
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
			this.btn_add_edit_period.TabIndex = 0;
			this.btn_add_edit_period.Text = "Add";
			this.btn_add_edit_period.UseVisualStyleBackColor = true;
			this.btn_add_edit_period.Click += new System.EventHandler(this.btn_add_edit_period_Click);
			// 
			// cbb_period_edit_period
			// 
			this.cbb_period_edit_period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_period_edit_period.FormattingEnabled = true;
			this.cbb_period_edit_period.Location = new System.Drawing.Point(150, 25);
			this.cbb_period_edit_period.Name = "cbb_period_edit_period";
			this.cbb_period_edit_period.Size = new System.Drawing.Size(200, 21);
			this.cbb_period_edit_period.TabIndex = 3;
			this.cbb_period_edit_period.SelectedIndexChanged += new System.EventHandler(this.cbb_period_edit_period_SelectedIndexChanged);
			// 
			// btn_apply_edit_period
			// 
			this.btn_apply_edit_period.Depth = 0;
			this.btn_apply_edit_period.Location = new System.Drawing.Point(406, 160);
			this.btn_apply_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_apply_edit_period.Name = "btn_apply_edit_period";
			this.btn_apply_edit_period.Primary = true;
			this.btn_apply_edit_period.Size = new System.Drawing.Size(75, 40);
			this.btn_apply_edit_period.TabIndex = 8;
			this.btn_apply_edit_period.Text = "Apply";
			this.btn_apply_edit_period.UseVisualStyleBackColor = true;
			this.btn_apply_edit_period.Click += new System.EventHandler(this.btn_apply_edit_period_Click);
			// 
			// btn_ok_edit_period
			// 
			this.btn_ok_edit_period.Depth = 0;
			this.btn_ok_edit_period.Location = new System.Drawing.Point(487, 160);
			this.btn_ok_edit_period.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_ok_edit_period.Name = "btn_ok_edit_period";
			this.btn_ok_edit_period.Primary = true;
			this.btn_ok_edit_period.Size = new System.Drawing.Size(75, 40);
			this.btn_ok_edit_period.TabIndex = 9;
			this.btn_ok_edit_period.Text = "OK";
			this.btn_ok_edit_period.UseVisualStyleBackColor = true;
			this.btn_ok_edit_period.Click += new System.EventHandler(this.btn_ok_edit_type_Click);
			// 
			// tab_manage_staffs
			// 
			this.tab_manage_staffs.Controls.Add(this.materialListView1);
			this.tab_manage_staffs.Location = new System.Drawing.Point(4, 22);
			this.tab_manage_staffs.Name = "tab_manage_staffs";
			this.tab_manage_staffs.Padding = new System.Windows.Forms.Padding(3);
			this.tab_manage_staffs.Size = new System.Drawing.Size(568, 206);
			this.tab_manage_staffs.TabIndex = 3;
			this.tab_manage_staffs.Text = "Staffs";
			this.tab_manage_staffs.UseVisualStyleBackColor = true;
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
			// materialListView1
			// 
			this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_order,
            this.col_name,
            this.col_email,
            this.col_phone_number});
			this.materialListView1.Depth = 0;
			this.materialListView1.Font = new System.Drawing.Font("Roboto", 18F);
			this.materialListView1.FullRowSelect = true;
			this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.materialListView1.Location = new System.Drawing.Point(0, 0);
			this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
			this.materialListView1.Name = "materialListView1";
			this.materialListView1.OwnerDraw = true;
			this.materialListView1.Size = new System.Drawing.Size(572, 206);
			this.materialListView1.TabIndex = 0;
			this.materialListView1.UseCompatibleStateImageBehavior = false;
			this.materialListView1.View = System.Windows.Forms.View.Details;
			// 
			// col_order
			// 
			this.col_order.Text = "Order";
			this.col_order.Width = 80;
			// 
			// col_name
			// 
			this.col_name.Text = "Name";
			this.col_name.Width = 134;
			// 
			// col_email
			// 
			this.col_email.Text = "Email";
			this.col_email.Width = 134;
			// 
			// col_phone_number
			// 
			this.col_phone_number.Text = "Phone Number";
			this.col_phone_number.Width = 226;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 350);
			this.Controls.Add(this.tab_selector_edit);
			this.Controls.Add(this.tab_control_edit);
			this.MaximizeBox = false;
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.tab_control_edit.ResumeLayout(false);
			this.tab_cash_edit.ResumeLayout(false);
			this.tab_period_edit.ResumeLayout(false);
			this.tab_period_edit.PerformLayout();
			this.tab_manage_staffs.ResumeLayout(false);
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
		private System.Windows.Forms.ComboBox cbb_period_edit_period;
		private MaterialSkin.Controls.MaterialRaisedButton btn_edit_edit_period;
		private MaterialSkin.Controls.MaterialRaisedButton btn_remove_edit_period;
		private MaterialSkin.Controls.MaterialRaisedButton btn_add_edit_period;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_rate_edit_period;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_period_edit_period;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_name_edit_period;
		private MaterialSkin.Controls.MaterialLabel lbl_id_edit_period;
		private System.Windows.Forms.TabPage tab_manage_staffs;
		private MaterialSkin.Controls.MaterialListView materialListView1;
		private System.Windows.Forms.ColumnHeader col_order;
		private System.Windows.Forms.ColumnHeader col_name;
		private System.Windows.Forms.ColumnHeader col_email;
		private System.Windows.Forms.ColumnHeader col_phone_number;
	}
}