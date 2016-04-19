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
       
        public DanhSachSoTietKiem()
        {
            InitializeComponent();
            connect_database a = new connect_database();
            a.Connect();
            String sql = "select MaKH, MALoaiTietKiem, SoTienGui,HoTenKH from SoTietKiem ";
            DataTable _queryResult = a.m_database.GetDataTable(sql);

            if (_queryResult.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm phù hợp!!!");
                return;
            }
            else
            {
                
                for (int i = 0; i < _queryResult.Rows.Count; i++)
                {

                    object[] _itemArray = _queryResult.Rows[i].ItemArray;
                    int n = dataGridView1.Rows.Add();
               
                    dataGridView1.Rows[n].Cells[1].Value = _itemArray[0].ToString();
                    dataGridView1.Rows[n].Cells[0].Value = _itemArray[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = _itemArray[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = _itemArray[3].ToString();

                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
