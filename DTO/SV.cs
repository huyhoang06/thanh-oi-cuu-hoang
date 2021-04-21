using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03_102190164_BuiVietHuyhoang.DTO
{
    public class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public bool Gender { get; set; }
        public DateTime NS { get; set; }
        public int ID_Lop { get; set; }
        public SV() { }
        public SV(string ms, string n, bool gender, DateTime ns, int id)
        {
            MSSV = ms;
            NameSV = n;
            Gender = gender;
            NS = ns;
            ID_Lop = id;
        }
        public static bool ASCNameSV(object a, object b)
        {
            if (String.Compare(((SV)a).NameSV, ((SV)b).NameSV) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool DESCTenSV(object a, object b)
        {
            if (String.Compare(((SV)a).NameSV, ((SV)b).NameSV) < 0)
            {
                return true;
            }
            return false;
        }
        public static bool DESCNS(object a, object b)
        {
            if (((SV)a).NS < ((SV)b).NS)
            {
                return true;
            }
            return false;
        }
        public static bool ASCNS(object a, object b)
        {
            if (((SV)a).NS > ((SV)b).NS)
            {
                return true;
            }
            return false;
        }
    }
}
