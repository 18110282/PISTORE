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
    class BUS_OrderItem
    {
        private DAL_OrderItem dal_OrderItem;
        public BUS_OrderItem()
        {
            dal_OrderItem = new DAL_OrderItem();
        }

        public DataTable getAllOrderItem()
        {
            return dal_OrderItem.getAllOrderItem();
        }
        public DataTable getOrderItemByID(int ID)
        {
            return dal_OrderItem.getOrderItemByIDInDB(ID);
        }

        public bool insertOrderItem(DTO_OrderItem dto_OrderItem)
        {
            return dal_OrderItem.insertOrderItemInDB(dto_OrderItem);
        }
        public bool updateOrderItem(DTO_OrderItem dto_OrderItem)
        {
            return dal_OrderItem.updateOrderItemInDB(dto_OrderItem);
        }
        public bool deleteOrderItem(int ID)
        {
            return dal_OrderItem.deleteOrderItemInDB(ID);
        }
    }
}
