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
    class BUS_Product
    {
        private DAL_Product dal_Product;
        public BUS_Product()
        {
            dal_Product = new DAL_Product();
        }

        public DataTable getAllProduct()
        {
            return dal_Product.getAllProduct();
        }
        public DataTable getProductByID(int ID)
        {
            return dal_Product.getProductByIDInDB(ID);
        }

        public bool insertProduct(DTO_Product dto_Product)
        {
            return dal_Product.insertProductInDB(dto_Product);
        }
        public bool updateProduct(DTO_Product dto_Product)
        {
            return dal_Product.updateProductInDB(dto_Product);
        }
        public bool deleteProduct(int ID)
        {
            return dal_Product.deleteProductInDB(ID);
        }
    }
}
