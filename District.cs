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
        public List<Hero> HeroesInTheDistrict { get; set; }

        public List<Villain> VillainsInTheDistrict { get; set; }


        public District(string title, string city, int districtID, List<Hero> heroesInTheDistrict, List<Villain> villainsInTheDistrict)
        {
            this.Title = title; this.City = city; this.DistrictID = districtID; this.HeroesInTheDistrict = heroesInTheDistrict;
            this.VillainsInTheDistrict = villainsInTheDistrict;
        }

        public void AddHero(Hero hero)
        {
            Console.WriteLine($" We have added  hero << {hero.Nickname} >> to {Title}");
            HeroesInTheDistrict.Add(hero);
        }
        public void RemoveHero(int position)
        {
            Console.WriteLine($" We removed the hero {HeroesInTheDistrict[position]}");
            HeroesInTheDistrict.RemoveAt(position);
        }

        public void AddVillain(Villain villain)
        {
            Console.WriteLine($" We have added  hero << {villain.Nickname} >> to {Title}");
            VillainsInTheDistrict.Add(villain);
        }
        public void RemoveVillain(int positionV)
        {
            Console.WriteLine($" We removed the hero {VillainsInTheDistrict[positionV]}");
            VillainsInTheDistrict.RemoveAt(positionV);
        }
        public void PrintListOfHeroes()
        {
            Console.WriteLine("============List=of=superheroes============");
            for (int i = 0; i < HeroesInTheDistrict.Count; i++)
            {
                Console.WriteLine($"{i}. {HeroesInTheDistrict[i].Nickname}");
            }
            Console.WriteLine("===========================================");
        }
        public void PrintListOfVillains()
        {
            Console.WriteLine("============List=of=Villains============");
            for (int i = 0; i < VillainsInTheDistrict.Count; i++)
            {
                Console.WriteLine($"{i}. {VillainsInTheDistrict[i].Nickname}");
            }
            Console.WriteLine("===========================================");
        }

        public float CalculateAvgHeroLevelInDistrict()
        {
            float MaxLevel = 0f;

            foreach (var hero in HeroesInTheDistrict)
            {
                MaxLevel += hero.CalculateLevel();
            }
            var averageLevel = MaxLevel / HeroesInTheDistrict.Count;

            return averageLevel;
        }
        public int CalculateTotalCrimeTime()
        {
            int totalCrimeTime = 0;
            foreach (var villain in VillainsInTheDistrict)
            {
                totalCrimeTime += villain.CrimeTime;
            }
            return totalCrimeTime;
        }
        public int CalculateMaxCrimeTime()
        {
            int maxCrimeTime = 0;
            foreach (var villain in VillainsInTheDistrict)
            {
                maxCrimeTime = Math.Max(maxCrimeTime, villain.CrimeTime);
            }
            return maxCrimeTime;
        }

        public void PrintInfoAboutDistrict()
        {
            Console.WriteLine($"{City}: {Title}, ID: {DistrictID}");
            PrintListOfHeroes();
            PrintListOfVillains();
        }
    }
}
    
    
    

