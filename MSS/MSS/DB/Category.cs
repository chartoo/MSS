using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DB
{
    class Category
    {
        ConnectionManager ConnectionManager = new ConnectionManager();
        SQLiteConnection con = ConnectionManager.con;
        string SELECT_ALL = @"SELECT * FROM categories ORDER BY id DESC";
        string INSERT = @"INSERT INTO categories(`name`)
                        VALUES(@name)";
        string GET_ONE = @"SELECT * FROM categories WHERE id=@id";
        string EDIT = @"UPDATE categories 
                        SET name=@name,updated_at=@updated_at
                        WHERE id=@id";
        string DELETE = @"DELETE FROM categories WHERE id=@id";
        string FILTER = @"SELECT * FROM categories WHERE name LIKE @name order by name";


        //Start  Function for DB
        public List<DO.Category> ALL()
        {
            List<DO.Category> categories = new List<DO.Category>();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(SELECT_ALL, con);
                ConnectionManager.OpenConnection();
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    categories.Add(new DO.Category()
                    {
                        Id = Convert.ToInt16(rdr["id"]),
                        Name = rdr["name"].ToString(),
                        Created_at = Convert.ToDateTime(rdr["created_at"])
                    });
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("Select All Categories Error! ", e);
            }
            return categories;
        }
        public Boolean STORE(DO.Category category)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(INSERT, con);
                ConnectionManager.OpenConnection();
                //@name
                cmd.Parameters.AddWithValue("@name", category.Name);
                cmd.ExecuteNonQuery();
                ConnectionManager.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Store Cateogry Error! ", e);
                return false;
            }
        }
        public DO.Category SHOW(int id)
        {
            DO.Category category = new DO.Category();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(GET_ONE, con);
                ConnectionManager.OpenConnection();
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    category.Id = Convert.ToInt16(rdr["id"]);
                    category.Name = rdr["name"].ToString();
                    category.Created_at = Convert.ToDateTime(rdr["created_at"]);
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("Select All Categories Error! ", e);
            }
            return category;
        }
        public Boolean UPDATE(int id, DO.Category category)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(EDIT, con);
                ConnectionManager.OpenConnection();
                //@name,@id
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", category.Name);
                cmd.Parameters.AddWithValue("@updated_at", DateTime.Now.ToShortDateString());
                cmd.ExecuteNonQuery();
                ConnectionManager.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Update Cateogry Error! ", e);
                return false;
            }
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
                Console.WriteLine("Category Deleting Error! ", e);
                return false;
            }
        }
        public List<DO.Category> FILTER_SEARCH(string name)
        {
            List<DO.Category> categories = new List<DO.Category>();
            //try
            //{
            SQLiteCommand cmd = new SQLiteCommand(FILTER, con);
            ConnectionManager.OpenConnection();
            cmd.Parameters.AddWithValue("@name", "%" + name + "%");
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                categories.Add(new DO.Category()
                {
                    Id = Convert.ToInt16(rdr["id"]),
                    Name = rdr["name"].ToString(),
                    Created_at = Convert.ToDateTime(rdr["created_at"])
                });
            }
            return categories;
        }
    }

}
