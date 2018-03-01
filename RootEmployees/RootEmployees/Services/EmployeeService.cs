using RootEmployees.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RootEmployees.Services
{
    public class EmployeeService
    {
        public List<Employee> EmplyeeList()
        {
            var EmployeeList = new List<Employee>
            {
                new Employee
                {
                    FullName = "Marwen Guidara",
                    Email = "m.guidara@root.sa",
                    PhoneNumber = "+21624422356",
                    Departement = "Services"
                },
                new Employee
                {
                    FullName = "Mahdi Sassi",
                    Email = "m.sassi@root.sa",
                    PhoneNumber = "+216",
                    Departement = "Services"
                },
                new Employee
                {
                    FullName = "Mohamed",
                    Email = "m.elleuch@root.sa",
                    PhoneNumber = "+216",
                    Departement = "Backend"
                },
                new Employee
                {
                    FullName = "Salwa souissi",
                    Email = "s.souissi@root.sa",
                    PhoneNumber = "+216",
                    Departement = "Frontend"
                },
                new Employee
                {
                    FullName = "Aiman Slamah",
                    Email = "aiman@root.sa",
                    PhoneNumber = "+21654338053",
                    Departement = "Services"
                }
            };

            return EmployeeList;
        }
    }
}
