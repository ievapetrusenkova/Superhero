using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    
    internal class Hero : Person
    {
        
        public string Surname;
        public string Nickname { get; set; }
        public string Name { get; set; }

        private int HeroID;
 
        private int DeedTime;

        public Hero()
        {
            Name = "Tony";
            Surname = "Stark";
            Nickname = "IronMan";
            HeroID = 5;
            DeedTime = 10;
        }

        public Hero (string name, string surname, string nickname, int heroID, int deedTime) : base(name, surname)
        {
            this.Name = name; this.Surname = surname; this.Nickname = nickname;
            this.HeroID = heroID; this.DeedTime = deedTime;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" {Name} {Surname} >> {Nickname} >>\n Hero ID: {HeroID}");
            Console.WriteLine($" {Nickname} is a hero!\n Hero deed time is {DeedTime} h.");
        }
       
        public int CalculateLevel()
        {
            int level = 0;
            if (DeedTime < 20)
            {
                level = 1;
            }
            if (DeedTime >= 20 && DeedTime <= 40)
            {
                level = 2;
            }
            if (DeedTime > 40)
            {
                level = 3;
            }
            return level;
        }
        
    }

   
}
