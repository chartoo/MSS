using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DB
{
    class Configuration
    {
        ConnectionManager ConnectionManager = new ConnectionManager();
        SQLiteConnection con = ConnectionManager.con;
        string SELECT_ALL = @"SELECT * FROM config ORDER BY id DESC";
        string INSERT = @"INSERT INTO config(`my_id`,`name`,`person`,`email`,`phone`,`address`)
                        VALUES(@my_id,@name,@person,@email,@phone,@address)";
        string GET_ONE = @"SELECT * FROM config WHERE my_id=@my_id";
        string EDIT = @"UPDATE config 
                        SET name=@name,updated_at=@updated_at,person=@person,email=@email,phone=@phone,address=@address
                        WHERE my_id=@my_id";
        string SET_CODE = @"UPDATE config SET code=@code WHERE my_id=@my_id";
        public DO.Configuraion GET()
        {
            DO.Configuraion configs = new DO.Configuraion() ;
            //try
            //{
                SQLiteCommand cmd = new SQLiteCommand(SELECT_ALL, con);
                ConnectionManager.OpenConnection();
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                configs.Id = Convert.ToInt16(rdr["id"]);
                configs.MyId = rdr["my_id"].ToString();
                configs.Name = rdr["name"].ToString();
                configs.Person = rdr["person"].ToString();
                configs.Phone = rdr["phone"].ToString();
                configs.Email = rdr["email"].ToString();
                configs.Address = rdr["address"].ToString();
                configs.Code = rdr["code"].ToString();
                configs.Created_at = Convert.ToDateTime(rdr["created_at"]);
                configs.Updated_at = Convert.ToDateTime(rdr["updated_at"]);
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Select stystem config Error! ", e);
            //}
            return configs;
        }
        public Boolean STORE(DO.Configuraion config)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(INSERT, con);
                ConnectionManager.OpenConnection();
                //@my_id,@name,@person,@email,@phone,@address
                cmd.Parameters.AddWithValue("@my_id", config.MyId);
                cmd.Parameters.AddWithValue("@name", config.Name);
                cmd.Parameters.AddWithValue("@person", config.Person);
                cmd.Parameters.AddWithValue("@email", config.Email);
                cmd.Parameters.AddWithValue("@phone", config.Phone);
                cmd.Parameters.AddWithValue("@address", config.Address);
                cmd.ExecuteNonQuery();
                ConnectionManager.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Store Config Error! ", e);
                return false;
            }
        }
        public Boolean UPDATE_CODE(string my_id,string code)
        {
            //try
            //{
                SQLiteCommand cmd = new SQLiteCommand(SET_CODE, con);
                ConnectionManager.OpenConnection();
                //@my_id,@code
                cmd.Parameters.AddWithValue("@my_id", my_id);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.ExecuteNonQuery();
                ConnectionManager.CloseConnection();
                return true;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Store Config Error! ", e);
            //    return false;
            //}
        }
    }
}
