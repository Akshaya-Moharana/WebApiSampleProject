using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSampleProject.Models
{
    var scriptURL = $"https://{Request.Host}/script.js";
    public class Employee
    {
        public int EmployeeId
        {
            get;
            set;
        }
        public string EmployeeName
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string Department
        {
            get;
            set;
        }
    }
}  
