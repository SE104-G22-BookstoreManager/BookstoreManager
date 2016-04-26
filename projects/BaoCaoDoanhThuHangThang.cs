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
    public partial class BaoCaoDoanhThuHangThang : Form
    {
        public BaoCaoDoanhThuHangThang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string thang = txt_Thang.Text;
            string loai = txt_Thang.Text;
            connect_database a = new connect_database();
            a.Connect();
            string money = "0";
            string sql1 = "select Type, DateOpen from SoTietKiem";
            String sql = "select Type,DateOpen from SoTietKiem where Money_send=\"" + money + "\" ";

            string LoaiTietKiem;
            DataTable _queryResult1 = a.m_database.GetDataTable(sql1);
            for (int i = 0; i < _queryResult1.Rows.Count; i++)
            {

                object[] _itemArray = _queryResult1.Rows[i].ItemArray;
                string type = _itemArray[0].ToString();
                string Ngay = _itemArray[1].ToString();
                 DateTime ngay1 = DateTime.Now; // phải convert từ ngày ra 
                if ( type == loai && Convert_Month(ngay1)== Convert.ToInt16(thang))
                {

                    
                }


     
            }
        }
        public int Convert_Month(DateTime ngay)
        {

            return 2;
        }
    }
}
