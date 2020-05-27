 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DO
{
    class Sale
    {
        int id, userId, customerId, categoryId, cleared,mass,item,remainType;
        string model, imei, description;
        DateTime saleDate, created_at, updated_at;
        double total, payment, remain;

        public int CategoryId
        {
            get
            {
                return categoryId;
            }

            set
            {
                categoryId = value;
            }
        }

        public int Cleared
        {
            get
            {
                return cleared;
            }

            set
            {
                cleared = value;
            }
        }

        public DateTime Created_at
        {
            get
            {
                return created_at;
            }

            set
            {
                created_at = value;
            }
        }

        public int CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Imei
        {
            get
            {
                return imei;
            }

            set
            {
                imei = value;
            }
        }

        public int Item
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
            }
        }

        public int Mass
        {
            get
            {
                return mass;
            }

            set
            {
                mass = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public double Payment
        {
            get
            {
                return payment;
            }

            set
            {
                payment = value;
            }
        }

        public double Remain
        {
            get
            {
                return remain;
            }

            set
            {
                remain = value;
            }
        }

        public int RemainType
        {
            get
            {
                return remainType;
            }

            set
            {
                remainType = value;
            }
        }

        public DateTime SaleDate
        {
            get
            {
                return saleDate;
            }

            set
            {
                saleDate = value;
            }
        }

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public DateTime Updated_at
        {
            get
            {
                return updated_at;
            }

            set
            {
                updated_at = value;
            }
        }

        public int UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }
    }
}
