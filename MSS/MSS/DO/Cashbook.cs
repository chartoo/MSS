using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DO
{
    class Cashbook
    {
        int id, reason, cashType;
        string casher, voucher, description;
        double total;
        DateTime date, created_at, updated_at;

        public int Id { get => id; set => id = value; }
        public int Reason { get => reason; set => reason = value; }
        public int CashType { get => cashType; set => cashType = value; }
        public string Casher { get => casher; set => casher = value; }
        public string Voucher { get => voucher; set => voucher = value; }
        public string Description { get => description; set => description = value; }
        public double Total { get => total; set => total = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
