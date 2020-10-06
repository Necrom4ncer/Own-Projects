using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_Army_App
{
    public class UsArmyDB
    {
        SqlConnection connection;


        public bool OpenConnection()
        {
            try
            {
                connection = new SqlConnection("Server=(local);Database=US_Army;Integrated Security=true");
                connection.Open();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                if (connection != null)
                    connection.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public List<Soldier> SelectAllSoldiers()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Soldiers";
            List<Soldier> soldiers = new List<Soldier>();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Soldier s = new Soldier();
                s.id = Convert.ToInt32(reader["id"]);
                s.FirstName = reader["FirstName"].ToString();
                s.LastName = reader["LastName"].ToString();
                s.Age = Convert.ToInt32(reader["Age"]);
                s.Salary = Convert.ToDouble(reader["Salary"]);
                soldiers.Add(s);
            }
            reader.Close();
            return soldiers;
        }
        public List<Department> SelectAllDepartments()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from Departments";
            List<Department> deps = new List<Department>();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Department dep = new Department();
                dep.id = Convert.ToInt32(reader["id"]);
                dep.Name = reader["Name"].ToString();
                dep.Budget = Convert.ToDouble(reader["Budget"]);
                dep.NumberOfBatallions = Convert.ToInt32(reader["NumOfBatalions"]);
                deps.Add(dep);
            }
            reader.Close();
            return deps;
        }
        public List<Rank> SelectAllRanks()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from Ranks";
            List<Rank> ranks = new List<Rank>();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Rank r = new Rank();
                r.id = Convert.ToInt32(reader["id"]);
                r.Name = reader["Name"].ToString();
                ranks.Add(r);
            }
            reader.Close();
            return ranks;
        }
        public List<Comander> SelectAllComanders()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from Comanders";
            List<Comander> coms = new List<Comander>();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Comander c = new Comander();
                c.id = Convert.ToInt32(reader["id"]);
                c.FirstName = reader["FirstName"].ToString();
                c.LastName = reader["LastName"].ToString();
                c.Age = Convert.ToInt32(reader["Age"]);
                c.Salary = Convert.ToDouble(reader["Salary"]);
                coms.Add(c);
            }
            reader.Close();
            return coms;
        }
        public List<Weapon> SelectAllWeapons()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from Weapons";
            List<Weapon> weps = new List<Weapon>();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Weapon w = new Weapon();
                w.id = Convert.ToInt32(reader["id"]);
                w.Name = reader["Name"].ToString();
                w.Caliber = Convert.ToDouble(reader["Caliber"]);
                weps.Add(w);
            }
            reader.Close();
            return weps;

        }
      

    }
}
