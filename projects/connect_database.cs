using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PassbookManagement
{
    class connect_database
    {
        public SQLiteConnection conn = new SQLiteConnection();
        public SQLiteDatabase m_database ;
        
        public  void Connect()
        {
            
           
             m_database = new SQLiteDatabase("../../data/CNPM.s3db");
        }
    }
}
