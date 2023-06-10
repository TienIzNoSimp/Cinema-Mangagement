using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyRapPhim.BS_layer
{
    internal class BLLogin
    {
        public bool KiemTra (string username, string password)
        {
            QLRapPhimEntities qLRapPhimEntities = new QLRapPhimEntities ();
            var r = (from p in qLRapPhimEntities.tblUsers where p.username == username select p).SingleOrDefault();

            if (r != null)
            {
                if (r.password == password)
                {
                    return true;
                }
            }    
            return false;
        }
    }
}
