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
    public partial class BaoCaoDoanhThuHangNgay : Form
    {

        public BaoCaoDoanhThuHangNgay()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            connect_database a = new connect_database();
            a.Connect();
            string ngay = txt_Ngay.Text;


            String sql1 = "select SoTienGui from PhieuGuiTien where NgayGui=\"" + txt_Ngay.Text + "\" ";

            DataTable _queryResult1 = a.m_database.GetDataTable(sql1);

            double tongthu = 0;
            double tongchi = 0;
            if (_queryResult1.Rows.Count == 0)
            {
                tongthu = 0;
            }
            else
            {

                for (int i = 0; i < _queryResult1.Rows.Count; i++)
                {

                    object[] _itemArray = _queryResult1.Rows[i].ItemArray;
                    string tongthu_a = _itemArray[0].ToString();
                    tongthu = tongthu + Convert.ToDouble(tongthu_a);

                }
            }
            String sql2 = "select SoTienRut from PhieuRutTien where NgayRut=\"" + txt_Ngay.Text + "\" ";
            DataTable _queryResult2 = a.m_database.GetDataTable(sql2);
            if (_queryResult2.Rows.Count == 0)
            {
                tongchi = 0;
            }
            else
            {

                for (int i = 0; i < _queryResult2.Rows.Count; i++)
                {

                    object[] _itemArray = _queryResult2.Rows[i].ItemArray;
                    string tongchi_a = _itemArray[0].ToString();
                    tongchi = tongchi + Convert.ToDouble(tongchi_a);

                }
            }
            double tong = tongthu - tongchi;

            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[1].Value = tongthu.ToString();
            dataGridView1.Rows[n].Cells[0].Value = ngay;
            dataGridView1.Rows[n].Cells[2].Value = tongchi.ToString();
            dataGridView1.Rows[n].Cells[3].Value = tong.ToString();
        }
    }
}
