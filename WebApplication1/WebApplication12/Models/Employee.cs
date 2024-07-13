   using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;

namespace WebApplication12.Models
{
    public class Employee
    {
        public int eno { get; set; }
        public string ename { get; set; } 

        public SqlConnection connection()
        {
            var connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection("data source=DESKTOP-KCG7S8S;database=anudeep;integrated security=yes");
            return con;
        }
        public List<Employee> GetAllEmployes()
        {
            //step2-the below method is helpfull for getting connection string from web.config
            var con = connection();
            List<Employee> EmpList = new List<Employee>();
            //step3-pass the query
            var query = "select * from details";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //were storing values tmp data table eqecute query
            DataTable dt = new DataTable();
            da.Fill(dt);
            //add values to list
            foreach (DataRow dr in dt.Rows)
            {
                EmpList.Add(new Employee
                {
                    eno = Convert.ToInt32(dr["eno"]),
                    ename = Convert.ToString(dr["ename"]),
                });
            }
            return EmpList;
        }
        public void createuser(Employee obj)
        {
            //step2-create coneection
            var con = connection();
            //step3-open connection
            con.Open();
            //step4-pass the query
            string query = "insert into details values('" + obj.eno + "','" + obj.ename + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            //step5-ezecute the query
            cmd.ExecuteNonQuery();
            //step6-close the connection
            con.Close();
        }
        public void deleteuser(int id)
        {
            //create conection
            var con = connection();
            //open connection
            con.Open();
            //pass the query
            string query = "delete from details where eno=" + id;
            SqlCommand cmd = new SqlCommand(query, con);
            //execute query
            cmd.ExecuteNonQuery();
            //close
            con.Close();
        }
        public void edituser(Employee obj)
        {
            //create connection
           var con=connection();
            //open connection
            con.Open();
            //pass the query
            string query = "update details set ename=" + "'" + obj.ename + "'" + "where eno=" +"'"+ obj.eno+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
       

        
    }
}