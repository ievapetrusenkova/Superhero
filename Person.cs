﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{

    internal class Person
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            
        }
        
        public void PrintInfo(string info)
        {
            Console.WriteLine(info);
        }
    }
}
