
using BT03_102190164_BuiVietHuyhoang.DAL;
using BT03_102190164_BuiVietHuyhoang.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT03_102190164_BuiVietHuyhoang.BLL
{
    class BLL_QLSV
    {
        public delegate bool DelSort(object a, object b);
        private static BLL_QLSV _Instance;
        public static BLL_QLSV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLSV();
                }
                return _Instance;
            }
            private set { }
        }
        public List<SV> GetListSV_BLL(int ID_Lop, string textSeach)
        {
            List<SV> all = DAL_QLSV.Instance.GetAllSV_DAL();
            List<SV> result = new List<SV>();
            if (ID_Lop != 0)
            {
                foreach (SV s in all)
                {
                    if (s.ID_Lop == ID_Lop)
                    {
                        result.Add(s);
                    }
                }
            }
            if (textSeach == "")
            {
                if (ID_Lop == 0)
                {
                    return all;
                }
                return result;
            }
            else
            {
                if (ID_Lop == 0)
                {
                    result.Clear();
                    foreach (SV s in all)
                    {
                        if (s.NameSV.ToLower().Contains(textSeach))
                        {
                            result.Add(s);
                        }
                    }
                    return result;
                }
                all.Clear();
                foreach (SV s in result)
                {
                    if (s.NameSV.ToLower().Contains(textSeach))
                    {
                        all.Add(s);
                    }
                }
                return all;
            }
        }
        public List<LopSH> GetAllLSH_BLL()
        {
            return DAL_QLSV.Instance.GetAllLSH_DAL();
        }
        public bool IsTrue(string mssv)
        {
            List<SV> list = DAL_QLSV.Instance.GetAllSV_DAL();
            foreach (SV s in list)
            {
                if (s.MSSV == mssv)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddOrEditSV(SV sv)
        {
            if (!IsTrue(sv.MSSV))
            {
                DAL_QLSV.Instance.AddSV_DAL(sv);
            }
            else
            {
                DAL_QLSV.Instance.EditSV_DAL(sv);
            }
        }
        public SV GetSVByMSSV(string mssv)
        {
            List<SV> list = DAL_QLSV.Instance.GetAllSV_DAL();
            foreach (SV s in list)
            {
                if (s.MSSV == mssv)
                {
                    return s;
                }
            }
            return null;
        }
        public LopSH GetLSHByIDL(int id_Lop)
        {
            List<LopSH> list = DAL_QLSV.Instance.GetAllLSH_DAL();
            foreach (LopSH lsh in list)
            {
                if (lsh.ID_Lop == id_Lop)
                {
                    return lsh;
                }
            }
            return null;
        }
        public void DeleteSV(string mssv)
        {
            if (IsTrue(mssv))
            {
                DAL_QLSV.Instance.DeleteSV_DAL(mssv);
            }
        }
        public void Sort(List<SV> list, DelSort del)
        {
            SV temp;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (del(list[i], list[j]))
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
        public List<SVView> Views(int idLop, string nameSV)
        {
            List<SVView> svViews = new List<SVView>();
            if(idLop == 0 && nameSV == "")
            {
                foreach(SV i in DAL_QLSV.Instance.GetAllSV_DAL())
                {
                    svViews.Add(GetSVView(i));
                }
            }
            else
            {
                foreach(SV i in GetListSV_BLL(idLop, nameSV))
                {
                    svViews.Add(GetSVView(i));
                }
            }
            return svViews;
        }
        public SVView GetSVView(SV s)
        {
            SVView svv = new SVView();
            svv.MSSV = s.MSSV;
            svv.NameSV = s.NameSV;
            svv.Gender = s.Gender;
            svv.NS = s.NS;
            svv.NameLop = DAL_QLSV.Instance.GetNameLopSH(s.ID_Lop);
            return svv;
        }
    }
}
