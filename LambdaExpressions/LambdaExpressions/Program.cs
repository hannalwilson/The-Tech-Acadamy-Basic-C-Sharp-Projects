using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee {FirstName="Michael", LastName="Scott", ID=1},
                new Employee {FirstName="Dwight", LastName="Shrute", ID=2},
                new Employee {FirstName="Joe", LastName="Jonas", ID=3},
                new Employee {FirstName="Pam", LastName="Beesly", ID=4},
                new Employee {FirstName="Jim", LastName="Halpert", ID=5},
                new Employee {FirstName="Stanley", LastName="Hudson", ID=6 },
                new Employee {FirstName="Creed", LastName="Bratton", ID=7},
                new Employee {FirstName="Joe", LastName="Mantegna", ID=8},
                new Employee {FirstName="Andy", LastName="Bernard", ID=9},
                new Employee {FirstName="Oscar", LastName="Martinez", ID=10},
                new Employee {FirstName="Kevin", LastName="Malone", ID=11},
            };

            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName=="Joe")
                {
                    joes.Add(employee);
                }
            }

            List<Employee> joes2 = employees.FindAll(x => x.FirstName == "Joe").ToList();

            List<Employee> ids = employees.FindAll(x => x.ID > 5).ToList();

            Console.WriteLine("Employee list of Joes generated from foreach loop:");
            foreach (Employee employee in joes)
            {
                Console.WriteLine("Employee: {0} {1} {2}", employee.ID, employee.FirstName, employee.LastName);
            }
            Console.ReadLine();

            Console.WriteLine("Employee list of Joes generated from lambda expression:");
            foreach (Employee employee in joes2)
            {
                Console.WriteLine("Employee: {0} {1} {2}", employee.ID, employee.FirstName, employee.LastName);
            }
            Console.ReadLine();

            Console.WriteLine("Employee list with id greather than 5 generated from lambda expression:");
            foreach (Employee employee in ids)
            {
                Console.WriteLine("Employee: {0} {1} {2}", employee.ID, employee.FirstName, employee.LastName);
            }
            Console.ReadLine();
        }
    }
    
}
