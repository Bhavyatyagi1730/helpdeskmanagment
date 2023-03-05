using Model;
using Service.Entities;
using Service.Interface;
using Model;
using Service.Entities;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Class
{
    public class Login : ILogin
    {
        HelpDeskDBEntities db1 = new HelpDeskDBEntities();
        public User GetinfoByUserCredentials(string Username, string Password)
        {
            User user = new User();
            HelpDesk roledata = db1.HelpDesks.Where(m => m.UserName == Username && m.Password == Password).FirstOrDefault();
            if (roledata != null)
            {
                user.UserName = roledata.UserName;
                user.Password = roledata.Password;
            }
            //roletable credentials = roledata.where(Roletable=>)
            return user;
        }
    }
}
