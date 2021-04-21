using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03_102190164_BuiVietHuyhoang.DAL
{
    class DBHelper
    {
        private static DBHelper _Instance;
        private SqlConnection cnn;
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string connectstr = @"Data Source=LAPTOP-HQLUETK7\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
                    _Instance = new DBHelper(connectstr);
                }
                return _Instance;
            }

            private set
            { }
        }
        private DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public DataTable GetRecords(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public void ExcuteDB(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
