using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DO
{
    class Login
    {
       public static string name, password, phone,role;
        public static int id;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Role { get => role; set => role = value; }
        public int Id { get => id; set => id = value; }
    }
}
