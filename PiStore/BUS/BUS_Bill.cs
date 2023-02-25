using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PiStore.DTO;
using PiStore.DAL;

namespace PiStore.BUS
{
    class BUS_Bill
    {
        private DAL_Bill dal_Bill;
        public BUS_Bill()
        {
            dal_Bill = new DAL_Bill();
        }

        public bool insertBill(DTO_Bill dto_Bill)
        {
            return dal_Bill.insertBillInDB(dto_Bill);
        }
    }
}
