using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    
    internal class Hero
    {
        
        private string surname;
        public string nickname { get; set; }
        public string name { get; internal set; }

        private int heroID;
 
        private int deedTime;

        public Hero()
        {
            name = "Tony";
            surname = "Stark";
            nickname = "IronMan";
            heroID = 5;
            deedTime = 10;
        }

        public Hero (string name, string surname, string nickname, int heroID, int deedTime)
        {
            this.name = name; this.surname = surname; this.nickname = nickname;
            this.heroID = heroID; this.deedTime = deedTime;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" {name} {surname} >> {nickname} >>\n Hero ID: {heroID}");
            Console.WriteLine($" {nickname} is a hero!\n Hero deed time is {deedTime} h.");
        }
       
        public int CalculateLevel()
        {
            int level = 0;
            if (deedTime < 20)
            {
                level = 1;
            }
            if (deedTime >= 20 && deedTime <= 40)
            {
                level = 2;
            }
            if (deedTime > 40)
            {
                level = 3;
            }
            return level;
        }
        
    }

   
}
