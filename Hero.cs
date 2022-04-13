using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{

    internal class Hero : Person
    {

        public int HeroID { get; set; }

        public int DeedTime { get; set; }


        public Hero(string name, string surname, string nickname, int age, List<string> powerList, int heroID, int deedTime)
            : base(name, surname, nickname, age, powerList)
        {
            this.HeroID = heroID; this.DeedTime = deedTime;
        }
        public Hero() : base("Tony", "Stark", "Ironman", 45, new List<string>())
        {
            HeroID = 0;
            DeedTime = 0;
        }
        public override int CalculateLevel()
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

        public override void PrintGeneralInfo()
        {
            base.PrintGeneralInfo();
            Console.WriteLine($"Hero DEED time: {DeedTime}");
            Console.WriteLine($"HeroID: {HeroID}");
            Console.WriteLine("******************************************** \n \n");
        }
        
    }
   
}
