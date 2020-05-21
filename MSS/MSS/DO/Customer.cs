using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DO
{
    class Customer
    {
         int id, gender, special;
         string name, phone1, phone2, address, description;
         DateTime created_at, updated_at;
        List<DO.Customer> customers = new List<DO.Customer>();

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

        public int Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public int Special
        {
            get
            {
                return special;
            }

            set
            {
                special = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Phone1
        {
            get
            {
                return phone1;
            }

            set
            {
                phone1 = value;
            }
        }

        public string Phone2
        {
            get
            {
                return phone2;
            }

            set
            {
                phone2 = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
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

        internal List<Customer> Customers
        {
            get
            {
                return customers;
            }

            set
            {
                customers = value;
            }
        }
    }
}
