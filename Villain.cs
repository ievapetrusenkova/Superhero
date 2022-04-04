using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal class Villain : Person
    {
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string Name { get; set; }
        public int VillainID { get; set; }
        public int CrimeTime { get; set; }

        public Villain(string name, string surname, string nickname, int VillainID, int CrimeTime) : base(name, surname)
        {
            this.Name = name; this.Surname = surname; this.Nickname = nickname;
            this.VillainID = VillainID; this.CrimeTime = CrimeTime;

        }
        public void Main (string[] args)
        {
            Villain NewVillain1 = new Villain("Nathan", "Summers", "Cable", 1055, 20);
            Villain NewVillain2 = new Villain("Wade", "Wilson", "Deadpool", 1001, 30);

        }
        
        public void PrintInfo()
        {
            Console.WriteLine($" {Name} {Surname} >> {Nickname} >>\n Villain ID: {VillainID}");
            Console.WriteLine($" {Nickname} is a villain!\n {Nickname}`s crime time is {CrimeTime} h.");
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
    
