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
        public virtual int CalculateLevel()
        {
            int level = 0;
            return level;
        }
        public virtual void PrintGeneralInfo()
        {
            Console.WriteLine("*********************GENERAL INFO******************");
            Console.WriteLine($"Hero: {Nickname}");
            Console.WriteLine($"Age:  {Age} year old");
            Console.WriteLine($"Super powers: \n ");
            for (int i = 0; i < PowerList.Count; i++)
            {
                Console.WriteLine($"{PowerList[i]} ");
            }
        }

        public virtual void PrintFinancialInfo()
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
