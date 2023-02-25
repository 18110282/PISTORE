using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStore.DTO
{
    class DTO_OrderItem
    {
        private int ID;
        private int orderID;
        private int productID;
        private int quantity;

        public int ID1 { get => ID; set => ID = value; }
        public int OrderID { get => orderID; set => orderID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
