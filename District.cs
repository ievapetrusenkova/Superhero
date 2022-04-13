using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal class District
    {
        public string Title { get; set; }
        public string City { get; set; }
        public int DistrictID { get; set; }
        public List<Person> PersonInTheDistrict { get; set; }
      

        
        public District(string title, string city, int districtID, List<Person> PersonInTheDistrict)
        {
            this.Title = title; this.City = city; this.DistrictID = districtID;
            this.PersonInTheDistrict = PersonInTheDistrict; 
        }
        
        public void AddHero()
        {
            Console.WriteLine("What is the new superhero name?");
            string superHeroName = Console.ReadLine();
            Hero newhero = new Hero();
            newhero.Nickname = superHeroName;
            Console.WriteLine($"SuperHero {superHeroName} Added!");
            PersonInTheDistrict.Add(newhero);
        }

        public void RemovePerson()
        {
            Console.WriteLine("Which superhero to remove?");
            PrintListOfPeople();
            int.TryParse(Console.ReadLine(), out int positionToRemove);
            Console.WriteLine($"SuperHero {PersonInTheDistrict[positionToRemove]} Removed!");
            PersonInTheDistrict.RemoveAt(positionToRemove);
        } 
        public void PrintListOfPeople()
        {
            Console.WriteLine("============List=Of=People============");
            for (int i = 0; i < PersonInTheDistrict.Count; i++)
            {
                Console.WriteLine($"{i}. {PersonInTheDistrict[i].Nickname}");
            }
            Console.WriteLine("===========================================");
        }

        public void PrintOutSpecificPerson()
        {
            Console.WriteLine($"Please choose a superhero by number");

            PrintListOfPeople();

            int.TryParse(Console.ReadLine(), out int chosenNumber);
            Console.WriteLine($"You have chosen {PersonInTheDistrict[chosenNumber].Nickname}");

            Console.WriteLine("Choose what type of info to show");
            Console.WriteLine($"1 - GENERAL INFO");
            Console.WriteLine($"2 - FINANCIAL INFO");
            string showMenu = Console.ReadLine();
            if (showMenu == "1")
            {
                PersonInTheDistrict[chosenNumber].PrintGeneralInfo();
            }
            else if (showMenu == "2")
            {
                PersonInTheDistrict[chosenNumber].PrintFinancialInfo();
            }

        }
        public float CalculateAvgHeroLevelInDistrict()
        { 
            float maxLevel = 0f;
            int heroCount = 0;
            foreach (Person person in PersonInTheDistrict)
            {
                if (person is Hero)
                {
                    Hero hero = (Hero)person;
                    maxLevel += hero.CalculateLevel();
                    heroCount++;
                }
            }
            var averageLevel = maxLevel / heroCount;

            return averageLevel;
        }
        public int CalculateTotalCrimeTime()
        {
            int totalCrimeTime = 0;
            foreach (Person person in PersonInTheDistrict)
            {
                if (person is Villain)
                {
                    Villain villain = (Villain)person;
                    totalCrimeTime += villain.CrimeTime;
                }
            }
            return totalCrimeTime;
        }

        public int CalculateMaxCrimeTimeInTheDistrict()
        {
            int maxLevel = 0;
            foreach (Person person in PersonInTheDistrict)
            {
                if (person is Villain)
                {
                    Villain villain = (Villain)person;
                    if (maxLevel < villain.CrimeTime)
                    {
                        maxLevel = villain.CrimeTime;

                    }
                }
            }
            return maxLevel;
        }
        public void PrintMaxCrimeTime()
        {
            int maxLevel = 0;
            string maxVillainName = string.Empty;
            var villainList = PersonInTheDistrict.Where(person => person is Villain).ToList();
            foreach (Person person in villainList)
            {
                Villain villain = (Villain)person;
                if (maxLevel < villain.CrimeTime)
                {
                    maxLevel = villain.CrimeTime;
                    maxVillainName = villain.Nickname;
                }
            }
            Console.WriteLine($"The max crime time in {Title} is {maxVillainName} with {maxLevel} hours");
        }

        public virtual int TotalPersonCountInTheDistrict()
        {
            int personCount = 0;

            foreach (Person person in PersonInTheDistrict)
            {
                personCount++;
            }
            return personCount;

            
        }
        public virtual int LargestAverageHeroLevelofDistrict()
        {
            int maxLevel = 0;
            
            int heroCount = 0;
            foreach (Person person in PersonInTheDistrict)
            {
                if (person is Hero)
                {
                    Hero hero = (Hero)person;
                    maxLevel += hero.CalculateLevel();
                    heroCount++;
                }
            }
            var averageHeroLevel = maxLevel / heroCount;

            int largestAverageHeroLevel = 0;
            largestAverageHeroLevel = Math.Max(averageHeroLevel, 0);
            return largestAverageHeroLevel;
        }
        public void PrintInfoAboutDistrict()
        {
            Console.WriteLine($"{City}: {Title}, ID: {DistrictID}");
            PrintListOfPeople();
           
        }
    }
}
    
    
    

