using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO.projectDTO;

namespace DAL.projectDAL
{
    public class projectDAL:DBConnection
    {
        public List<projectDTO> ReadCustomer()
        {

            {

                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from CONGNO", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                List<projectDTO> lstCus = new List<projectDTO>();

                while (reader.Read())
                {
                    projectDTO cus = new projectDTO();
                    cus.Ma = reader["makhachhang"].ToString();
                    cus.Name = reader["tenkhachhang"].ToString();
                    cus.Phone = reader["sodienthoai"].ToString();
                    cus.Sono = (decimal.Parse(reader["sotienno"].ToString()));
                    lstCus.Add(cus);
                }
                conn.Close();
                return lstCus;

            }
        }
        public void EditCustomer(projectDTO cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update CongNo set name = @tenkhachhang, phone =@sodienthoai , sono = @sotienno where id = @makhachhang", conn);
            cmd.Parameters.Add(new SqlParameter("@makhachhang", cus.Ma));
            cmd.Parameters.Add(new SqlParameter("@tenkhachhang", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@sodienthoai", cus.Phone));
            cmd.Parameters.Add(new SqlParameter("@sotienno", cus.Sono));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteCustomer(projectDTO cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from CongNo where id = @makhachhang", conn);
            cmd.Parameters.Add(new SqlParameter("@makhachhang", cus.Ma));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewCustomer(projectDTO cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into CongNo values(@makhachhang,@tenkhachhang,@sodienthoai,@sotienno)", conn);
            cmd.Parameters.Add(new SqlParameter("@makhachhang", cus.Ma));
            cmd.Parameters.Add(new SqlParameter("@tenkhachhang", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@sodienthoai", cus.Phone));
            cmd.Parameters.Add(new SqlParameter("@sotienno", cus.Sono));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
