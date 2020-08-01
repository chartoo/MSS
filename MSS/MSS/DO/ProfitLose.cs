using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DO
{
    class ProfitLose
    {
        int id,year, month;
        double totalIncome, totalExpense, totalProfit, totoalLose;
        DateTime created_at, updated_at;

        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public double TotalIncome { get => totalIncome; set => totalIncome = value; }
        public double TotalExpense { get => totalExpense; set => totalExpense = value; }
        public double TotalProfit { get => totalProfit; set => totalProfit = value; }
        public double TotoalLose { get => totoalLose; set => totoalLose = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
        public int Id { get => id; set => id = value; }
    }
}
