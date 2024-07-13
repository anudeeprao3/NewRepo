using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace WebApplication15.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public List<string> DepartmentNames
        {
            get
            {
                List<string> dnames = new List<string>();
                dnames.Add("ECE");
                dnames.Add("CSE");
                dnames.Add("IT");
                return dnames;
            }
        }
        public string Gender { get; set; }
        public List<string> Hobbies
        {
            get
            {
                List<string> hobby = new List<string>();
                hobby.Add("cricket");
                hobby.Add("tennis");
                hobby.Add("football");
                return hobby;
            }
        }
        public string salary { get; set; }
        //below 2 propertes used for storing the values and above list item is used for binding
        public string Hobby { get; set; }
        public string DeptName { get; set; }
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
            string query = "insert into Register values('" + obj.EmployeeId+ "','"+obj.EmployeeName+ "','"+obj.DeptName+ "','"+obj.Gender+ "','"+obj.Hobby+ "','"+obj.salary+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            //execute the query
            cmd.ExecuteNonQuery();
            //close the connection
            con.Close();
        }
        
    }
}