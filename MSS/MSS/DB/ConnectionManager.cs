using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace MSS.DB
{
    class ConnectionManager
    {
        public static SQLiteConnection con;
        public ConnectionManager()
        {
            con = new SQLiteConnection(@"Data Source=database.sqlite3");
            if(!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("./database.sqlite3");
                System.Console.WriteLine("Database File Created");
            }
        }
        public void OpenConnection()
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            Console.WriteLine(con.State);
        }
        public void CloseConnection()
        {
            if (con.State!=System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
        }
        public void GetAllUsers()
        {
            string get = "select * from users";
            OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand(get, con);
            cmd.ExecuteNonQuery();
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                Console.WriteLine("Name : "+rdr["name"].ToString());
            }
            rdr.Close();
            CloseConnection();
        }
        public void AddUser()
        {
            string insert = "insert into users ('name','phone','role','password') values(@name,@phone,@role,@password)";
            SQLiteCommand cmd = new SQLiteCommand(insert, con);
            OpenConnection();
            cmd.Parameters.AddWithValue("@name", "Aung");
            cmd.Parameters.AddWithValue("@phone", "094847323");
            cmd.Parameters.AddWithValue("@role", "Admin");
            cmd.Parameters.AddWithValue("@password", "12345");
            cmd.ExecuteNonQuery();
            CloseConnection();
            Console.ReadKey();
        }
    }
}
