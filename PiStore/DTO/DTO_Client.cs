using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStore.DTO
{
    class DTO_Client
    {
        private int ID;
        private String name;
        private String email;
        private String phone;
        private String address;

        public int ID1 { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
    }
}
