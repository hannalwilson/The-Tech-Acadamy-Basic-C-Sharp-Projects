﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name:  {0} {1}", firstName, lastName);
        }
        public void Quit()
        {
            Console.WriteLine("So sorry for your loss, this employee has quit.");
        }
    }
}
