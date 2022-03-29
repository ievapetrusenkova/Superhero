using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    public enum heroType
    {
        hero, villain
    }
    internal class Hero
    {
        private string name;
        private string surname;
        private string nickname;
        private int heroID;
        private heroType type;
        private int deedTime;

        public Hero()
        {
            name = "Tony";
            surname = "Stark";
            nickname = "IronMan";
            heroID = 5;
            type = heroType.hero;
            deedTime = 10;
        }

        public Hero (string name, string surname, string nickname, int heroID, heroType type, int deedTime)
        {
            this.name = name; this.surname = surname; this.nickname = nickname;
            this.heroID = heroID; this.type = type; this.deedTime = deedTime;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" {name} {surname} >> {nickname} >>\n Hero ID: {heroID}");
            Console.WriteLine($" {nickname} is a {type}!\n Hero deed time is {deedTime} h.");
        }
       

    }
   
}
