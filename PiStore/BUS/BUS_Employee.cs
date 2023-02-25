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
    class BUS_Employee
    {
        private DAL_Employee dal_Employee;
        public BUS_Employee()
        {
            dal_Employee = new DAL_Employee();
        }

        public DataTable getAllEmployee()
        {
            return dal_Employee.getAllEmployee();
        }
        public DataTable getEmployeeByID(int ID)
        {
            return dal_Employee.getEmployeeByIDInDB(ID);
        }

        public bool insertEmployee(DTO_Employee dto_Employee)
        {
            return dal_Employee.insertEmployeeInDB(dto_Employee);
        }
        public bool updateEmployee(DTO_Employee dto_Employee)
        {
            return dal_Employee.updateEmployeeInDB(dto_Employee);
        }
        public bool deleteEmployee(int ID)
        {
            return dal_Employee.deleteEmployeeInDB(ID);
        }
    }
}
