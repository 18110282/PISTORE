using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStore.DTO
{
    class DTO_Bill
    {
        private int ID;
        private int orderID;
        private int clientID;
        private int employeeID;
        private DateTime billDate;
        private int totalPrice;

        public int ID1 { get => ID; set => ID = value; }
        public int OrderID { get => orderID; set => orderID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public DateTime BillDate { get => billDate; set => billDate = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
