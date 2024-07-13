using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{ 
   public class Employee2
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string email { get; set; }
    public string JoingData { get; set; }

    public List<Employee2> GetEmployeesData()
    {
        var employee = new List<Employee2>()
            {
                new Employee2()
                {
                    Id=1,
                    Name="anudeep",
                    email="anudeep@gmail.com",
                    JoingData=DateTime.Now.ToString(),
                    
                },
                new Employee2()
                {
                    Id=12,
                    Name="sandeep",
                    email="sandeep@gmail.com",
                    JoingData=DateTime.Now.ToString()
                },
                new Employee2()
                {
                    Id=3,
                    Name="mandeep",
                    email="mandeep@gmail.com",
                    JoingData=DateTime.Now.ToString()
                },
            };
        return employee;
    }
}
}