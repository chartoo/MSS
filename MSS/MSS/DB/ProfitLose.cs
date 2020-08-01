using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DB
{
    class ProfitLose
    {
        ConnectionManager ConnectionManager = new ConnectionManager();
        SQLiteConnection con = ConnectionManager.con;
        string SELECT_ALL = @"SELECT * FROM profitloses ORDER BY id DESC";
        string INSERT = @"INSERT INTO profitloses(`year`,`month`,`total_income`,`total_expense`,`total_profit`,`total_lose`)
                        VALUES(@year,@month,@total_income,@total_expense,@total_profit,@total_lose)";
        
        string DELETE = @"DELETE FROM profitloses WHERE id=@id";
        string GET_YEARS = @"SELECT DISTINCT YEAR(created) FROM table";

        public List<DO.ProfitLose> ALL()
        {
            List<DO.ProfitLose> profitloses = new List<DO.ProfitLose>();
            //try
            //{
                SQLiteCommand cmd = new SQLiteCommand(SELECT_ALL, con);
                ConnectionManager.OpenConnection();
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    profitloses.Add(new DO.ProfitLose()
                    {
                        Id = Convert.ToInt16(rdr["id"]),
                        Year = Convert.ToInt32(rdr["year"]),
                        Month = Convert.ToInt32(rdr["month"]),
                        TotalIncome = Convert.ToDouble(rdr["total_income"]),
                        TotalExpense = Convert.ToDouble(rdr["total_expense"]),
                        TotalProfit = Convert.ToDouble(rdr["total_profit"]),
                        TotoalLose = Convert.ToDouble(rdr["total_lose"]),
                        Created_at = Convert.ToDateTime(rdr["created_at"]),
                        Updated_at = Convert.ToDateTime(rdr["updated_at"])
                    });
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("System GET ALL Profit&Lose records Error! \n", e);
            //}
            return profitloses;
        }
        public Boolean STORE(DO.ProfitLose profitlose)
        {
            SQLiteCommand cmd = new SQLiteCommand(INSERT, con);
            ConnectionManager.OpenConnection();
            //@year,@month,@total_income,@total_expense,@total_profit,@total_lose
            cmd.Parameters.AddWithValue("@year", profitlose.Year);
            cmd.Parameters.AddWithValue("@month", profitlose.Month);
            cmd.Parameters.AddWithValue("@total_income", profitlose.TotalIncome);
            cmd.Parameters.AddWithValue("@total_expense", profitlose.TotalExpense);
            cmd.Parameters.AddWithValue("@total_profit", profitlose.TotalProfit);
            cmd.Parameters.AddWithValue("@total_lose", profitlose.TotoalLose);
            cmd.ExecuteNonQuery();
            ConnectionManager.CloseConnection();
            return true;
        }
    }
}
