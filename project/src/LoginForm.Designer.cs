namespace PassbookManagement.src
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.txt_email_login = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txt_password_login = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.btn_login_login = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btn_cancel_login = new MaterialSkin.Controls.MaterialRaisedButton();
			this.div1_login = new MaterialSkin.Controls.MaterialDivider();
			this.check_remember_me = new MaterialSkin.Controls.MaterialCheckBox();
			this.SuspendLayout();
			// 
			// txt_email_login
			// 
			this.txt_email_login.BackColor = System.Drawing.Color.White;
			this.txt_email_login.Depth = 0;
			this.txt_email_login.Hint = "Email";
			this.txt_email_login.Location = new System.Drawing.Point(50, 95);
			this.txt_email_login.MaxLength = 32767;
			this.txt_email_login.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_email_login.Name = "txt_email_login";
			this.txt_email_login.PasswordChar = '\0';
			this.txt_email_login.SelectedText = "";
			this.txt_email_login.SelectionLength = 0;
			this.txt_email_login.SelectionStart = 0;
			this.txt_email_login.Size = new System.Drawing.Size(250, 23);
			this.txt_email_login.TabIndex = 0;
			this.txt_email_login.TabStop = false;
			this.txt_email_login.UseSystemPasswordChar = false;
			this.txt_email_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_login_KeyDown);
			// 
			// txt_password_login
			// 
			this.txt_password_login.BackColor = System.Drawing.Color.White;
			this.txt_password_login.Depth = 0;
			this.txt_password_login.Hint = "Password";
			this.txt_password_login.Location = new System.Drawing.Point(50, 135);
			this.txt_password_login.MaxLength = 32767;
			this.txt_password_login.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_password_login.Name = "txt_password_login";
			this.txt_password_login.PasswordChar = '●';
			this.txt_password_login.SelectedText = "";
			this.txt_password_login.SelectionLength = 0;
			this.txt_password_login.SelectionStart = 0;
			this.txt_password_login.Size = new System.Drawing.Size(250, 23);
			this.txt_password_login.TabIndex = 1;
			this.txt_password_login.TabStop = false;
			this.txt_password_login.UseSystemPasswordChar = true;
			this.txt_password_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_login_KeyDown);
			// 
			// btn_login_login
			// 
			this.btn_login_login.Depth = 0;
			this.btn_login_login.Location = new System.Drawing.Point(83, 220);
			this.btn_login_login.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_login_login.Name = "btn_login_login";
			this.btn_login_login.Primary = true;
			this.btn_login_login.Size = new System.Drawing.Size(75, 40);
			this.btn_login_login.TabIndex = 3;
			this.btn_login_login.Text = "LOGIN";
			this.btn_login_login.UseVisualStyleBackColor = true;
			this.btn_login_login.Click += new System.EventHandler(this.btn_login_login_Click);
			// 
			// btn_cancel_login
			// 
			this.btn_cancel_login.Depth = 0;
			this.btn_cancel_login.Location = new System.Drawing.Point(181, 220);
			this.btn_cancel_login.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_cancel_login.Name = "btn_cancel_login";
			this.btn_cancel_login.Primary = true;
			this.btn_cancel_login.Size = new System.Drawing.Size(75, 40);
			this.btn_cancel_login.TabIndex = 4;
			this.btn_cancel_login.Text = "CANCEL";
			this.btn_cancel_login.UseVisualStyleBackColor = true;
			this.btn_cancel_login.Click += new System.EventHandler(this.btn_cancel_login_Click);
			// 
			// div1_login
			// 
			this.div1_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.div1_login.Depth = 0;
			this.div1_login.Location = new System.Drawing.Point(12, 207);
			this.div1_login.MouseState = MaterialSkin.MouseState.HOVER;
			this.div1_login.Name = "div1_login";
			this.div1_login.Size = new System.Drawing.Size(326, 1);
			this.div1_login.TabIndex = 5;
			this.div1_login.Text = "materialDivider1";
			// 
			// check_remember_me
			// 
			this.check_remember_me.AutoSize = true;
			this.check_remember_me.BackColor = System.Drawing.Color.Transparent;
			this.check_remember_me.Depth = 0;
			this.check_remember_me.Font = new System.Drawing.Font("Roboto", 10F);
			this.check_remember_me.Location = new System.Drawing.Point(180, 168);
			this.check_remember_me.Margin = new System.Windows.Forms.Padding(0);
			this.check_remember_me.MouseLocation = new System.Drawing.Point(-1, -1);
			this.check_remember_me.MouseState = MaterialSkin.MouseState.HOVER;
			this.check_remember_me.Name = "check_remember_me";
			this.check_remember_me.Ripple = true;
			this.check_remember_me.Size = new System.Drawing.Size(120, 30);
			this.check_remember_me.TabIndex = 2;
			this.check_remember_me.Text = "Remember me";
			this.check_remember_me.UseVisualStyleBackColor = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 275);
			this.Controls.Add(this.check_remember_me);
			this.Controls.Add(this.div1_login);
			this.Controls.Add(this.btn_cancel_login);
			this.Controls.Add(this.btn_login_login);
			this.Controls.Add(this.txt_password_login);
			this.Controls.Add(this.txt_email_login);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialSingleLineTextField txt_email_login;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_password_login;
		private MaterialSkin.Controls.MaterialRaisedButton btn_login_login;
		private MaterialSkin.Controls.MaterialRaisedButton btn_cancel_login;
		private MaterialSkin.Controls.MaterialDivider div1_login;
		private MaterialSkin.Controls.MaterialCheckBox check_remember_me;
	}
}