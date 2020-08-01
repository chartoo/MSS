using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DB
{
    class Sale
    {
        ConnectionManager ConnectionManager = new ConnectionManager();
        SQLiteConnection con = ConnectionManager.con;
        string SELECT_ALL = @"SELECT * FROM sales ORDER BY created_at DESC";
        string INSERT = @"INSERT INTO sales(`user_id`,`customer_id`,`category_id`,`model`,`imei`,`mass`,`item`,`sale_date`,`total`,`payment`,`remain`,`remain_type`,`cleared`,`description`)
                        VALUES(@user_id,@customer_id,@category_id,@model,@imei,@mass,@item,@sale_date,@total,@payment,@remain,@remain_type,@cleared,@description)";
        string GET_ONE = @"SELECT * FROM sales WHERE id=@id";
        string EDIT = @"UPDATE sales 
                        SET user_id=@user_id,
                            customer_id=@customer_id,
                            category_id=@category_id,
                            model=@model,
                            imei=@imei,
                            mass=@mass,
                            item=@item,
                            sale_date=@sale_date,
                            total=@total,
                            payment=@payment,
                            remain=@remain,
                            remain_type=@remain_type,
                            cleared=@cleared,
                            description=@description,
                            updated_at=@updated_at
                            WHERE id=@id";
        string DELETE = @"DELETE FROM sales WHERE id=@id";
        string FILTER = @"SELECT * FROM sales WHERE sale_date>=@from_date and sale_date<=@to_date ";


        public List<DO.Sale> ALL()
        {
            List<DO.Sale> sales = new List<DO.Sale>();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(SELECT_ALL, con);
                ConnectionManager.OpenConnection();
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    sales.Add(new DO.Sale()
                    {
                        Id = Convert.ToInt16(rdr["id"]),
                        UserId =Convert.ToInt16(rdr["user_id"]),
                        CustomerId = Convert.ToInt16(rdr["customer_id"]),
                        CategoryId = Convert.ToInt16(rdr["category_id"]),
                        Model = rdr["model"].ToString(),
                        Imei = rdr["imei"].ToString(),
                        Mass = Convert.ToInt16(rdr["mass"]),
                        Item = Convert.ToInt16(rdr["item"]),
                        SaleDate =Convert.ToDateTime(rdr["sale_date"]),
                        Total=Convert.ToDouble(rdr["total"]),
                        Payment=Convert.ToDouble(rdr["payment"]),
                        Remain=Convert.ToDouble(rdr["remain"]),
                        RemainType=Convert.ToInt16(rdr["remain_type"]),
                        Description = rdr["description"].ToString(),
                        Cleared=Convert.ToInt16(rdr["cleared"]),
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
        public Boolean STORE(DO.Sale sale)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(INSERT, con);
                ConnectionManager.OpenConnection();
                //@user_id,@customer_id,@category_id,@model,@imei,@mass,@item,@sale_date,@total,@payment,@remain,@remain_type,@cleared,@description
                cmd.Parameters.AddWithValue("@user_id", sale.UserId);
                cmd.Parameters.AddWithValue("@customer_id", sale.CustomerId);
                cmd.Parameters.AddWithValue("@category_id", sale.CategoryId);
                cmd.Parameters.AddWithValue("@model", sale.Model);
                cmd.Parameters.AddWithValue("@imei", sale.Imei);
                cmd.Parameters.AddWithValue("@mass", sale.Mass);
                cmd.Parameters.AddWithValue("@item", sale.Item);
                cmd.Parameters.AddWithValue("@sale_date", sale.SaleDate);
                cmd.Parameters.AddWithValue("@total", sale.Total);
                cmd.Parameters.AddWithValue("@payment", sale.Payment);
                cmd.Parameters.AddWithValue("@remain", sale.Remain);
                cmd.Parameters.AddWithValue("@remain_type", sale.RemainType);
                cmd.Parameters.AddWithValue("@cleared", sale.Cleared);
                cmd.Parameters.AddWithValue("@description", sale.Description);
                cmd.ExecuteNonQuery();
                ConnectionManager.CloseConnection();
                return true;
        }
            catch (Exception e)
            {
                Console.WriteLine("Store Sale Record Error! ", e);
                return false;
            }
}
        public DO.Sale SHOW(int id)
        {
            DO.Sale sale = new DO.Sale();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(GET_ONE, con);
                ConnectionManager.OpenConnection();
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    sale.Id = Convert.ToInt16(rdr["id"]);
                    sale.UserId = Convert.ToInt16(rdr["user_id"]);
                    sale.CustomerId = Convert.ToInt16(rdr["customer_id"]);
                    sale.CategoryId = Convert.ToInt16(rdr["category_id"]);
                    sale.Model = rdr["model"].ToString();
                    sale.Imei = rdr["imei"].ToString();
                    sale.Mass = Convert.ToInt16(rdr["mass"]);
                    sale.Item = Convert.ToInt16(rdr["item"]);
                    sale.SaleDate = Convert.ToDateTime(rdr["sale_date"]);
                    sale.Total = Convert.ToDouble(rdr["total"]);
                    sale.Payment = Convert.ToDouble(rdr["payment"]);
                    sale.Remain = Convert.ToDouble(rdr["remain"]);
                    sale.RemainType = Convert.ToInt16(rdr["remain_type"]);
                    sale.Description = rdr["description"].ToString();
                    sale.Cleared = Convert.ToInt16(rdr["cleared"]);
                    sale.Created_at = Convert.ToDateTime(rdr["created_at"]);
                    sale.Updated_at = Convert.ToDateTime(rdr["updated_at"]);
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("Show Sale Error : ", e);
            }

            return sale;
        }

        public Boolean UPDATE(DO.Sale sale)
        {
            SQLiteCommand cmd = new SQLiteCommand(EDIT, con);
            ConnectionManager.OpenConnection();
            //@user_id,@customer_id,@category_id,@model,@imei,@mass,@item,@sale_date,@total,@payment,@remain,@remain_type,@cleared,@description
            cmd.Parameters.AddWithValue("@id", sale.Id);
            cmd.Parameters.AddWithValue("@user_id", sale.UserId);
            cmd.Parameters.AddWithValue("@customer_id", sale.CustomerId);
            cmd.Parameters.AddWithValue("@category_id", sale.CategoryId);
            cmd.Parameters.AddWithValue("@model", sale.Model);
            cmd.Parameters.AddWithValue("@imei", sale.Imei);
            cmd.Parameters.AddWithValue("@mass", sale.Mass);
            cmd.Parameters.AddWithValue("@item", sale.Item);
            cmd.Parameters.AddWithValue("@sale_date", sale.SaleDate);
            cmd.Parameters.AddWithValue("@total", sale.Total);
            cmd.Parameters.AddWithValue("@payment", sale.Payment);
            cmd.Parameters.AddWithValue("@remain", sale.Remain);
            cmd.Parameters.AddWithValue("@remain_type", sale.RemainType);
            cmd.Parameters.AddWithValue("@cleared", sale.Cleared);
            cmd.Parameters.AddWithValue("@description", sale.Description);
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
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return true;
            }catch(Exception e)
            {
                Console.WriteLine("Error Delete ", e);
                return false;
            }
            
        }

        public List<DO.Sale> SEARCH(DateTime fromDate,DateTime toDate,int all,int cleared,int notCleared)
        {
            //@"SELECT * FROM sales WHERE created_at>=@from_date and created_at<=to_date ORDER BY created_at DESC";
            List<DO.Sale> sales = new List<DO.Sale>();
            try
            {
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
                    sales.Add(new DO.Sale()
                    {
                        Id = Convert.ToInt16(rdr["id"]),
                        UserId = Convert.ToInt16(rdr["user_id"]),
                        CustomerId = Convert.ToInt16(rdr["customer_id"]),
                        CategoryId = Convert.ToInt16(rdr["category_id"]),
                        Model = rdr["model"].ToString(),
                        Imei = rdr["imei"].ToString(),
                        Mass = Convert.ToInt16(rdr["mass"]),
                        Item = Convert.ToInt16(rdr["item"]),
                        SaleDate = Convert.ToDateTime(rdr["sale_date"]),
                        Total = Convert.ToDouble(rdr["total"]),
                        Payment = Convert.ToDouble(rdr["payment"]),
                        Remain = Convert.ToDouble(rdr["remain"]),
                        RemainType = Convert.ToInt16(rdr["remain_type"]),
                        Description = rdr["description"].ToString(),
                        Cleared = Convert.ToInt16(rdr["cleared"]),
                        Created_at = Convert.ToDateTime(rdr["created_at"]),
                        Updated_at = Convert.ToDateTime(rdr["updated_at"])
                    });
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("System GET Sale Search records Error! \n", e);
            }
            return sales;
        }
    }
}
