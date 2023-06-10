using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyRapPhim.BS_layer
{
    internal class BLSignUp
    {
        public bool ThemUser (string username, string password)
        {
            QLRapPhimEntities qLRapPhimEntities = new QLRapPhimEntities();
            var us = (from p in qLRapPhimEntities.tblUsers where p.username == username select p).SingleOrDefault();
            if (us != null)
            {
                return false;
            }
            else
            {
                tblUser tblUser = new tblUser();
                tblUser.username = username;
                tblUser.password = password;
                qLRapPhimEntities.tblUsers.Add(tblUser);
                qLRapPhimEntities.SaveChanges();
                return true;
            }
        }
    }
}
