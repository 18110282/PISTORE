using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStore.DTO
{
    class DTO_Employee
    {
        private int ID;
        private String name;
        private String email;
        private String phone;
        private String address;
        private int salary;
        private DateTime hireDate;

        public int ID1 { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public int Salary { get => salary; set => salary = value; }
        public DateTime HireDate { get => hireDate; set => hireDate = value; }
    }
}
