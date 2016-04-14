using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassbookManagement
{
    public partial class MainForm : Form
    {
		public MainForm()
        {
            InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Mai" && txt_user.Text == "Mai")
            {
                SoTietKiem a = new SoTietKiem();
                a.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("BAN da nhap sai ");
                txt_pass.Text = "";
                txt_user.Text = "";


            }
        }
    }
}
