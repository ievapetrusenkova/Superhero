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

        public override void PrintGeneralInfo()
        {
            base.PrintGeneralInfo();
            Console.WriteLine($"Hero DEED time: {DeedTime}");
            Console.WriteLine($"HeroID: {HeroID}");
            Console.WriteLine("******************************************** \n \n");
        }
        public void PrintFinancialInfo()
        {
            int deedTimeInHours1 = 6;
            int deedTimeInHours2 = 7;
            int deedTimeInHours3 = 8;
            double Salary = 1000;
            double CookieCosts = 1.29;
            int TotalHours = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
            int AverageHours = TotalHours / 3;
            double rewardMoney = TotalHours * 5;
            Salary += rewardMoney;
            double boughtCookies = Math.Floor(Salary / CookieCosts);
            double DailySalary = Math.Round(Salary / 30, 2);

            Console.WriteLine("************FINANCIAL INFO*****************");

            Console.WriteLine($" Hero can buy { boughtCookies } cookies");
            Console.WriteLine($" Hero earns daily { DailySalary }");
            Console.WriteLine($" Our hero spent {TotalHours} hours doing deeds");
            Console.WriteLine($" Our hero on average spent {AverageHours} hours per deed");
            Console.WriteLine($" Our hero earns {Salary} eur/month");
            Console.WriteLine($" For the deeds our hero got as a reward {rewardMoney} EUR");
        }
    }
   
}
