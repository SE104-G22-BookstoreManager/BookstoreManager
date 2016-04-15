using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace PassbookManagement
{
    public partial class DanhSachSoTietKiem : Form
    {
        SQLiteConnection conn = new SQLiteConnection();
        SQLiteDatabase m_database;
        public DanhSachSoTietKiem()
        {
            InitializeComponent();
            m_database = new SQLiteDatabase("../../data/CNPM.s3db");
            String sql = "select MaKH, MALoaiTietKiem, SoTienGui from SoTietKiem ";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
