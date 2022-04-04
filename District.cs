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
        public List<Hero> heroesInTheDistrict { get; set; }

        public District(string title, string city, int districtID, List<Hero> heroesInTheDistrict)
        {
            this.Title = title; this.City = city; this.DistrictID = districtID; this.heroesInTheDistrict = heroesInTheDistrict;
        }


        public void AddHero(Hero hero)
        {
            Console.WriteLine($" We have added to {Title} hero {hero.nickname}");
            heroesInTheDistrict.Add(hero);
        }
        public void RemoveHero(int position)
        {
            Console.WriteLine($" We removed the hero {heroesInTheDistrict[position]}");
            heroesInTheDistrict.RemoveAt(position);
        }
        public float CalculateAvgLevelInDistrict()
        {
            float OverallLevel = 0f;
            foreach (Hero hero in heroesInTheDistrict)
            {
                hero.CalculateLevel();
            }
            float averageLevelInDistrict = OverallLevel / heroesInTheDistrict.Count;
            return averageLevelInDistrict;
        }
        public void PrintInformationAboutDistrict()
        {
            Console.WriteLine($"======={City}=======");
            Console.WriteLine($"District: {Title}");
            Console.WriteLine($"Id : {DistrictID}");
            Console.WriteLine($"Heroes:");
            foreach (Hero hero in heroesInTheDistrict)
            {
                hero.PrintInfo();
            }
        }



    }             
}
    
    
    

