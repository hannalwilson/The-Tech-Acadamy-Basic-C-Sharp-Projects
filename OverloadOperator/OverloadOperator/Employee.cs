using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }

        public static bool operator== (Employee emp1, Employee emp2)
        {
            bool isEqual = (emp1.ID == emp2.ID);
            return isEqual;
        }

        public static bool operator != (Employee emp1, Employee emp2)
        {
            bool notEqual = (emp1.ID != emp2.ID);
            return notEqual;
        }
    }
}
