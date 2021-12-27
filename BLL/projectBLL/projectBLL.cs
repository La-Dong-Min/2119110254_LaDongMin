using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.projectDAL;
using DTO.projectDTO;

namespace BLL.projectBLL
{
    public class projectBLL
    {
        projectDAL dal = new projectDAL();
        public List<projectDTO> ReadCustomer()
        {
            List<projectDTO> lstCus = dal.ReadCustomer();

            return lstCus;
        }
        public void NewCustomer(projectDTO cus)
        {
            dal.NewCustomer(cus);
        }
        public void DeleteCustomer(projectDTO cus)
        {
            dal.DeleteCustomer(cus);
        }
        public void EditCustomer(projectDTO cus)
        {
            dal.EditCustomer(cus);
        }
    }
}
