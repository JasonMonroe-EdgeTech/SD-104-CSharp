namespace MyFirstGUI
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyDataModel : DbContext
    {
   
        public MyDataModel()
            : base("name=MyDataModel")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee() { }

        public Employee(string name)
        {
            Name = name;
        }
    }
}