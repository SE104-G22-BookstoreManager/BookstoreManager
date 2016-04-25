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
using System.Globalization;

namespace PassbookManagement
{
    public partial class PhieuGuiTien : Form
    {
       
        public PhieuGuiTien()
        {
            InitializeComponent();
            
           
        }
        public int KhoangCachNgay(DateTime a, DateTime b)
        {
            // code để tính khoang cách 2 ngày
            /* MessageBox.Show(Convert.ToString(ts.TotalDays));
                    DateTime ngay1 = Convert.ToDateTime(Ngay);
                    DateTime ngay2 = Convert.ToDateTime(txt_Ngaygui.ToString());
                   // DateTime ngay2 = Convert.ToDateTime(NgayGui);
                    TimeSpan Time = ngay2 - ngay1;
                    Time.TotalDays();*/
            return 90;
        } // viết lại hàm tính khoảng cách 2 ngày.
       private void bnt_insert_Click(object sender, EventArgs e)
        {
            // connect database 
            connect_database a = new connect_database();
            a.Connect();
           // string MaSo = txt_MaSo.Text; // lấy mã sổ tiết kiệm
            // chỉ nhận gửi thêm tiền khi đến kì hạn lãi xuất; 
            string NgayGui = txt_Ngaygui.Text;
            double tien = Convert.ToDouble(txt_Tiengui.Text);
            string sql2 = "select DateOpen,Type,Money_send from SoTietKiem where id=\"" +txt_MaTietKiem.Text + "\" ";
            DataTable _queryResult2 = a.m_database.GetDataTable(sql2);
                object[] _itemArray = _queryResult2.Rows[0].ItemArray;
                string Ngay_MoSo = _itemArray[0].ToString();
                string Type =_itemArray[1].ToString();
                string TienGui = _itemArray[2].ToString();
                tien = tien + Convert.ToDouble(TienGui);
                //DateTime ngay1 = Convert.ToDateTime(txt_Ngaygui.ToString());
                //DateTime ngay2= Convert.ToDateTime(txt_Ngaygui.ToString());
                DateTime ngay1 = DateTime.Now;
                DateTime ngay2 = DateTime.Now;


            if (tien < 100000)
            {
                MessageBox.Show(" tien duoi 100000 nhap lai", "Thong Bao ");
                Option option = new Option();
                option.Show();
                this.Hide();
            }
            else
            {

                if (Type == "0")
                {
                    a.m_database.Insert("PhieuGuiTien", CreateDictionary(txt_Ngaygui.Text, txt_Hoten.Text, txt_MaTietKiem.Text, txt_MaKH.Text, txt_Tiengui.Text));
                   
                    
                    // update lại sổ tiết kiệm 
                    string where = "id=\"" + txt_MaTietKiem.Text + "\" ";
                    a.m_database.Update("SoTietKiem", CreateDictionary_1(tien.ToString()), where);
                    MessageBox.Show(" GUI TIEN THANH CONG");

                }
                if (Type == "3")
                {
                    if ((KhoangCachNgay(ngay1, ngay2) % 90 == 0)) // đến 3 tháng sẽ đến kì hạn 
                    {
                        a.m_database.Insert("PhieuGuiTien", CreateDictionary(txt_Ngaygui.Text, txt_Hoten.Text, txt_MaTietKiem.Text, txt_MaKH.Text, txt_Tiengui.Text));

                        // update lại sổ tiết kiệm 
                        string where = "id=\"" + txt_MaTietKiem.Text + "\" ";
                        a.m_database.Update("SoTietKiem", CreateDictionary_1(tien.ToString()), where);
                        MessageBox.Show(" GUI TIEN THANH CONG");
                    }
                    else
                    {
                        txt_Tiengui.Text = "";
                        txt_Ngaygui.Text = "";
                    }


                }
                if (Type == "6")
                {
                    if ((KhoangCachNgay(ngay1, ngay2) % 120 == 0)) // đến 6 tháng sẽ đến kì hạn 
                    {
                        
                        a.m_database.Insert("PhieuGuiTien", CreateDictionary(txt_Ngaygui.Text, txt_Hoten.Text, txt_MaTietKiem.Text, txt_MaKH.Text, txt_Tiengui.Text));
                       

                        // update lại sổ tiết kiệm 
                        string where = "id=\"" + txt_MaTietKiem.Text + "\" ";
                        a.m_database.Update("SoTietKiem", CreateDictionary_1(tien.ToString()), where);
                        MessageBox.Show(" GUI TIEN THANH CONG");
                    }
                    else
                    {
                        MessageBox.Show("chua den thoi gian gui");
                        txt_Tiengui.Text = "";
                        txt_Ngaygui.Text = "";
                    }

                }

              

                
            }
           

    }      
        public Dictionary<string,string> CreateDictionary_1(string tien)
       {
           Dictionary<string, string> _dict = new Dictionary<string, string>();
           _dict.Add("Money_send", tien);
           return _dict;
       }
    
        public Dictionary<string, string> CreateDictionary(string ngaygui , string tenkh , string masotk, string makh, string tiengui)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
            // _dict.Add("ID", id);
            _dict.Add("NgayGui", ngaygui);
            _dict.Add("TenKhachHang", tenkh);
            _dict.Add("MaSoTietKiem", masotk);
            _dict.Add("SoTienGui", tiengui);
            _dict.Add("MaKH", makh);
            return _dict;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             connect_database a = new connect_database();
            a.Connect();
            int id = 0;
            string ten="";
            string sql1 = "select id, name from KhachHang where CMND=\"" + txt_cmnd.Text + "\" ";
            DataTable _queryResult1 = a.m_database.GetDataTable(sql1);

            if (_queryResult1.Rows.Count == 0)
            {
                MessageBox.Show("Khach Hang Nay Chua Mo So de nghi Mo so");
                Option option = new Option();
                option.Show();
                this.Hide();

            }
            else
            {

                    object[] _itemArray = _queryResult1.Rows[0].ItemArray;

                    string id_1 = _itemArray[0].ToString(); id = Convert.ToInt16(id_1);
                     ten = _itemArray[1].ToString();
                
            }

            string sql2 = "select id,Money_send from SoTietKiem where MaKH=\"" + id + "\" ";
            DataTable _queryResult2 = a.m_database.GetDataTable(sql2);
            for (int i = 0; i < _queryResult2.Rows.Count; i++)
            {

                object[] _itemArray = _queryResult2.Rows[i].ItemArray;
                string id_STK = _itemArray[0].ToString();
               
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[1].Value = ten;
                dataGridView1.Rows[n].Cells[0].Value = id.ToString();
                dataGridView1.Rows[n].Cells[2].Value = id_STK;
                txt_MaTietKiem.Items.Add(id_STK);
                txt_Hoten.Text = ten;
                txt_MaKH.Text = id.ToString();
            }


        }

    }
}
