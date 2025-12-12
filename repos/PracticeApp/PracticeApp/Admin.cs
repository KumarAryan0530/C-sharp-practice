using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class Admin
    {
        public int Id;
        public string Name;
    public Admin(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

    }
    class Manager: Admin
    {
        public double Salary;
        public Manager(int id, string name, double salary) : base(id, name)
        {
            this.Salary = salary;
        }
    }
    class Employees : Manager
    {
        public double Incentive;
        public Employees(int id, string name, double salary, double incentive) : base(id, name, salary)
        {
            this.Incentive = incentive;
        }
        internal void Display()
        {
            Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}, Incentive: {3}", Id, Name, Salary, Incentive);
        }
    }
}

