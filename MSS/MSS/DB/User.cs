using MSS.DO;
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
        DataEncryptor keys = new DataEncryptor();
        ConnectionManager ConnectionManager = new ConnectionManager();
        SQLiteConnection con = ConnectionManager.con;
        string SELECT_ALL = @"SELECT * FROM users ORDER BY id DESC";
        string INSERT = @"INSERT INTO users(`name`,`gender`,`phone`,`password`,`role`)
                        VALUES(@name,@gender,@phone,@password,@role)";
        string GET_ONE = @"SELECT * FROM users WHERE id=@id";
        string EDIT = @"UPDATE users 
                        SET name=@name,gender=@gender,phone=@phone,role=@role,password=@password,updated_at=@updated_at
                        WHERE id=@id";
        string DELETE = @"DELETE FROM users WHERE id=@id";
        string FILTER = @"SELECT * FROM customers WHERE name LIKE @name AND phone1 LIKE @phone order by name";
        string LOGIN = @"SELECT * FROM users WHERE password=@password";

        public List<DO.User> ALL()
        {
            List<DO.User> users = new List<DO.User>();
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine("System GET ALL User  Error! \n", e);
                return users;
            }
        }

        public Boolean STORE(DO.User user)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(INSERT, con);
                ConnectionManager.OpenConnection();
                //@name,@gender,@phone,@password,@role
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@gender", user.Gender);
                cmd.Parameters.AddWithValue("@phone", user.Phone);
                cmd.Parameters.AddWithValue("@password", keys.EncryptString(user.Password));
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.ExecuteNonQuery();
                ConnectionManager.CloseConnection();
                return true;
            }catch(Exception e)
            {
                Console.WriteLine("User Storing Error !",e);
                return false;
            }
        }
        public DO.User SHOW(int id)
        {
            DO.User user = new DO.User();
            try
            {
                ConnectionManager.OpenConnection();
                SQLiteCommand cmd = new SQLiteCommand(GET_ONE, con);
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    user.Id = Convert.ToInt16(rdr["id"]);
                    user.Name = rdr["name"].ToString();
                    user.Phone = rdr["phone"].ToString();
                    user.Gender = Convert.ToInt16(rdr["gender"]);
                    user.Password = keys.DecryptString(rdr["password"].ToString());
                    user.Role = rdr["role"].ToString();
                    user.Created_at = Convert.ToDateTime(rdr["created_at"]);
                    user.Updated_at = Convert.ToDateTime(rdr["updated_at"]);
                }
                rdr.Close();
                ConnectionManager.OpenConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("GET ONE User Error! ", e);
            }
            return user;
        }
        public Boolean UPDATE(int id,DO.User user)
        {
            SQLiteCommand cmd = new SQLiteCommand(EDIT, con);
            ConnectionManager.OpenConnection();
            //@name,@gender,@phone,@password,@role
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@gender", user.Gender);
            cmd.Parameters.AddWithValue("@phone", user.Phone);
            cmd.Parameters.AddWithValue("@password", keys.EncryptString(user.Password));
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now.ToShortDateString());
            cmd.ExecuteNonQuery();
            ConnectionManager.CloseConnection();
            return true;
        }
        public Boolean DESTROY(int id)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(DELETE, con);
                ConnectionManager.OpenConnection();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                ConnectionManager.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("User Deleting Error! ", e);
                return false;
            }
        }
        public DO.Login Authenticate(string password)
        {
            DO.Login login = new DO.Login();
            SQLiteCommand cmd = new SQLiteCommand(LOGIN, con);
            ConnectionManager.OpenConnection();
            cmd.Parameters.AddWithValue("@password", keys.EncryptString(password));
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                login.Name = rdr["name"].ToString();
                login.Role = rdr["role"].ToString();
                login.Phone = rdr["phone"].ToString();
                login.Password = rdr["password"].ToString();
            }
            rdr.Close();
             ConnectionManager.CloseConnection();
            return login;
        }
    }
}
