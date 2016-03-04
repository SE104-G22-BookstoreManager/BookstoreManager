namespace PassbookManagement
{
    partial class MainForm
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
			this.btn_test = new LollipopButton();
			this.SuspendLayout();
			// 
			// btn_test
			// 
			this.btn_test.BackColor = System.Drawing.Color.Transparent;
			this.btn_test.BGColor = "#508ef5";
			this.btn_test.FontColor = "#ffffff";
			this.btn_test.Location = new System.Drawing.Point(199, 39);
			this.btn_test.Name = "btn_test";
			this.btn_test.Size = new System.Drawing.Size(143, 41);
			this.btn_test.TabIndex = 0;
			this.btn_test.Text = "Test Button";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(563, 436);
			this.Controls.Add(this.btn_test);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.ResumeLayout(false);

        }



		#endregion

		private LollipopButton btn_test;
	}
}

