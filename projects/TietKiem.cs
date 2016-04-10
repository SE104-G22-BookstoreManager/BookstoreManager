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
    public partial class TietKiem : Form
    {
        public TietKiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value =
            dataGridView1.Rows[n].Cells[1].Value = txt_hoten.Text;
            dataGridView1.Rows[n].Cells[2].Value = txt_cmnd.Text;
            dataGridView1.Rows[n].Cells[3].Value = txt_diachi.Text;
            dataGridView1.Rows[n].Cells[4].Value = txt_tiengui.Text;
            dataGridView1.Rows[n].Cells[5].Value = txt_ngaygui.Text;
            if (txt_tk0.Checked == true)
            {
                dataGridView1.Rows[n].Cells[6].Value = "Khong ki han";
                txt_tk0.Checked = false;
            }
            else
            {
                if (txt_tk3.Checked == true)
                {
                    dataGridView1.Rows[n].Cells[6].Value = " 3 thang";
                    txt_tk3.Checked = false;
                }
                else
                {
                    dataGridView1.Rows[n].Cells[6].Value = "6 thang";
                    txt_tk6.Checked = false;

                }
            }

            txt_MKH.Text = "";
            txt_hoten.Text = "";
            txt_cmnd.Text = "";
            txt_diachi.Text = "";
            txt_tiengui.Text = "";
            txt_ngaygui.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            } 
        }
    }
}
