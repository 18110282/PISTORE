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
    class BUS_Client
    {
        private DAL_Client dal_Client;
        public BUS_Client()
        {
            dal_Client = new DAL_Client();
        }

        public DataTable getAllClient()
        {
            return dal_Client.getAllClient();
        }
        public DataTable getClientByID(int ID)
        {
            return dal_Client.getClientByIDInDB(ID);
        }

        public bool insertClient(DTO_Client dto_Client)
        {
            return dal_Client.insertClientInDB(dto_Client);
        }
        public bool updateClient(DTO_Client dto_Client)
        {
            return dal_Client.updateClientInDB(dto_Client);
        }
        public bool deleteClient(int ID)
        {
            return dal_Client.deleteClientInDB(ID);
        }
    }
}
