using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DO
{
    class Configuraion
    {
        int id;
        string myId, name, person, phone, email, address, code;
        DateTime created_at, updated_at;

        public int Id { get => id; set => id = value; }
        public string MyId { get => myId; set => myId = value; }
        public string Name { get => name; set => name = value; }
        public string Person { get => person; set => person = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Code { get => code; set => code = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }

        public bool CheckForInternetConnection()
        {
           return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            //try
            //{
            //using (var client = new WebClient())
            //    using (client.OpenRead("https://www.google.com/"))
            //        return true;
            //}
            //catch
            //{
            //    return false;
            //}
        }
    }
}
