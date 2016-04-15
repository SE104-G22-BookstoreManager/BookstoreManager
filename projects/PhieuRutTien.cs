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

        SQLiteConnection conn = new SQLiteConnection();
        SQLiteDatabase m_database;
        public PhieuRutTien()
        {
            InitializeComponent();
            m_database = new SQLiteDatabase("../../data/CNPM.s3db");
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
             m_database.Insert("SoTietKiem", CreateDictionary(txt_id.Text, txt_ten.Text,txt_Ngayrut.Text,txt_Tienrut.Text,txt_maso.Text));
        }
        public Dictionary<string, string> CreateDictionary(string MaPhieuRut, string HoTen , string NgayRut, string SoTienRut, string MaSoTietKiem)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
            // _dict.Add("ID", id);
            _dict.Add("MaPhieuRuiTien", MaPhieuRut);
            _dict.Add("TenKhachHang", HoTen);
            _dict.Add("NgayRut", NgayRut);
            _dict.Add("SoTienRut", SoTienRut);
            _dict.Add("MaSoTietKiem", MaSoTietKiem);
           
                     return _dict;
        }
    }
}
