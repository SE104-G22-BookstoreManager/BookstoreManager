using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PassbookManagement
{
	public partial class SoTietKiem : Form
    {
        
        public SoTietKiem()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);//Thêm sự kiện click
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TietKiemLoai="0";
            if (txt_tk0.Checked==true){
               TietKiemLoai = "0";
            }
            if (txt_tk3.Checked==true)
            {
                TietKiemLoai = "3";
            }
            if(txt_tk6.Checked==true)
            {
                TietKiemLoai = "6";
            }
        
           
           
                connect_database a = new connect_database();

                a.Connect();
                a.m_database.Insert("SoTietKiem", CreateDictionary(txt_MaSo.Text, txt_MKH.Text, txt_hoten.Text, txt_cmnd.Text, txt_diachi.Text, txt_tiengui.Text, txt_ngaygui.Text, TietKiemLoai));
                MessageBox.Show(" DA Mo DUOC SO TIET KIEM");
                Option option = new Option();
                option.Show();
                this.Hide();
            
          
        }
        public Dictionary<string, string> CreateDictionary( string  id,string MA_KHANG, string HoTenKH, string CMND, string DiaChi, string SoTienGui, string NgayMoSo, string MaLoaiTietKiem)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
             _dict.Add("MaSoTietKiem", id);
            _dict.Add("MaKH",MA_KHANG );
            _dict.Add("HoTenKH", HoTenKH);
            _dict.Add("CMND", CMND);
            _dict.Add("DiaChi", DiaChi);
            _dict.Add("SoTienGui", SoTienGui );
            _dict.Add("NgayMoSo", NgayMoSo);
            _dict.Add("MaLoaiTietKiem", MaLoaiTietKiem);

            return _dict;
        }

        
    }
}
