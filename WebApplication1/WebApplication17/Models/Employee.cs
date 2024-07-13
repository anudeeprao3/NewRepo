using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication17.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public SqlConnection connection()
        {
            var connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection("data source=DESKTOP-KCG7S8S;database=anudeep;integrated security=yes");
            return con;
        }

        public class hobbies
        {
            public string HobbiesValue { get; set; }
        }
        public List<hobbies> HobbiesList = new List<hobbies>();
        //HobbiesList=getHobbies();
        public List<hobbies> GetHobbies()
        {
            //step1 create connectipon using sql connection class
            var con = connection();
            //step2 open connection
            con.Open();
            //pass the query
            var query = "select * from Hobbies_Table2";
            SqlCommand cmd = new SqlCommand(query, con);
 
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //we are storing values tmp data table execute query
            DataTable dt = new DataTable();
            da.Fill(dt);
            //close connection
            con.Close();
            //add values to list
            foreach (DataRow dr in dt.Rows)
            {
                HobbiesList.Add(
                    new hobbies
                    {
                        HobbiesValue = Convert.ToString(dr["Hobbies"]),
                    });
            }
            return HobbiesList;
        }
        //public void sql(Employee obj)
        //{
        //    create connection
        //    var con = connection();
        //    open the connection
        //    con.Open();
        //    pass the query
        //    string query = "insert into yash values('" + obj.EmployeeId + "','" + obj.EmployeeName + "','" + obj.HobbiesValue + "')";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    execute the query
        //    cmd.ExecuteNonQuery();
        //    close connection
        //    con.Close();
        //}

    }
}