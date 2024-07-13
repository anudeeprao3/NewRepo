using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication14.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string Course { get; set; }

        public SqlConnection connection()
        {
            var connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection("data source=DESKTOP-KCG7S8S;database=anudeep;integrated security=yes");
            return con;
        }
        public void AddEmployee(Employee obj)
        {
            //create connection
            var con = connection();
            //open the connection
            con.Open();
            //pass the query
            string query = "insert into Employee_Registration values('"+obj.Id+"','"+obj.Name+"','"+obj.City+"','"+obj.Gender+"','"+obj.Course+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            //execute the query
            cmd.ExecuteNonQuery();
            //close connection
            con.Close();
        }
    } 
}














