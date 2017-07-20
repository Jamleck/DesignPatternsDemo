using System;
using System.Collections.Generic;
using DesignPatternsDemo.Core;

namespace DesignPatternsDemo.CompositePattern
{
    public class Employee
    {
        public Employee(string name, string department, int salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
            Subordinates = new List<Employee>();
        }

        public List<Employee> Subordinates { get; }
        public string Name { get; }
        public string Department { get; }
        public int Salary { get; }

        public void Add(Employee e)
        {
            Subordinates.Add(e);
        }

        public void Remove(Employee e)
        {
            Subordinates.Remove(e);
        }

        public override string ToString()
        {
            return "Employee :[" + Name + ", Department:, " + Department + ", Salary: " + Salary + "] ";
        }
    }


    public class CompositePatternDemo : IDemo
    {

        public CompositePatternDemo()
        {
            
        }


        public void Demo()
        {
            Employee ceo = new Employee("John", "CEO", 30000);
            Employee headSales = new Employee("Robert", "Head Sales", 20000);
            Employee headMarketing = new Employee("Michel", "Head Marketing", 20000);
            Employee clerk1 = new Employee("Laura", "Marketing", 10000);
            Employee clerk2 = new Employee("Bob", "Marketing", 10000);
            Employee salesExecutive1 = new Employee("Richard", "Sales", 10000);
            Employee salesExecutive2 = new Employee("Rob", "Sales", 10000);

            ceo.Add(headSales);
            ceo.Add(headMarketing);

            headMarketing.Add(clerk1);
            headMarketing.Add(clerk2);

            Console.WriteLine(ceo);

            foreach (var headEmployee in ceo.Subordinates)
            {
                Console.WriteLine("\t" + headEmployee);

                foreach (var employee in headEmployee.Subordinates)
                {
                    Console.WriteLine("\t\t" + employee);
                }
            }
        }
    }
}