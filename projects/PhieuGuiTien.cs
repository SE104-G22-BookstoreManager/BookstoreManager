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
    public partial class PhieuGuiTien : Form
    {
       
        public PhieuGuiTien()
        {
            InitializeComponent();
            
           
        }

        private void bnt_insert_Click(object sender, EventArgs e)
        {
            connect_database a = new connect_database();
            a.Connect();
        a.m_database.Insert("PhieuGuiTien", CreateDictionary(txt_ma.Text, txt_Hoten.Text, txt_Ngaygui.Text,txt_Tiengui.Text,txt_MaSo.Text));
        MessageBox.Show(" GUI TIEN THANH CONG");
        Option option = new Option();
        option.Show();
        this.Hide();
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
