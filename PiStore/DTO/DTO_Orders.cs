using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStore.DTO
{
    class DTO_Orders
    {
        private int ID;
        private int clientID;
        private int employeeID;
        private DateTime orderDate;
        private int totalPrice;

        public int ID1 { get => ID; set => ID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
