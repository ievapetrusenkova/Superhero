using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal class Villain : Person
    {
        public int VillainID { get; set; }
        public int CrimeTime { get; set; }


        public Villain (string name, string surname, string nickname, int age, List<string> powerList, int villainID, int crimeTime)
            : base(name, surname, nickname, age, powerList)
        {
            
            this.VillainID = villainID; this.CrimeTime = crimeTime; 

        }

        public override void PrintGeneralInfo()
        {
            base.PrintGeneralInfo();
            Console.WriteLine($"VillainID: {VillainID}");
            Console.WriteLine($"CrimeTime: {CrimeTime}");
            Console.WriteLine("******************************************** \n \n");
        }

    }
}  
    
