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
            string loai = txt_LoaiTietKiem.Text;
            connect_database a = new connect_database();
            a.Connect();
            string money = "0";
            string sql1 = "select Type, DateOpen from SoTietKiem";
            DataTable _queryResult1 = a.m_database.GetDataTable(sql1);
            for (int i = 0; i < _queryResult1.Rows.Count; i++)
            {

                object[] _itemArray = _queryResult1.Rows[i].ItemArray;
                string type = _itemArray[0].ToString();
                string Ngay = _itemArray[1].ToString();
                DateTime ngay1 = DateTime.Now; // phải convert từ ngày ra Ngay chứ không phải Now

                if (Convert_Month(ngay1) == Convert.ToInt16(txt_Thang.Text) && type == loai)
                {
                    int somo = 0;
                    int sodong = 0;
                    for (int k = 0; k < _queryResult1.Rows.Count; k++)
                    {
                        object[] _itemArray4 = _queryResult1.Rows[k].ItemArray;
                        string type_1 = _itemArray4[0].ToString();
                        string ngay_temp = _itemArray4[1].ToString();
                        if (ngay_temp == Ngay && type_1 == loai)
                        {
                            somo = somo + 1;
                        }

                    }
                    string sql2 = "select NgayRut, TienConLai, MaSoTietKiem  from PhieuRutTien";
                    DataTable _queryResult2 = a.m_database.GetDataTable(sql2);

                    for (int j = 0; j < _queryResult2.Rows.Count; j++)
                    {
                        object[] _itemArray1 = _queryResult2.Rows[i].ItemArray;
                        string Ngayrut = _itemArray1[0].ToString();
                        DateTime ngay2 = DateTime.Now;// chuyển ngày rút dang datetime
                        string tienconlai = _itemArray1[1].ToString();
                        string maso = _itemArray1[2].ToString();
                        string sql3 = "select Type from SoTietKiem where id=\"" + maso + "\" ";
                        DataTable _queryResult3 = a.m_database.GetDataTable(sql1);
                        object[] _itemArray3 = _queryResult3.Rows[0].ItemArray;
                        string loai_rut = _itemArray3[0].ToString();
                        if (loai_rut == loai && Convert_Month(ngay2) == Convert.ToInt16(txt_Thang.Text) && tienconlai == "0")
                            sodong = sodong + 1;

                    }


                    dataGridView1.ColumnCount = 4;


                    string[] row = new string[] { Ngay,somo.ToString(),sodong.ToString(),(somo-sodong).ToString() };
                    dataGridView1.Rows.Add(row);
                    

                }
            }
        }
        public int Convert_Month(DateTime ngay)
        {

            return 2;
        }
    }
}
