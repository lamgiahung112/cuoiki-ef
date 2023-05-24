using CUOIKI_EF.Enums;
using System;

namespace CUOIKI_EF.Factories
{
    public class EmployeeFactory
    {
        private static string CreateRandomID()
        {
            return "EMP" + new Random().Next();
        }

        public static Employee Create(string Name, string Address, EmployeeStatus status, string pass, string gender, Role role)
        {
            var emp = new Employee();
            emp.ID = CreateRandomID();
            emp.Name = Name;
            emp.Address = Address;
            emp.Birth = DateTime.Now;
            emp.EmployeeStatus = EnumMapper.mapToString(status);
            emp.Password = pass;
            emp.Gender = gender;
            emp.Role = EnumMapper.mapToString(role);
            return emp;
        }
    }
}
