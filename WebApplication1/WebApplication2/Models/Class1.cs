using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JoingData { get; set; }
        public int age { get; set; }

        public List<Employee1> GetEmployeesData()
        {
            return new List<Employee1>()
            {
                new Employee1()
                {
                    Id=1,
                    Name="anudeep",
                    JoingData=DateTime.Now.ToString(),
                    age=25
                },
                new Employee1()
                {
                    Id=12,
                    Name="sandeep",
                    JoingData=DateTime.Now.ToString(),
                    age=26
                },
                new Employee1()
                {
                    Id=3,
                    Name="mandeep",
                    JoingData=DateTime.Now.ToString(),
                    age=24
                },
            };
        }

    }
}