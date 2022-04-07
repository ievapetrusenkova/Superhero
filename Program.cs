using Superhero;

namespace SuperHero
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Hero hero = new Hero();

            var flashPowers = new List<string>();
            var wonderWomanPowers = new List<string>();
            var bondPowers = new List<string>();
            var lightningPowers = new List<string>();
            var acePowers = new List<string>();
            var agentSmartPowers = new List<string>();
            var lolaPowers = new List<string>();

            Hero hero1 = new("John", "Smith", "Flash", 30, flashPowers, 1045, 30);
            Hero hero2 = new("Amela", "Rada", "WonderWoman", 20, wonderWomanPowers, 1212, 58);
            Hero hero3 = new("James", "Bond", "007", 45, bondPowers, 0007, 45);
            Hero hero4 = new("Jim", "Brown", "Lightning", 18, lightningPowers, 1456, 14);
            Hero hero5 = new("Jack", "Black", "Ace", 33, acePowers, 1522, 23);
            Hero hero6 = new("Kevin", "Smart", "Agent Smart", 41, agentSmartPowers, 1636, 25);
            Hero hero7 = new("Lolita", "Oak", "Lola", 23, lolaPowers, 1288, 30);

            List<Hero> listOfHeroes1 = new List<Hero>();
            listOfHeroes1.Add(hero1);
            listOfHeroes1.Add(hero2);
            listOfHeroes1.Add(hero3);

            List<Hero> listOfHeroes2 = new List<Hero>();
            listOfHeroes2.Add(hero4);
            listOfHeroes2.Add(hero5);
            listOfHeroes2.Add(hero6);
            listOfHeroes2.Add(hero7);

            var cablePowers = new List<string>();
            var deadPoolpowers = new List<string>();
            var chuckiePowers = new List<string>();

            List<Villain> villainsImanta = new List<Villain>();
            List<Villain> villainsJugla = new List<Villain>();

            Villain villain1 = new("Nathan", "Summers", "Cable", 48, cablePowers, 1055, 20);
            Villain villain2 = new("Wade", "Wilson", "Deadpool", 31, deadPoolpowers, 1001, 30);
            Villain villain3 = new("Charles", "Crow", "Chuckie", 24, chuckiePowers, 1666, 5);

            villainsImanta.Add(villain1);
            villainsImanta.Add(villain2);
            villainsJugla.Add(villain3);


            District imanta = new("Imanta", "Riga", 1450, listOfHeroes1, villainsImanta);
            District jugla = new("Jugla", "Riga", 1774, listOfHeroes2, villainsJugla);

            string[,] villainPowers2D ={
                { " electric power", "strength", "steel hand" },
                { "strengh", "immortality", "ability to recover fast" },
                { "invisible", "can steal", "violent" },
            };

            string[,] superHeroPowers2D ={
                { "superFast", "superStrengh", "hardPunch" },
                { "strengh", "speed", "abilityToFly" },
                { "good fighter", "elegant", "clever" },
                { "WeatherManipulation","TemperatureModification", "flight" },
                { "super memory", "quick actions", "technical skills"},
                { "very smart", "disguise skills", "good equipment" },
                { "hypnotizing skills", "ability to change looks", "mind reading" }
            };

            for (int i = 0; i < superHeroPowers2D.GetLength(1); i++)
            {
                flashPowers.Add(superHeroPowers2D[0, i]);
            }

            for (int i = 0; i < superHeroPowers2D.GetLength(1); i++)
            {
                wonderWomanPowers.Add(superHeroPowers2D[1, i]);
            }

            for (int i = 0; i < superHeroPowers2D.GetLength(1); i++)
            {
                bondPowers.Add(superHeroPowers2D[2, i]);
            }

            for (int i = 0; i < superHeroPowers2D.GetLength(1); i++)
            {
                lightningPowers.Add(superHeroPowers2D[3, i]);
            }

            for (int i = 0; i < superHeroPowers2D.GetLength(1); i++)
            {
                acePowers.Add(superHeroPowers2D[4, i]);
            }

            for (int i = 0; i < superHeroPowers2D.GetLength(1); i++)
            {
                agentSmartPowers.Add(superHeroPowers2D[5, i]);
            }

            for (int i = 0; i < superHeroPowers2D.GetLength(1); i++)
            {
                lolaPowers.Add(superHeroPowers2D[6, i]);
            }

            bool isMenuRunning = true;
            do
            {
                string menuItems;
                PrintMenu();
                menuItems = Console.ReadLine();

                switch (menuItems)
                {
                    case "1":
                        imanta.PrintListOfHeroes();
                        jugla.PrintListOfHeroes();
                        break;
                    case "2":
                        Console.WriteLine($"Please choose a superhero by number");

                        imanta.PrintListOfHeroes();
                        jugla.PrintListOfHeroes();

                        int.TryParse(Console.ReadLine(), out int chosenNumber);
                        Console.WriteLine($"You have chosen {imanta.HeroesInTheDistrict[chosenNumber].Nickname}");
                        Console.WriteLine($"You have chosen {jugla.HeroesInTheDistrict[chosenNumber].Nickname}");
                        Console.WriteLine("Choose what type of info to show");
                        Console.WriteLine($"1 - GENERAL INFO");
                        Console.WriteLine($"2 - FINANCIAL INFO");
                        string showMenu = Console.ReadLine();
                        if (showMenu == "1")
                        {
                            imanta.HeroesInTheDistrict[chosenNumber].PrintGeneralInfo();
                            jugla.HeroesInTheDistrict[chosenNumber].PrintGeneralInfo();
                        }
                        else if (showMenu == "2")
                        {
                            imanta.HeroesInTheDistrict[chosenNumber].PrintFinancialInfo();
                            jugla.HeroesInTheDistrict[chosenNumber].PrintFinancialInfo();
                        }
                        break;
                    case "3":
                        Console.WriteLine("What is the new superhero name?");
                        string superHeroName = Console.ReadLine();
                        Hero newhero = new Hero();
                        newhero.Nickname = superHeroName;
                        imanta.AddHero(newhero);
                        Console.WriteLine($"SuperHero {superHeroName} Added!");
                        break;
                    case "4":
                        Console.WriteLine("Which superhero to remove?");
                        imanta.PrintListOfHeroes();
                        jugla.PrintListOfHeroes();
                        int.TryParse(Console.ReadLine(), out int positionToRemove);
                        Console.WriteLine($"SuperHero {imanta.HeroesInTheDistrict[positionToRemove]} Removed!");
                        Console.WriteLine($"SuperHero {jugla.HeroesInTheDistrict[positionToRemove]} Removed!");
                        imanta.RemoveHero(positionToRemove);
                        jugla.RemoveHero(positionToRemove);
                        break;
                    case "5":
                        foreach (Hero heroPerson in imanta.HeroesInTheDistrict)
                        {
                            if (heroPerson.CalculateLevel() > 1)
                            {

                            }
                            Console.Write($" {heroPerson.Nickname} is higher than level 1\n");
                            Console.WriteLine($" {heroPerson.Nickname} level is { heroPerson.CalculateLevel() }\n");

                        }
                        Console.WriteLine($"\n The average of level of heroes inside {imanta.Title} is : " +
                            $"{imanta.CalculateAvgHeroLevelInDistrict()}\n");
                        break;
                    case "6":

                        foreach (Hero heroPerson in jugla.HeroesInTheDistrict)
                        {
                            Console.Write($" {heroPerson.Nickname} is higher than level 1\n");

                            Console.WriteLine($" {heroPerson.Nickname} level is { heroPerson.CalculateLevel() }\n");

                            if (hero.CalculateLevel() > 1)
                            {

                            }

                        }

                        Console.WriteLine($"\n The average of level of heroes inside {jugla.Title} is : " +
                            $"{jugla.CalculateAvgHeroLevelInDistrict()}\n");
                        break;

                    /*var nameJohn = listOfHeroes.Find(find => find.name.ToLower() == "john");
                    if (nameJohn != null)
                    {
                        nameJohn.PrintInfo();
                    }
                    else
                    {
                        Console.WriteLine("John was not found!");
                    }*/

                    case "7":
                        imanta.PrintListOfVillains();

                        Console.WriteLine($" Total crime time is: {imanta.CalculateTotalCrimeTime()}");
                        Console.WriteLine($" Most crime time spent is: {imanta.CalculateMaxCrimeTime()}");
                        break;
                    case "8":
                        jugla.PrintListOfVillains();
                        Console.WriteLine($" Total crime time is: {jugla.CalculateTotalCrimeTime()}");
                        Console.WriteLine($" Most crime time spent is: {imanta.CalculateMaxCrimeTime()}");
                        break;
                    case "9":
                        imanta.PrintInfoAboutDistrict();
                        jugla.PrintInfoAboutDistrict();
                        break;
                    case "10":
                        isMenuRunning = false;
                        Console.WriteLine($"Good bye!");
                        break;
                    default:
                        Console.WriteLine("Please choose from the available menu!");
                        break;
                }
            } while (isMenuRunning);

        }

        private static void PrintMenu()
        {
            Console.WriteLine($"\nWelcome to the superhero application!");
            Console.WriteLine($"Select what to do:");
            Console.WriteLine($"1 - Show a list of superheroes");
            Console.WriteLine($"2 - Show specific hero");
            Console.WriteLine($"3 - Adding a superhero");
            Console.WriteLine($"4 - Deleting a superhero");
            Console.WriteLine($"5 - Calculate Average heroes level in Imanta");
            Console.WriteLine($"6 - Calculate Average heroes level in Jugla");
            Console.WriteLine($"7 - Information about villains in Imanta");
            Console.WriteLine($"8 - Information about villains in Jugla");
            Console.WriteLine($"9 - Information about districts");
            Console.WriteLine($"10 - Exit");
        }
    }
}




