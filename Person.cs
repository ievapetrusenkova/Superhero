using System;
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
        public string Nickname { get; set; }
        public int Age { get; set; }
        public List<string> PowerList { get; set; }

        public Person(string name, string surname, string nickname, int age, List<string> powerList)
        {
            this.Name = name;
            this.Surname = surname;
            this.Nickname = nickname;
            this.Age = age;
            this.PowerList = powerList;
        }

        public void PrintInfo(string info)
        {
            Console.WriteLine(info);
        }
        public virtual void PrintGeneralInfo()
        {
            Console.WriteLine("*********************GENERAL INFO******************");
            Console.WriteLine($"Hero: {Nickname}");
            Console.WriteLine($"Age:  {Age} year old");
            Console.WriteLine($"SuperPersons powers2d array: \n ");
            for (int i = 0; i < PowerList.Count; i++)
            {
                Console.WriteLine($"{i}. {PowerList[i]} ");
            }
        }
    }
}
