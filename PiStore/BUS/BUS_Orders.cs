using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PiStore.DTO;
using PiStore.DAL;
using System.Data;

namespace PiStore.BUS
{
    class BUS_Orders
    {
        private DAL_Orders dal_Orders;
        public BUS_Orders()
        {
            dal_Orders = new DAL_Orders();
        }

        public DataTable getAllOrders()
        {
            return dal_Orders.getAllOrders();
        }
        public DataTable getOrdersByID(int ID)
        {
            return dal_Orders.getOrdersByIDInDB(ID);
        }

        public bool insertOrders(DTO_Orders dto_Orders)
        {
            return dal_Orders.insertOrdersInDB(dto_Orders);
        }
        public bool updateOrders(DTO_Orders dto_Orders)
        {
            return dal_Orders.updateOrdersInDB(dto_Orders);
        }
        public bool deleteOrders(int ID)
        {
            return dal_Orders.deleteOrdersInDB(ID);
        }
    }
}
