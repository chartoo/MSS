using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSS.DB
{
    class Customer
    {
        ConnectionManager ConnectionManager = new ConnectionManager();
        SQLiteConnection con = ConnectionManager.con;
        string SELECT_ALL = @"SELECT * FROM customers ORDER BY id DESC";
        string INSERT = @"INSERT INTO customers(`name`,`gender`,`phone1`,`phone2`,`special`,`address`,`description`)
                        VALUES(@name,@gender,@phone1,@phone2,@special,@address,@description)";
        string GET_ONE = @"SELECT * FROM customers WHERE id=@id";
        string EDIT = @"UPDATE customers 
                        SET name=@name,gender=@gender,phone1=@phone1,phone2=@phone2,special=@special,address=@address,description=@description,updated_at=@updated_at
                        WHERE id=@id";
        string DELETE = @"DELETE FROM customers WHERE id=@id";
        string FILTER = @"SELECT * FROM customers WHERE name LIKE @name AND phone1 LIKE @phone order by name";

        public List<DO.Customer> ALL()
        {
            List<DO.Customer> customers = new List<DO.Customer>();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(SELECT_ALL, con);
                ConnectionManager.OpenConnection();
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    customers.Add(new DO.Customer()
                    {
                        Id = Convert.ToInt16(rdr["id"]),
                        Name = rdr["name"].ToString(),
                        Gender = Convert.ToInt16(rdr["gender"]),
                        Phone1 = rdr["phone1"].ToString(),
                        Phone2 = rdr["phone2"].ToString(),
                        Special = Convert.ToInt16(rdr["special"]),
                        Address = rdr["address"].ToString(),
                        Description = rdr["description"].ToString(),
                        Created_at = Convert.ToDateTime(rdr["created_at"]),
                        Updated_at = Convert.ToDateTime(rdr["updated_at"])
                    });
                }
                rdr.Close();
                ConnectionManager.CloseConnection();
                return customers;
            }
            catch (Exception e)
            {
                Console.WriteLine("System GET ALL Customers Error! \n", e);
                return customers;
            }
        }
        public Boolean STORE(DO.Customer customer)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(INSERT, con);
                ConnectionManager.OpenConnection();
                //@name,@gender,@phone1,@phone2,@special,@address,@description
                cmd.Parameters.AddWithValue("@name", customer.Name);
                cmd.Parameters.AddWithValue("@gender", customer.Gender);
                cmd.Parameters.AddWithValue("@phone1", customer.Phone1);
                cmd.Parameters.AddWithValue("@phone2", customer.Phone2);
                cmd.Parameters.AddWithValue("@special", customer.Special);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.Parameters.AddWithValue("@description", customer.Description);

                cmd.ExecuteNonQuery();
                ConnectionManager.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Store Customer Error! ", e);
                return false;
            }
        }
        public DO.Customer SHOW(int id)
        {
            DO.Customer customer = new DO.Customer();
            SQLiteCommand cmd = new SQLiteCommand(GET_ONE, con);
            ConnectionManager.OpenConnection();
            cmd.Parameters.AddWithValue("@id", id);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                customer.Id = Convert.ToInt16(rdr["id"]);
                customer.Name = rdr["name"].ToString();
                customer.Gender = Convert.ToInt16(rdr["gender"]);
                customer.Special = Convert.ToInt16(rdr["special"]);
                customer.Phone1 = rdr["phone1"].ToString();
                customer.Phone2 = rdr["phone2"].ToString();
                customer.Address = rdr["address"].ToString();
                customer.Description = rdr["description"].ToString();
            }
            rdr.Close();
            ConnectionManager.CloseConnection();
            return customer;
        }
        public Boolean UPDATE(int id, DO.Customer customer)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(EDIT, con);
                ConnectionManager.OpenConnection();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", customer.Name);
                cmd.Parameters.AddWithValue("@gender", customer.Gender);
                cmd.Parameters.AddWithValue("@phone1", customer.Phone1);
                cmd.Parameters.AddWithValue("@phone2", customer.Phone2);
                cmd.Parameters.AddWithValue("@special", customer.Special);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.Parameters.AddWithValue("@description", customer.Description);
                cmd.Parameters.AddWithValue("@updated_at", DateTime.Now.ToShortDateString());
                cmd.ExecuteNonQuery();
                ConnectionManager.CloseConnection();
                return true;
            } catch (Exception e)
            {
                Console.WriteLine("Customer UPdate Error !", e);
                return false;
            }
        }
        public Boolean DESTROY(int id)
        {
            if (id != 0)
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
                    Console.WriteLine("Customer Deleting Error! ", e);
                    return false;
                }
            }
            return false;
        }
        public List<DO.Customer> FILTER_SEARCH(string name,string phone)
        {
            List<DO.Customer> customers = new List<DO.Customer>();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(FILTER, con);
                ConnectionManager.OpenConnection();
                cmd.Parameters.AddWithValue("@name","%"+name+"%");
                cmd.Parameters.AddWithValue("@phone","%"+phone+"%");
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    customers.Add(new DO.Customer()
                    {
                        Id = Convert.ToInt16(rdr["id"]),
                        Name = rdr["name"].ToString(),
                        Gender = Convert.ToInt16(rdr["gender"]),
                        Phone1 = rdr["phone1"].ToString(),
                        Phone2 = rdr["phone2"].ToString(),
                        Special = Convert.ToInt16(rdr["special"]),
                        Address = rdr["address"].ToString(),
                        Description = rdr["description"].ToString(),
                        Created_at = Convert.ToDateTime(rdr["created_at"]),
                        Updated_at = Convert.ToDateTime(rdr["updated_at"])
                    });
                }
                    rdr.Close();
                    ConnectionManager.CloseConnection();
                    return customers;
            }
            catch (Exception e)
            {
                Console.WriteLine("Filter Search Customers Error! \n", e);
                return customers;
            }
        }
    }

}
