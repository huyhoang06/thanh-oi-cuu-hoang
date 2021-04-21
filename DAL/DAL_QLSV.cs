﻿using BT03_102190164_BuiVietHuyhoang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT03_102190164_BuiVietHuyhoang.DAL
{
    class DAL_QLSV
    {
        private static DAL_QLSV _Instance;
        public static DAL_QLSV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLSV();
                }
                return _Instance;
            }
            private set { }
        }
        public List<SV> GetAllSV_DAL()
        {
            List<SV> list = new List<SV>();
            string query = "Select * from SV";
            DataTable dt = DBHelper.Instance.GetRecords(query);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new SV()
                {
                    MSSV = dr["MSSV"].ToString(),
                    NameSV = dr["NameSV"].ToString(),
                    Gender = (bool)dr["Gender"],
                    NS = (DateTime)dr["NS"],
                    ID_Lop = (int)dr["ID_Lop"]
                });
            }
            return list;
        }
        public List<LopSH> GetAllLSH_DAL()
        {
            string query = "Select * from LSH";
            List<LopSH> list = new List<LopSH>();
            DataTable dt = DBHelper.Instance.GetRecords(query);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new LopSH()
                {
                    ID_Lop = (int)dr["ID_Lop"],
                    NameLop = dr["NameLop"].ToString()
                });
            }
            return list;
        }
        public void AddSV_DAL(SV s)
        {
            string query = $"Insert into SV Values ('{s.MSSV}','{s.NameSV}','{s.Gender}','{s.NS}','{s.ID_Lop}')";
            DBHelper.Instance.ExcuteDB(query);
        }
        public void EditSV_DAL(SV s)
        {
            string query = $"UPDATE SV SET NameSV = '{s.NameSV}', Gender= '{s.Gender}', NS = '{s.NS}', ID_Lop = {s.ID_Lop} WHERE MSSV = {s.MSSV}";
            //MessageBox.Show(query);
            DBHelper.Instance.ExcuteDB(query);
        }
        public void DeleteSV_DAL(string mssv)
        {
            string query = $"delete from SV where MSSV = {mssv}";
            DBHelper.Instance.ExcuteDB(query);
        }
        public string GetNameLopSH(int idLop)
        {
            string query = "Select NameLop from LSH where ID_Lop = " + idLop.ToString();
            DataRow r = DBHelper.Instance.GetRecords(query).Rows[0];
            return r["NameLop"].ToString();
        }
    }
}
