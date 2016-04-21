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
    public partial class PhieuRutTien : Form
    {

        public PhieuRutTien()
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
            return 50;
        }
        private void INSERT_Click(object sender, EventArgs e)
        {
            // connect database
            connect_database a = new connect_database();
            a.Connect();

            string MaSoTietKiem = txt_maso.Text;
            string NgayRut = txt_Ngayrut.Text;
            String sql1 = "select MaLoaiTietKiem, SoTienGui, NgayMoSo from SoTietKiem where MaSoTietKiem=\"" + MaSoTietKiem + "\" ";
             double Tien_ConLai =0;
            string LoaiTietKiem;
            DataTable _queryResult1 = a.m_database.GetDataTable(sql1);
            
            double Tien_lai = 0;
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

                      //tính số tháng tiết kiệm 
                    if (LoaiTietKiem == "0")
                    {
                        if (KhoangCachNgay(ngay1, ngay2) > 15)
                        {
                            Tien_lai = Tien_lai + Convert.ToDouble(Tien) + (0.0015 * Convert.ToDouble(Tien) * (KhoangCachNgay(ngay1, ngay2) / 30));
                            Tien_ConLai = Tien_lai - Convert.ToDouble(txt_Tienrut.Text);
                            MessageBox.Show("so tien rut la ", txt_Tienrut.Text);
                        }
                        else
                        {
                            MessageBox.Show(" Chưa được rút vì ngày ngay gui <15");
                            Option option = new Option();
                            option.Show();
                            this.Hide();

                        }
                    }
                    // đối với lãi xuất 6 tháng
                    if (LoaiTietKiem == "6")
                    {
                        if (((KhoangCachNgay(ngay1, ngay2) % 30) % 6) != 0)
                        {
                            MessageBox.Show(" chưa đến kì hạn lãi xuất");
                            Option option = new Option();
                            option.Show();
                            this.Hide();
                        }
                        else
                        {
                            Tien_lai = Tien_lai + Convert.ToDouble(Tien) + (0.0055 * Convert.ToDouble(Tien) * (KhoangCachNgay(ngay1, ngay2) / 30));
                            Tien_ConLai = 0;
                            MessageBox.Show("so tien rut la ",Tien_lai.ToString());
                        }
                    }
                    // đối với lãi xuất 3 tháng 
                    if (LoaiTietKiem == "3")
                    {
                        if (((KhoangCachNgay(ngay1, ngay2) % 30) % 3) != 0)
                        {
                            MessageBox.Show(" chưa đến kì hạn lãi xuất");
                            Option option = new Option();
                            option.Show();
                            this.Hide();
                        }
                        else
                        {
                            Tien_lai = Tien_lai + Convert.ToDouble(Tien) + (0.005 * Convert.ToDouble(Tien) * (KhoangCachNgay(ngay1, ngay2) / 30));
                            MessageBox.Show("so tien rut la ", Tien_lai.ToString());
                            Tien_ConLai = 0;
                        }
                    }
           
                    
                    

                }
            }
           

             a.m_database.Insert("PhieuRutTien", CreateDictionary( txt_id.Text,txt_ten.Text,txt_Ngayrut.Text,txt_Tienrut.Text,txt_maso.Text));

             MessageBox.Show(" DA RUT DUOC TIEN");
             string where = "MaSoTietKiem=\"" + MaSoTietKiem + "\" ";
             a.m_database.Update("SoTietKiem", CreateDictionary_1(Tien_ConLai.ToString()), where);   
             this.Hide();
             Option otion = new Option();
             otion.Show();
             this.Hide();
        }
        public Dictionary<string, string> CreateDictionary_1(string Tien)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
            _dict.Add("SoTienGui", Tien);
            return _dict;
        }
        public Dictionary<string, string> CreateDictionary(string MaPhieu, string HoTen , string NgayRut, string SoTienRut, string MaSoTietKiem)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
           
            _dict.Add("MaPhieuRutTien", MaPhieu);
            _dict.Add("TenKhachHang", HoTen);
            _dict.Add("NgayRut", NgayRut);
            _dict.Add("SoTienRut", SoTienRut);
            _dict.Add("MaSoTietKiem", MaSoTietKiem);
         return _dict;
        }
    }
}
