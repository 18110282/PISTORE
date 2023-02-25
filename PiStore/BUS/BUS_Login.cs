using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PiStore.DAL;

namespace PiStore.BUS
{
    class BUS_Login
    {
        private DAL_Login dal_Login;

        public BUS_Login()
        {
            dal_Login = new DAL_Login();
        }

        public int checkLogin(String username, String password)
        {
            return dal_Login.checkLoginInDB(username, password);
        }
    }
}
