﻿using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Service
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeModel> GetAllEmployee();
        EmployeeModel GetEmployeeById(Guid id);
        EmployeeModel GetEmployeeByEmail(string email);
        EmployeeModel GetEmployeeByUserName(string userName);
        string GetRoleNameByRoleId(Guid roleId);


        void AddEmployee(Guid RoleId, EmployeeModel emp);
        void UpdateEmployee(EmployeeModel emp);
        void DeleteEmployee(EmployeeModel link);

        bool EmpExists(Guid id);
        bool ComparePassword(string hashedPassword, string curPassword);
        bool Save();
    }
}
