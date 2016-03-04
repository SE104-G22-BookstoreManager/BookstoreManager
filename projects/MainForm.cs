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
    public partial class MainForm : Form
    {
		SQLiteConnection m_dbConnection;
		SQLiteDatabase m_database;

		public MainForm()
        {
            InitializeComponent();

			//m_database = new SQLiteDatabase("path_to_db");
		}
    }
}
