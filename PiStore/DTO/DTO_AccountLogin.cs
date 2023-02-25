using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStore.DTO
{
    class DTO_AccountLogin
    {
        private int ID;
        private String username;
        private String password;

        public int ID1 { get => ID; set => ID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
