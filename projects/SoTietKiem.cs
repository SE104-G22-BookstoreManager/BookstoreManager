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
    public partial class SoTietKiem : Form
    {
        SQLiteConnection conn = new SQLiteConnection();
        SQLiteDatabase m_database;
        public SoTietKiem()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);//Thêm sự kiện click
            m_database = new SQLiteDatabase("../../data/CNPM.s3db");
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
            m_database.Insert("SoTietKiem", CreateDictionary( txt_MKH.Text, txt_hoten.Text, txt_cmnd.Text, txt_diachi.Text, txt_tiengui.Text, txt_ngaygui.Text, TietKiemLoai));
        }
        public Dictionary<string, string> CreateDictionary( string MA_KHANG, string HoTenKH, string CMND, string DiaChi, string SoTienGui, string NgayMoSo, string MaLoaiTietKiem)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
            // _dict.Add("ID", id);
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
