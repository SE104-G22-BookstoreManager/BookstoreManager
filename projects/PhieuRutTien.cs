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
            return 180;
        }
        private void INSERT_Click(object sender, EventArgs e)
        {
            // connect database
           connect_database a = new connect_database();
            a.Connect();

            string MaSoTietKiem = txt_MaTietKiem.Text;
            string NgayRut = txt_Ngayrut.Text;
            String sql1 = "select Type, Money_send, DateOpen from SoTietKiem where id=\"" + MaSoTietKiem + "\" ";
 
            string LoaiTietKiem;
            DataTable _queryResult1 = a.m_database.GetDataTable(sql1);
            
            double Tien_lai = 0;
            double Tien_ConLai = 0;

                    object[] _itemArray = _queryResult1.Rows[0].ItemArray;
                     LoaiTietKiem = _itemArray[0].ToString();
                    string Tien = _itemArray[1].ToString();
                    string Ngay =_itemArray[2].ToString();

                  //  DateTime ngay1 = Convert.ToDateTime(Ngay);// ngay gửi tiên là Ngày
                  //  DateTime ngay2 = Convert.ToDateTime(Ngay); //ngày rút tiền  là NgayRut
                    DateTime ngay1 = DateTime.Now;
                    DateTime ngay2 = DateTime.Now;

                      //tính số tháng tiết kiệm 
                    if (LoaiTietKiem == "0")
                    {
                        if (KhoangCachNgay(ngay1, ngay2) > 15)
                        {
                           
                            Tien_lai = Tien_lai + Convert.ToDouble(Tien) + (0.0015 * Convert.ToDouble(Tien) * (KhoangCachNgay(ngay1, ngay2) / 30));
                            if (Convert.ToDouble(txt_Tienrut.Text) > Convert.ToDouble(Tien_lai))
                            {
                                MessageBox.Show(" so tien rut qua lon khong du rut");
                                 Option option = new Option();
                                option.Show();
                                this.Hide();
                              }
                            else
                            {
                                 Tien_ConLai = Tien_lai - Convert.ToDouble(txt_Tienrut.Text);
                                a.m_database.Insert("PhieuRutTien", CreateDictionary(txt_Ngayrut.Text,txt_Hoten.Text,txt_Tienrut.Text,txt_MaTietKiem.Text,txt_MaKH.Text));
                                  string where = "id=\"" + MaSoTietKiem + "\" ";
                                 a.m_database.Update("SoTietKiem",CreateDictionary_1(Tien_ConLai.ToString()), where);   
                                MessageBox.Show(" DA RUT DUOC TIEN");
                                if (Tien_ConLai==0)
                                {
                                    
                                     string where1 = "MaSoTietKiem=\"" + MaSoTietKiem + "\" ";
                                    string delete="1";
                                     a.m_database.Update("SoTietKiem", CreateDictionary_2(delete), where); 
                                }
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show(" Chưa được rút vì ngày ngay gui <15");
                        }
                    }
                    // đối với lãi xuất 6 tháng
                    if (LoaiTietKiem == "6")
                    {
                        if ((KhoangCachNgay(ngay1, ngay2)<180))
                        {
                            MessageBox.Show(" chưa đến kì hạn lãi xuất");
                            Option option = new Option();
                            option.Show();
                            this.Hide();
                        }
                        else
                        {
                             Tien_lai = Tien_lai + Convert.ToDouble(Tien) + (0.0055 * Convert.ToDouble(Tien) * (KhoangCachNgay(ngay1, ngay2) / 30));
                            if (Convert.ToDouble(txt_Tienrut.Text) > Convert.ToDouble(Tien_lai))
                            {
                                MessageBox.Show(" so tien rut qua lon khong du rut");
                                 Option option = new Option();
                                option.Show();
                                this.Hide();
                              }
                            else
                            {
                              DialogResult dialogResult = MessageBox.Show("Ban phai rut het tien ","Some", MessageBoxButtons.YesNo);
                              if (dialogResult == DialogResult.Yes)
                              {
                                  txt_Tienrut.Text = Tien_lai.ToString();
                                  Tien_ConLai = 0;
                                  a.m_database.Insert("PhieuRutTien", CreateDictionary(txt_Ngayrut.Text, txt_Hoten.Text, txt_Tienrut.Text, txt_MaTietKiem.Text, txt_MaKH.Text));
                                  string where = "id=\"" + MaSoTietKiem + "\" ";
                                  a.m_database.Update("SoTietKiem", CreateDictionary_1(Tien_ConLai.ToString()), where);
                                  MessageBox.Show(" DA RUT DUOC TIEN");
                                  string delete = "1";
                                  string where1 = "id=\"" + MaSoTietKiem + "\" ";
                                  a.m_database.Update("SoTietKiem", CreateDictionary_2(delete), where);
                              }
                              else
                              {
                                  Option option = new Option();
                                  option.Show();
                                  this.Hide();
                              }
                        
                            }
                           
                          
             
                        }
                    }
                    // đối với lãi xuất 3 tháng 
                    if (LoaiTietKiem == "3")
                    {
                        if ((KhoangCachNgay(ngay1, ngay2) < 90))
                        {
                            MessageBox.Show(" chưa đến kì hạn lãi xuất");
                            Option option = new Option();
                            option.Show();
                            this.Hide();
                        }
                        else
                        {
                            Tien_lai = Tien_lai + Convert.ToDouble(Tien) + (0.005 * Convert.ToDouble(Tien) * (KhoangCachNgay(ngay1, ngay2) / 30));
                            if (Convert.ToDouble(txt_Tienrut.Text) > Convert.ToDouble(Tien_lai))
                            {
                                MessageBox.Show(" so tien rut qua lon khong du rut");
                                Option option = new Option();
                                option.Show();
                                this.Hide();
                            }
                            else
                            {
                                DialogResult dialogResult = MessageBox.Show("Ban phai rut het tien ","Some", MessageBoxButtons.YesNo);
                                        if(dialogResult == DialogResult.Yes)
                                        {
                                            txt_Tienrut.Text = Tien_lai.ToString();
                                            Tien_ConLai = 0;
                                            a.m_database.Insert("PhieuRutTien", CreateDictionary(txt_Ngayrut.Text, txt_Hoten.Text, txt_Tienrut.Text, txt_MaTietKiem.Text, txt_MaKH.Text));
                                            string where = "id=\"" + MaSoTietKiem + "\" ";
                                            a.m_database.Update("SoTietKiem", CreateDictionary_1(Tien_ConLai.ToString()), where);
                                            MessageBox.Show(" DA RUT DUOC TIEN");
                                            string delete = "1";
                                            string where1 = "id=\"" + MaSoTietKiem + "\" ";
                                            a.m_database.Update("SoTietKiem", CreateDictionary_2(delete), where);
                                        }
                                        else
                                        {
                                            MessageBox.Show(" so tien rut qua lon khong du rut");
                                            Option option = new Option();
                                            option.Show();
                                            this.Hide();
                                        }
                                                  
                            }



                        }
                    }
                  
          
            
        }
     
        public Dictionary<string, string> CreateDictionary(string ngayrut, string HoTen, string SoTienRut, string MaSoTietKiem,string MaKH)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
           
            _dict.Add("NgayRut", ngayrut);
            _dict.Add("TenKhachHang", HoTen);
            _dict.Add("MaSoTietKiem", MaSoTietKiem);
            _dict.Add("SoTienRut", SoTienRut);
            _dict.Add("MaKH",MaKH);
          
         return _dict;
        }
        public Dictionary<string, string> CreateDictionary_1(string Tien)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
            _dict.Add("Money_send", Tien);
            return _dict;
        }
        public Dictionary<string, string> CreateDictionary_2(string delete)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
            _dict.Add("Delete", delete);
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
