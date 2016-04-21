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
            return 3;
        }
        private void bnt_insert_Click(object sender, EventArgs e)
        {
            // connect database 
            connect_database a = new connect_database();
            a.Connect();

            string MaSo = txt_MaSo.Text; // lấy mã sổ tiết kiệm
            // chỉ nhận gửi thêm tiền khi đến kì hạn lãi xuất; 
            string NgayGui = txt_Ngaygui.Text;
     

            String sql1 = "select MaLoaiTietKiem, SoTienGui, NgayMoSo from SoTietKiem where MaSoTietKiem=\"" + MaSo + "\" ";
            DataTable _queryResult1 = a.m_database.GetDataTable(sql1);
            Double Tien_lai = 0;
            String LoaiTietKiem;
            if (_queryResult1.Rows.Count == 0)
            {
                MessageBox.Show("không có mã sổ tiết kiệm này tồn tại");
            }
            else
            {

                for (int i = 0; i < _queryResult1.Rows.Count; i++)
                {

                    object[] _itemArray = _queryResult1.Rows[i].ItemArray;
                     LoaiTietKiem = _itemArray[0].ToString();
                    string Tien = _itemArray[1].ToString();
                    string Ngay =_itemArray[2].ToString();
                    DateTime ngay1 = Convert.ToDateTime(Ngay);
                    DateTime ngay2 = Convert.ToDateTime(Ngay); //Convert.ToDateTime(txt_Ngaygui.ToString()
                
                    if(LoaiTietKiem=="0")
                    {
                        Tien_lai = Tien_lai + Convert.ToDouble(Tien);
                    }
                    if (LoaiTietKiem == "3")
                    {
                        if (KhoangCachNgay(ngay1, ngay2) == 3)
                        {
                            Tien_lai = Tien_lai + Convert.ToDouble(Tien);
                        }
                        else {
                            MessageBox.Show("chua den thoi ki gui them tien");
                            Option option = new Option();
                            option.Show();
                            this.Hide();

                        }
                    }
                    if (LoaiTietKiem == "6")
                    {
                        if (KhoangCachNgay(ngay1, ngay2) == 3)
                        {
                            Tien_lai = Tien_lai + Convert.ToDouble(Tien);
                        }
                        else
                        {
                            MessageBox.Show("chua den thoi ki gui them tien");
                            Option option = new Option();
                            option.Show();
                            this.Hide();

                        }
                    }
                   

                }
            }




            double tien = Convert.ToDouble(txt_Tiengui.Text);
            if (tien < 1000000)
            {
                MessageBox.Show(" tien duoi 100000 nhap lai", "Thong Bao ");
                Option option = new Option();
                option.Show();
                this.Hide();
            }
            else
            {
                
                a.m_database.Insert("PhieuGuiTien", CreateDictionary(txt_ma.Text, txt_Hoten.Text, txt_Ngaygui.Text, txt_Tiengui.Text, txt_MaSo.Text));
                MessageBox.Show(" GUI TIEN THANH CONG");
                double TongTien = tien+Tien_lai;
                // update lại sổ tiết kiệm 
                string where = "MaSoTietKiem=\"" + MaSo + "\" ";
                a.m_database.Update("SoTietKiem",CreateDictionary_1(TongTien.ToString()), where);

                Option option = new Option();
                
                option.Show();
                this.Hide();
            }
        }
        public Dictionary<string, string > CreateDictionary_1(string Tien)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
            _dict.Add("SoTienGui", Tien);
            return _dict;
        }
        public Dictionary<string, string> CreateDictionary(string MaPhieuGui , string HoTen , string NgayGui, string SoTienGui, string MaSoTietKiem)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
            // _dict.Add("ID", id);
            _dict.Add("MaPhieuGuiTien", MaPhieuGui);
            _dict.Add("TenKhachHang", HoTen);
            _dict.Add("NgayGui", NgayGui);
            _dict.Add("SoTienGui", SoTienGui);
            _dict.Add("MaSoTietKiem", MaSoTietKiem);
            return _dict;
        }

    }
}
