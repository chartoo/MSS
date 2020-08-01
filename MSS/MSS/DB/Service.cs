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
                        SET 
                        user_id=@user_id,
                        customer_id=@customer_id,
                        category_id=@category_id,
                        model=@model,
                        imei=@imei,
                        return_date=@return_date,
                        total=@total,
                        payment=@payment,
                        remain=@remain,
                        cleared=@cleared,
                        remain_type=@remain_type,
                        remark=@remark,
                        description=@description,
                        updated_at=@updated_at
                        WHERE id=@id";
        string DELETE = @"DELETE FROM services WHERE id=@id";
        string FILTER = @"SELECT * FROM services WHERE return_date>=@from_date and return_date<=@to_date ";


        public List<DO.Service> ALL()
        {
            List<DO.Service> sales = new List<DO.Service>();
            try
            {
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
        }
            catch (Exception e)
            {
                Console.WriteLine("System GET ALL Sale records Error! \n", e);
            }
            return sales;
        }
        public Boolean STORE(DO.Service service)
        {
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine("Store Service Record Error! ", e);
                return false;
            }
        }
        public DO.Service SHOW(int id)
        {
            DO.Service service = new DO.Service();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(GET_ONE, con);
                ConnectionManager.OpenConnection();
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    service.Id = Convert.ToInt16(rdr["id"]);
                    service.UserId = Convert.ToInt16(rdr["user_id"]);
                    service.CustomerId = Convert.ToInt16(rdr["customer_id"]);
                    service.CategoryId = Convert.ToInt16(rdr["category_id"]);
                    service.Model = rdr["model"].ToString();
                    service.Imei = rdr["imei"].ToString();
                    service.ReturnDate = Convert.ToDateTime(rdr["return_date"]);
                    service.Total = Convert.ToDouble(rdr["total"]);
                    service.Payment = Convert.ToDouble(rdr["payment"]);
                    service.Remain = Convert.ToDouble(rdr["remain"]);
                    service.RemainType = Convert.ToInt16(rdr["remain_type"]);
                    service.Remark = rdr["remark"].ToString();
                    service.Description = rdr["description"].ToString();
                    service.Cleared = Convert.ToInt16(rdr["cleared"]);
                    service.Created_at = Convert.ToDateTime(rdr["created_at"]);
                    service.Updated_at = Convert.ToDateTime(rdr["updated_at"]);
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("Show Service Error : ", e);
            }

            return service;
        }

        public Boolean UPDATE(DO.Service service)
        {
            SQLiteCommand cmd = new SQLiteCommand(EDIT, con);
            ConnectionManager.OpenConnection();
            //(@user_id,@customer_id,@category_id,@model,@imei,@return_date,@total,@payment,@remain,@cleared,@remain_type,@remark,@description)
            cmd.Parameters.AddWithValue("@id", service.Id);
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
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            cmd.ExecuteNonQuery();
            ConnectionManager.CloseConnection();
            return true;
        }
        public Boolean DESTROY(int id)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(DELETE, con);
                ConnectionManager.OpenConnection();
                 cmd.Parameters.AddWithValue("@id",id);
                cmd.ExecuteNonQuery();
                ConnectionManager.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<DO.Service> SEARCH(DateTime fromDate, DateTime toDate, int all, int cleared, int notCleared)
        {
            //@"SELECT * FROM sales WHERE created_at>=@from_date and created_at<=to_date ORDER BY created_at DESC";
            List<DO.Service> services = new List<DO.Service>();
            //try
            //{
                SQLiteCommand cmd;
                if (cleared == 1)
                {
                    FILTER = FILTER + " and cleared=1";
                    cmd = new SQLiteCommand(FILTER, con);
                }
                if (notCleared == 1)
                {
                    FILTER = FILTER + " and cleared=0";
                    cmd = new SQLiteCommand(FILTER, con);
                }
                cmd = new SQLiteCommand(FILTER, con);
                cmd.Parameters.AddWithValue("@from_date", fromDate);
                cmd.Parameters.AddWithValue("@to_date", toDate);

                ConnectionManager.OpenConnection();
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    services.Add(new DO.Service()
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
            //catch (Exception e)
            //{
            //    Console.WriteLine("System GET Sale Search records Error! \n", e);
            //}
            return services;
        }
    }
}
