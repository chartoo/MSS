using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DB
{
    class Service
    {
        ConnectionManager ConnectionManager = new ConnectionManager();
        SQLiteConnection con = ConnectionManager.con;
        string SELECT_ALL = @"SELECT * FROM services ORDER BY id DESC";
        string INSERT = @"INSERT INTO services(`user_id`,`customer_id`,`category_id`,`model`,`imei`,`return_date`,`total`,`payment`,`remain`,`cleared`,`remain_type`,`remark`,`description`)
                        VALUES(@user_id,@customer_id,@category_id,@model,@imei,@return_date,@total,@payment,@remain,@cleared,@remain_type,@remark,@description)";
        string GET_ONE = @"SELECT * FROM services WHERE id=@id";
        string EDIT = @"UPDATE services 
                        SET name=@name,updated_at=@updated_at
                        WHERE id=@id";
        string DELETE = @"DELETE FROM categories WHERE id=@id";
        string FILTER = @"SELECT * FROM categories WHERE name LIKE @name order by name";


        public List<DO.Service> ALL()
        {
            List<DO.Service> sales = new List<DO.Service>();
            //try
            //{
                SQLiteCommand cmd = new SQLiteCommand(SELECT_ALL, con);
                ConnectionManager.OpenConnection();
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    sales.Add(new DO.Service()
                    {
                        Id = Convert.ToInt16(rdr["id"]),
                        UserId = Convert.ToInt16(rdr["user_id"]),
                        CustomerId = Convert.ToInt16(rdr["customer_id"]),
                        CategoryId = Convert.ToInt16(rdr["category_id"]),
                        Model = rdr["model"].ToString(),
                        Imei = rdr["imei"].ToString(),
                        ReturnDate = Convert.ToDateTime(rdr["return_date"]),
                        Total = Convert.ToDouble(rdr["total"]),
                        Payment = Convert.ToDouble(rdr["payment"]),
                        Remain = Convert.ToDouble(rdr["remain"]),
                        Cleared = Convert.ToInt16(rdr["cleared"]),
                        RemainType = Convert.ToInt16(rdr["remain_type"]),
                        Remark = rdr["remark"].ToString(),
                        Description = rdr["description"].ToString(),
                        Created_at = Convert.ToDateTime(rdr["created_at"]),
                        Updated_at = Convert.ToDateTime(rdr["updated_at"])
                    });
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
        //}
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("System GET ALL Sale records Error! \n", e);
        //    }
            return sales;
        }
        public Boolean STORE(DO.Service service)
        {
            //try
            //{
                SQLiteCommand cmd = new SQLiteCommand(INSERT, con);
                ConnectionManager.OpenConnection();
                //(@user_id,@customer_id,@category_id,@model,@imei,@return_date,@total,@payment,@remain,@cleared,@remain_type,@remark,@description)
                cmd.Parameters.AddWithValue("@user_id", service.UserId);
                cmd.Parameters.AddWithValue("@customer_id", service.CustomerId);
                cmd.Parameters.AddWithValue("@category_id", service.CategoryId);
                cmd.Parameters.AddWithValue("@model", service.Model);
                cmd.Parameters.AddWithValue("@imei", service.Imei);
                cmd.Parameters.AddWithValue("@return_date", service.ReturnDate);
                cmd.Parameters.AddWithValue("@total", service.Total);
                cmd.Parameters.AddWithValue("@payment", service.Payment);
                cmd.Parameters.AddWithValue("@remain", service.Remain);
                cmd.Parameters.AddWithValue("@cleared", service.Cleared);
                cmd.Parameters.AddWithValue("@remain_type", service.RemainType);
            cmd.Parameters.AddWithValue("@remark", service.Remark);
            cmd.Parameters.AddWithValue("@description", service.Description);
                cmd.ExecuteNonQuery();
                ConnectionManager.CloseConnection();
                return true;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Store Service Record Error! ", e);
            //    return false;
            //}
        }
        public DO.Customer SHOW(int id)
        {
            DO.Customer customer = new DO.Customer();
            SQLiteCommand cmd = new SQLiteCommand(GET_ONE, con);
            ConnectionManager.OpenConnection();
            cmd.Parameters.AddWithValue("@id", id);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                customer.Id = Convert.ToInt16(rdr["id"]);
                customer.Name = rdr["name"].ToString();
                customer.Gender = Convert.ToInt16(rdr["gender"]);
                customer.Special = Convert.ToInt16(rdr["special"]);
                customer.Phone1 = rdr["phone1"].ToString();
                customer.Phone2 = rdr["phone2"].ToString();
                customer.Address = rdr["address"].ToString();
                customer.Description = rdr["description"].ToString();
            }
            rdr.Close();
            ConnectionManager.CloseConnection();
            return customer;
        }

    }
}
