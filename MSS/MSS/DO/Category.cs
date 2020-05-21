using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DO
{
    class Category
    {
        int id;
        string name;
        DateTime created_at, updated_at;
        List<DO.Category> categories;
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

        internal List<Category> Categories
        {
            get
            {
                return categories;
            }

            set
            {
                categories = value;
            }
        }
    }
}
