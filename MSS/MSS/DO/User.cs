using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DO
{
    class User
    {
        int id, gender;
        string name, phone, password,role;
        DateTime created_at, updated_at;

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
        public string Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
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
    }
}
