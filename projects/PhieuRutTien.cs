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

        private void INSERT_Click(object sender, EventArgs e)
        {
            connect_database a = new connect_database();
            a.Connect();
             a.m_database.Insert("PhieuRutTien", CreateDictionary( txt_id.Text,txt_ten.Text,txt_Ngayrut.Text,txt_Tienrut.Text,txt_maso.Text));
             MessageBox.Show(" DA RUT DUOC TIEN");
             Option option = new Option();
             option.Show();
             this.Hide();
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
