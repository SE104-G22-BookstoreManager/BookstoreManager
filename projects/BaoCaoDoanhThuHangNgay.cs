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
            double tienthu1 = 0;
            double tienthu2 = 0;
            double tienthu3 = 0;
            double tienchi1 = 0;
            double tienchi2 = 0;
            double tienchi3 = 0;

            String sql1 = "select SoTienGui, MaSoTietKiem from PhieuGuiTien where NgayGui=\"" + txt_Ngay.Text + "\" ";
         

            DataTable _queryResult1 = a.m_database.GetDataTable(sql1);
           
            
                for (int i = 0; i < _queryResult1.Rows.Count; i++)
                {

                    object[] _itemArray = _queryResult1.Rows[i].ItemArray;
                    string tien = _itemArray[0].ToString();
                    string MaSoTietKiem = _itemArray[1].ToString();
                    String sql_temp = "select Type from SoTietKiem where id=\"" + MaSoTietKiem + "\" ";
                    DataTable _queryResult_temp = a.m_database.GetDataTable(sql_temp);
                    object[] _itemArray1 = _queryResult_temp.Rows[0].ItemArray;
                    string loai = _itemArray1[0].ToString();
                    if (loai =="0")
                    {
                        tienthu1 = tienthu1 + Convert.ToDouble(tien.ToString());
                    }
                    if (loai=="3")
                    {
                        tienthu2 = tienthu2 + Convert.ToDouble(tien.ToString());

                    }
                    if(loai=="6")
                    {
                        tienthu3 = tienthu3 + Convert.ToDouble(tien.ToString());
                    }
                    

                }

              String sql2 = "select SoTienRut, MaSoTietKiem from PhieuRutTien where NgayRut=\"" + txt_Ngay.Text + "\" ";
            DataTable _queryResult2 = a.m_database.GetDataTable(sql2);

            for (int i = 0; i < _queryResult2.Rows.Count; i++)
            {

                object[] _itemArray = _queryResult2.Rows[i].ItemArray;
                string tien = _itemArray[0].ToString();
                string MaSoTietKiem = _itemArray[1].ToString();
                String sql_temp = "select Type from SoTietKiem where id=\"" + MaSoTietKiem + "\" ";
                DataTable _queryResult_temp = a.m_database.GetDataTable(sql_temp);
                object[] _itemArray1 = _queryResult_temp.Rows[0].ItemArray;
                string loai = _itemArray1[0].ToString();
                if (loai == "0")
                {
                   tienchi1 =tienchi1+ Convert.ToDouble(tien.ToString());
                }
                if (loai == "3")
                {
                    tienchi2 =tienchi2 + Convert.ToDouble(tien.ToString());

                }
                if (loai == "6")
                {
                   tienchi3 =tienchi3 + Convert.ToDouble(tien.ToString());
                }


            }
            String sql3 = "select Type, Money_send from SoTietKiem where DateOpen=\"" + txt_Ngay.Text + "\" ";
            DataTable _queryResult3 = a.m_database.GetDataTable(sql3);
            double tien1 = 0;
            double tien2 = 0;
            double tien3 = 0;
            for (int i = 0; i < _queryResult3.Rows.Count; i++)
            {

                object[] _itemArray = _queryResult3.Rows[i].ItemArray;
                string tien = _itemArray[1].ToString();
                string maloai = _itemArray[0].ToString();
            
                if (maloai == "0")
                {
                    tien1=tien1 + Convert.ToDouble(tien.ToString());
                }
                if (maloai == "3")
                {
                    tien2=tien2 + Convert.ToDouble(tien.ToString());

                }
                if (maloai == "6")
                {
                    tien3=tien3 + Convert.ToDouble(tien.ToString());
                }


            }
           double  chenhlech1 = tien1 + tienthu1 - tienchi1;
            double chenhlech2 = tien2 + tienthu2 - tienchi2;
            double chenhlech3 = tien3 + tienthu3 - tienchi3;



            dataGridView1.ColumnCount = 5;
           

            string[] row = new string[] { txt_Ngay.Text, (tienthu1+tien1).ToString(), tienchi1.ToString(),chenhlech1.ToString(),"Khong Ki Han" };
            dataGridView1.Rows.Add(row);
            row = new string[] { txt_Ngay.Text, (tienthu2 + tien2).ToString(), tienchi2.ToString(), chenhlech2.ToString(), "Ki Han 3 Thang" };
            dataGridView1.Rows.Add(row);
            row = new string[] { txt_Ngay.Text, (tienthu3 + tien3).ToString(), tienchi3.ToString(), chenhlech3.ToString(), "Ki Han 6 Thang" };
            dataGridView1.Rows.Add(row);
          

            

   



        


         
        }
    }
}
