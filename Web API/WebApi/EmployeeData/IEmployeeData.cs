
using System;
using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.EmployeeData
{
   public  interface IEmployeeData
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(Guid Id);

        Employee AddEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        Employee EditEmployee(Employee employee);
    }
}
