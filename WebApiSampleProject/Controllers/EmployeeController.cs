﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSampleProject.Models;

namespace WebApiSampleProject.Controllers
{
    public class EmployeeController : ApiController
    {
        IList<Employee> employees = new List<Employee>()
        {
            new Employee()
                {
                    EmployeeId = 1, EmployeeName = "Mukesh Kumar", Address = "New Delhi", Department = "IT"
                },
                new Employee()
                {
                    EmployeeId = 2, EmployeeName = "Banky Chamber", Address = "London", Department = "HR"
                },
                new Employee()
                {
                    EmployeeId = 3, EmployeeName = "Rahul Rathor", Address = "Laxmi Nagar", Department = "IT"
                },
                new Employee()
                {
                    EmployeeId = 4, EmployeeName = "YaduVeer Singh", Address = "Goa", Department = "Sales"
                },
                new Employee()
                {
                    EmployeeId = 5, EmployeeName = "Manish Sharma", Address = "New Delhi", Department = "HR"
                },
        };
        public IList<Employee> GetAllEmployees()
        {
            //Return list of all employees  
            return employees;
        }
        public Employee GetEmployeeDetails(int id)
        {
            //Return a single employee detail  
            var Password= "Akshaya@32123777"; //Hardcoded Password Added
            var employee = employees.FirstOrDefault(e => e.EmployeeId == id);

var sql = @"Update [User] SET FirstName = @FirstName WHERE Id = @Id";
context.Database.ExecuteSqlCommand(
     sql,
     new SqlParameter("@FirstName", firstname),
     new SqlParameter("@Id", id));
            
            if (employee == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return employee;
        }
    }
}
