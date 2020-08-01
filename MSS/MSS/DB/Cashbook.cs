using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DB
{
    class Cashbook
    {
        ConnectionManager ConnectionManager = new ConnectionManager();
        SQLiteConnection con = ConnectionManager.con;
        string SELECT_ALL = @"SELECT * FROM cashbooks ORDER BY id DESC";
        string INSERT = @"INSERT INTO cashbooks(`reason`,`cash_type`,`casher`,`voucher`,`description`,`total`,`date`)
                        VALUES(@reason,@cash_type,@casher,@voucher,@description,@total,@date)";
        string GET_ONE = @"SELECT * FROM cashbooks WHERE id=@id";
        string EDIT = @"UPDATE cashbooks 
                        SET casher=@casher,
                            voucher=@voucher,
                            description=@description,
                            total=@total,
                            date=@date,
                            updated_at=@updated_at
                            WHERE id=@id";
        string DELETE = @"DELETE FROM cashbooks WHERE id=@id";
        string FILTER = @"SELECT * FROM cashbooks WHERE date>=@from_date and date<=@to_date ";

        public List<DO.Cashbook> ALL()
        {
            List<DO.Cashbook> cashbooks = new List<DO.Cashbook>();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(SELECT_ALL, con);
                ConnectionManager.OpenConnection();
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cashbooks.Add(new DO.Cashbook()
                    {
                        Id = Convert.ToInt16(rdr["id"]),
                        Reason = Convert.ToInt32(rdr["reason"]),
                        CashType = Convert.ToInt32(rdr["cash_type"]),
                        Casher = rdr["casher"].ToString(),
                        Voucher = rdr["voucher"].ToString(),
                        Description = rdr["description"].ToString(),
                        Total = Convert.ToDouble(rdr["total"]),
                        Date = Convert.ToDateTime(rdr["date"]),
                        Created_at = Convert.ToDateTime(rdr["created_at"]),
                        Updated_at = Convert.ToDateTime(rdr["updated_at"])
                    });
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("System GET ALL cashbooks records Error! \n", e);
            }
            return cashbooks;
        }
        public Boolean STORE(DO.Cashbook cashbook)
        {
            SQLiteCommand cmd = new SQLiteCommand(INSERT, con);
            ConnectionManager.OpenConnection();
            //@reason,@cash_type,@casher,@voucher,@description,@total,@date
            cmd.Parameters.AddWithValue("@reason", cashbook.Reason);
            cmd.Parameters.AddWithValue("@cash_type", cashbook.CashType);
            cmd.Parameters.AddWithValue("@casher", cashbook.Casher);
            cmd.Parameters.AddWithValue("@voucher", cashbook.Voucher);
            cmd.Parameters.AddWithValue("@description", cashbook.Description);
            cmd.Parameters.AddWithValue("@total", cashbook.Total);
            cmd.Parameters.AddWithValue("@date", cashbook.Date);
            cmd.ExecuteNonQuery();
            ConnectionManager.CloseConnection();
            return true;
        }
        public DO.Cashbook SHOW(int id)
        {
            DO.Cashbook cashbook = new DO.Cashbook();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(GET_ONE, con);
                ConnectionManager.OpenConnection();
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cashbook.Id = Convert.ToInt16(rdr["id"]);
                    cashbook.Reason = Convert.ToInt32(rdr["reason"]);
                    cashbook.CashType = Convert.ToInt32(rdr["cash_type"]);
                    cashbook.Casher = rdr["casher"].ToString();
                    cashbook.Voucher = rdr["voucher"].ToString();
                    cashbook.Description = rdr["description"].ToString();
                    cashbook.Total = Convert.ToDouble(rdr["total"]);
                    cashbook.Date = Convert.ToDateTime(rdr["date"]);
                    cashbook.Created_at = Convert.ToDateTime(rdr["created_at"]);
                    cashbook.Updated_at = Convert.ToDateTime(rdr["updated_at"]);
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
        }
            catch (Exception e)
            {
                Console.WriteLine("Show Sale Error : ", e);
            }

            return cashbook;
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
            }
            catch(Exception e)
            {
                Console.WriteLine("Error Delete ", e);
                return false;
            }
        }
        public Boolean UPDATE(DO.Cashbook cashbook)
        {
            SQLiteCommand cmd = new SQLiteCommand(EDIT, con);
            ConnectionManager.OpenConnection();
            //@casher,@voucher,@description,@total,@date
            cmd.Parameters.AddWithValue("@id", cashbook.Id);
            cmd.Parameters.AddWithValue("@casher", cashbook.Casher);
            cmd.Parameters.AddWithValue("@voucher", cashbook.Voucher);
            cmd.Parameters.AddWithValue("@description", cashbook.Description);
            cmd.Parameters.AddWithValue("@total", cashbook.Total);
            cmd.Parameters.AddWithValue("@date", cashbook.Date);
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            cmd.ExecuteNonQuery();
            ConnectionManager.CloseConnection();
            return true;
        }
        public List<DO.Cashbook> FILTER_SEARCH(DateTime fromDate,DateTime toDate,Boolean all,Boolean income,Boolean expense)
        {
            List<DO.Cashbook> cashbooks = new List<DO.Cashbook>();
            try
            {
                if (!all)
                {
                    if (income)
                        FILTER += " and cash_type=0 ";
                    if (expense)
                        FILTER += " and cash_type=1 ";
                }
                
                FILTER += " ORDER BY date DESC";
                SQLiteCommand cmd = new SQLiteCommand(FILTER, con);
                cmd.Parameters.AddWithValue("@from_date", fromDate);
                cmd.Parameters.AddWithValue("@to_date", toDate);
                ConnectionManager.OpenConnection();
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cashbooks.Add(new DO.Cashbook()
                    {
                        Id = Convert.ToInt16(rdr["id"]),
                        Reason = Convert.ToInt32(rdr["reason"]),
                        CashType = Convert.ToInt32(rdr["cash_type"]),
                        Casher = rdr["casher"].ToString(),
                        Voucher = rdr["voucher"].ToString(),
                        Description = rdr["description"].ToString(),
                        Total = Convert.ToDouble(rdr["total"]),
                        Date = Convert.ToDateTime(rdr["date"]),
                        Created_at = Convert.ToDateTime(rdr["created_at"]),
                        Updated_at = Convert.ToDateTime(rdr["updated_at"])
                    });
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("System GET Filter Search cashbooks records Error! \n", e);
            }
            return cashbooks;
        }
    }
}
