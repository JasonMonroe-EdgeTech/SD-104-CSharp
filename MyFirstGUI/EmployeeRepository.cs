using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGUI
{
    class EmployeeRepository
    {
        MyDataModel _db = new MyDataModel();

        public List<Employee> GetEmployees()
        {
            return _db.Employees.ToList();
        }

        public void AddEmployee(Employee employee)
        {
            _db.Employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            _db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
