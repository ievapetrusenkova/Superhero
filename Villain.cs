using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal class Villain
    {
        private string surname;
        public string nickname { get; set; }
        public string name { get; internal set; }

        private int VillainID;

        private int CrimeTime;

        public Villain(string name, string surname, string nickname, int VillainID, int CrimeTime)
        {
            this.name = name; this.surname = surname; this.nickname = nickname;
            this.VillainID = VillainID; this.CrimeTime = CrimeTime;
        }
        public Villain()
        {
            name = "Nathan";
            surname = "Summers";
            nickname = "Cable";
            VillainID = 1055;
            CrimeTime = 20;

            name = "Wade";
            surname = "Wilson";
            nickname = "Deadpool";
            VillainID = 1005;
            CrimeTime = 30;
        }
        public void PrintInfo()
        {
            Console.WriteLine($" {name} {surname} >> {nickname} >>\n Villain ID: {VillainID}");
            Console.WriteLine($" {nickname} is a villain!\n {nickname}`s crime time is {CrimeTime} h.");
        }
        public int CalculateLevel()
        {
            int level = 0;
            if (CrimeTime < 20)
            {
                level = 1;
            }
            if (CrimeTime >= 20 && CrimeTime <= 40)
            {
                level = 2;
            }
            if (CrimeTime > 40)
            {
                level = 3;
            }
            return level;
        }

    }
}  
    
