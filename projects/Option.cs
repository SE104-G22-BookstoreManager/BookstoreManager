using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassbookManagement
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoTietKiem STK = new SoTietKiem();
            STK.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PhieuGuiTien PGT = new PhieuGuiTien();
            PGT.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PhieuRutTien PRT = new PhieuRutTien();
            PRT.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhSachSoTietKiem a = new DanhSachSoTietKiem();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThuHangNgay BCN = new BaoCaoDoanhThuHangNgay();
            BCN.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThuHangThang BCT = new BaoCaoDoanhThuHangThang();
            BCT.Show();
            this.Hide();
        }
    }
}
