using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DB
{
    class User
    {
        ConnectionManager ConnectionManager = new ConnectionManager();
        SQLiteConnection con = ConnectionManager.con;
        string SELECT_ALL = @"SELECT * FROM users ORDER BY id DESC";
        string INSERT = @"INSERT INTO users(`name`,`gender`,`phone`,`password`,`role`)
                        VALUES(@name,@gender,@phone,@password,@role)";
        string GET_ONE = @"SELECT * FROM customers WHERE id=@id";
        string EDIT = @"UPDATE customers 
                        SET name=@name,gender=@gender,phone1=@phone1,phone2=@phone2,special=@special,address=@address,description=@description,updated_at=@updated_at
                        WHERE id=@id";
        string DELETE = @"DELETE FROM customers WHERE id=@id";
        string FILTER = @"SELECT * FROM customers WHERE name LIKE @name AND phone1 LIKE @phone order by name";

        public List<DO.User> ALL()
        {
            List<DO.User> users = new List<DO.User>();
            //try
            //{
            SQLiteCommand cmd = new SQLiteCommand(SELECT_ALL, con);
            ConnectionManager.OpenConnection();
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                users.Add(new DO.User()
                {
                    Id = Convert.ToInt16(rdr["id"]),
                    Name = rdr["name"].ToString(),
                    Gender = Convert.ToInt16(rdr["gender"]),
                    Phone = rdr["phone"].ToString(),
                    Password = rdr["password"].ToString(),
                    Role = rdr["role"].ToString(),
                    Created_at =Convert.ToDateTime(rdr["created_at"]),
                        Updated_at = Convert.ToDateTime(rdr["updated_at"])
                    });
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
                return users;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("System GET ALL User  Error! \n", e);
            //    return users;
            //}
        }
    }
}
