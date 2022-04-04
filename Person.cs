using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{

    internal class Person
    {
        /*public enum HeroOrVillain { Hero, Villain };
        public enum DeedOrCrime { DeedTime, CrimeTime };*/

        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            
        }
        public Person()
        {
            Name = "Wade";
            Surname = "Wilson";

        }
        public void PrintInfo(string info)
        {
            Console.WriteLine(info);
        }
    }
}
