using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class Company
    {
        public string Name { get; set; }
        public string HQAddress { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Company(string name, string address)
        {
            Name = name;
            HQAddress = address;
        }

        public void AddEmployee(Employee emp)
        {
            Employees.Add(emp);
        }
    }
}
