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
        
        public SoTietKiem()
        {
            InitializeComponent();
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect_database a = new connect_database();

            a.Connect();
            string TietKiemLoai = "0";
            if (txt_tk0.Checked == true)
            {
                TietKiemLoai = "0";
            }
            if (txt_tk3.Checked == true)
            {
                TietKiemLoai = "3";
            }
            if (txt_tk6.Checked == true)
            {
                TietKiemLoai = "6";
            }
            double tien = Convert.ToDouble(txt_tiengui.Text);
            if (tien < 1000000)
            {
                MessageBox.Show(" tien duoi 1000000 nhap lai", "Thong Bao ");
            }
            else
            {

                String sql1 = "select id from KhachHang where CMND=\"" + txt_cmnd.Text + "\" ";

                DataTable _queryResult1 = a.m_database.GetDataTable(sql1);


                if (_queryResult1.Rows.Count == 0)
                {
                    a.m_database.Insert("KhachHang", CreateDictionary_1(txt_hoten.Text, txt_cmnd.Text, txt_number.Text, txt_diachi.Text));
                    String sql2 = "select id from KhachHang where CMND=\"" + txt_cmnd.Text + "\" ";
                    DataTable _queryResult2 = a.m_database.GetDataTable(sql2);
                    object[] _itemArray = _queryResult1.Rows[0].ItemArray;
                    txt_MKH.Text = _itemArray[0].ToString();
                    a.m_database.Insert("SoTietKiem", CreateDictionary(txt_MKH.Text, txt_tiengui.Text, txt_ngaygui.Text, TietKiemLoai));
                    MessageBox.Show(" DA Mo DUOC SO TIET KIEM");

                }
                else
                {


                    object[] _itemArray = _queryResult1.Rows[0].ItemArray;
                    txt_MKH.Text = _itemArray[0].ToString();
                    a.m_database.Insert("SoTietKiem", CreateDictionary(txt_MKH.Text, txt_tiengui.Text, txt_ngaygui.Text, TietKiemLoai));
                    MessageBox.Show(" DA Mo DUOC SO TIET KIEM");



                }
            } 
               
                Option option = new Option();
                option.Show();
                this.Hide();
        }
            
            
    
        public Dictionary<string, string> CreateDictionary( string  MaKH,string money, string date, string type)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
             
                
            _dict.Add("MaKH", MaKH );
            _dict.Add("Money_send", money);
            _dict.Add("DateOpen", date);
            _dict.Add("Type", type);

            return _dict;
        }
        public Dictionary<string, string> CreateDictionary_1(string name, string cmnd, string phone, string address)
        {
            Dictionary<string, string> _dict = new Dictionary<string, string>();
            _dict.Add("name", name);
            _dict.Add("CMND", cmnd);
            _dict.Add("phone_number", phone);
            _dict.Add("address", address);
           
            return _dict;
        }


        
    }
}
