using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DB
{
    class Dashboard
    {
        ConnectionManager ConnectionManager = new ConnectionManager();
        SQLiteConnection con = ConnectionManager.con;
        //string SALE_INCOME = @"SELECT SUM(`payment`) AS grand FROM sales WHERE MONTH(`sale_date`)=MONTH( CURRENT_DATE )";
        //string SERVICE_INCOME = @"SELECT SUM(`payment`) AS grand FROM services WHERE MONTH(`return_date`)=MONTH( CURRENT_DATE )";
        //string CASHBOOK_INCOME = @"SELECT SUM(`total`) AS grand FROM cashbooks WHERE MONTH(`date`)=MONTH( CURRENT_DATE ) AND cash_type=0";
        //string CASHBOOK_EXPENSE = @"SELECT SUM(`total`) AS grand FROM cashbooks WHERE MONTH(`date`)=MONTH( CURRENT_DATE ) AND cash_type=1";

        string SALE_INCOME = @"SELECT SUM(`payment`) as total FROM sales where strftime(" + "'%Y-%m'" + ",sale_date) = strftime(" + "'%Y-%m'" + ",date('now')) group by strftime(" + "'%Y-%m'"+ ", sale_date) ";
        string SERVICE_INCOME = @"SELECT SUM(`payment`) as total FROM services where strftime(" + "'%Y-%m'" + ",return_date) = strftime(" + "'%Y-%m'" + ",date('now')) group by strftime(" + "' % m -% Y '" + ", return_date) ";
        string CASHBOOK_INCOME = @"SELECT SUM(`total`) as total FROM cashbooks where strftime(" + "'%Y-%m'" + ",date) = strftime(" + "'%Y-%m'" + ",date('now')) and cash_type=0 group by strftime(" + "' % m -% Y '" + ", date) ";
        string CASHBOOK_EXPENSE = @"SELECT SUM(`total`) as total FROM cashbooks where strftime(" + "'%Y-%m'" + ",date) = strftime(" + "'%Y-%m'" + ",date('now')) and cash_type=1 group by strftime(" + "' % m -% Y '" + ", date) ";

        public Double SaleIncome()
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(SALE_INCOME, con);
                ConnectionManager.OpenConnection();
                Double total = Convert.ToDouble(cmd.ExecuteScalar());
                ConnectionManager.CloseConnection();
                return total;
            }
            catch(Exception e)
            {
                return 0.0;
            }
            
        }
        public Double ServiceIncome()
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(SERVICE_INCOME, con);
                ConnectionManager.OpenConnection();
                Double total = Convert.ToDouble(cmd.ExecuteScalar());
                ConnectionManager.CloseConnection();
                return total;
            }
            catch(Exception e)
            {
                return 0.0;
            }
            
        }
        public Double CashbookIncome()
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(CASHBOOK_INCOME, con);
                ConnectionManager.OpenConnection();
                Double total = Convert.ToDouble(cmd.ExecuteScalar());
                ConnectionManager.CloseConnection();
                return total;
            }
            catch(Exception e)
            {
                return 0.0;
            }
        }
        public Double CashbookExpense()
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(CASHBOOK_EXPENSE, con);
                ConnectionManager.OpenConnection();
                Double total = Convert.ToDouble(cmd.ExecuteScalar());
                ConnectionManager.CloseConnection();
                return total;
            }
            catch(Exception e)
            {
                return 0.0;
            }
            
        }
    }
}
