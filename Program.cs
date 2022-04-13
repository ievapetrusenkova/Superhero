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
            var aquamanPowers = new List<string>();
            var catwomanPowers = new List<string>();
            var antmanPowers = new List<string>();
            var robinPowers = new List<string>();
            var maskPowers = new List<string>();
            var hulkPowers = new List<string>();
            var thorPowers = new List<string>();

            Hero hero1 = new("John", "Smith", "Flash", 30, flashPowers, 1450, 30);
            Hero hero2 = new("Amela", "Rada", "WonderWoman", 20, wonderWomanPowers, 1450, 58);
            Hero hero3 = new("James", "Bond", "007", 45, bondPowers, 1450, 45);
            Hero hero4 = new("Jim", "Brown", "Lightning", 18, lightningPowers, 1774, 14);
            Hero hero5 = new("Jack", "Black", "Ace", 33, acePowers, 1774, 23);
            Hero hero6 = new("Kevin", "Smart", "Agent Smart", 41, agentSmartPowers, 1774, 25);
            Hero hero7 = new("Lolita", "Oak", "Lola", 23, lolaPowers, 1774, 30);
            Hero hero8 = new("Jason", "Man", "AquaMan", 36, aquamanPowers, 2010, 66);
            Hero hero9 = new("Katie", "Walsh", "Catwoman", 24, catwomanPowers, 2010, 16);
            Hero hero10 = new("Nick", "Cane", "AntMan", 39, antmanPowers, 2010, 22);
            Hero hero11 = new("Tim", "Robbins", "Robin", 29, robinPowers, 2010, 31);
            Hero hero12 = new("Stanley", "Tucci", "Mask", 40, maskPowers, 2010, 39);
            Hero hero13 = new("Bruce", "Banner", "Hulk", 45, hulkPowers, 2010, 70);
            Hero hero14 = new("Son", "Odin", "Thor", 1000, thorPowers, 2010, 155);

            var cablePowers = new List<string>();
            var deadPoolpowers = new List<string>();
            var chuckiePowers = new List<string>();
            var jokerPowers = new List<string>();
            var killersharkPowers = new List<string>();
            var blackmantaPowers = new List<string>();

            Villain villain1 = new("Nathan", "Summers", "Cable", 48, cablePowers, 1450, 20);
            Villain villain2 = new("Wade", "Wilson", "Deadpool", 31, deadPoolpowers, 1450, 30);
            Villain villain3 = new("Charles", "Crow", "Chuckie", 24, chuckiePowers, 1774, 5);
            Villain villain4 = new("Prince", "Crime", "Joker", 41, jokerPowers, 2010, 44);
            Villain villain5 = new("Shon", "Killer", "Killer-Shark", 36, killersharkPowers, 1774, 57);
            Villain villain6 = new("Him", "Ocean", "Black Manta", 99, blackmantaPowers, 2010, 77);

            List<Person> peopleInImanta = new();
            List<Person> peopleInJugla = new();
            List<Person> peopleInLielupe = new();

            District imanta = new("Imanta", "Riga", 1450, peopleInImanta);
            District jugla = new("Jugla", "Riga", 1774, peopleInJugla);
            District lielupe = new("Lielupe", "Jurmala", 2010, peopleInLielupe);
            
            peopleInImanta.Add(hero1);
            peopleInImanta.Add(hero2);
            peopleInImanta.Add(hero3);
            peopleInImanta.Add(villain1);
            peopleInImanta.Add(villain2);

            peopleInJugla.Add(hero4);
            peopleInJugla.Add(hero5);
            peopleInJugla.Add(hero6);
            peopleInJugla.Add(hero7);
            peopleInJugla.Add(villain3);
            peopleInJugla.Add(villain5);

            peopleInLielupe.Add(hero8);
            peopleInLielupe.Add(hero9);
            peopleInLielupe.Add(hero10);
            peopleInLielupe.Add(hero11);
            peopleInLielupe.Add(hero12);
            peopleInLielupe.Add(hero13);
            peopleInLielupe.Add(hero14);
            peopleInLielupe.Add(villain4);
            peopleInLielupe.Add(villain6);

            List<District> districts = new List<District>();
            districts.Add(imanta);
            districts.Add(jugla);
            districts.Add(lielupe);

            string[,] villainPowers ={
                { " electric power", "strength", "steel hand" },
                { "strengh", "immortality", "ability to recover fast" },
                { "invisible", "can steal", "violent" },
                { "powerful forces", "mad", "clever" },
                { "ocean wizzard", "super strength", "immortal" },
                { "dangerously fast", "killer teeth", "can swim and run" }
            };

            string[,] superHeroPowers ={
                { "superFast", "superStrengh", "hardPunch" },
                { "strengh", "speed", "abilityToFly" },
                { "good fighter", "elegant", "clever" },
                { "WeatherManipulation","TemperatureModification", "flight" },
                { "super memory", "quick actions", "technical skills"},
                { "very smart", "disguise skills", "good equipment" },
                { "hypnotizing skills", "ability to change looks", "mind reading" },
                { "fast swimmer", "can breathe underwater", "can control water" },
                { "can climb walls", "self-heeling power", "can see in dark" },
                { "can teleport", "change size", "fly" },
                { "strong", "fast runner", "best fighter" },
                { "unbeatable", "persona change", "crime fighter" },
                { "giant strength", "invincible", "capability to survive" },
                { "magic hammer", "half-God", "immortal" }
             };

            for (int i = 0; i < superHeroPowers.GetLength(1); i++)
            {
                flashPowers.Add(superHeroPowers[0, i]);
            }

            for (int i = 0; i < superHeroPowers.GetLength(1); i++)
            {
                wonderWomanPowers.Add(superHeroPowers[1, i]);
            }

            for (int i = 0; i < superHeroPowers.GetLength(1); i++)
            {
                bondPowers.Add(superHeroPowers[2, i]);
            }

            for (int i = 0; i < superHeroPowers.GetLength(1); i++)
            {
                lightningPowers.Add(superHeroPowers[3, i]);
            }

            for (int i = 0; i < superHeroPowers.GetLength(1); i++)
            {
                acePowers.Add(superHeroPowers[4, i]);
            }

            for (int i = 0; i < superHeroPowers.GetLength(1); i++)
            {
                agentSmartPowers.Add(superHeroPowers[5, i]);
            }

            for (int i = 0; i < superHeroPowers.GetLength(1); i++)
            {
                lolaPowers.Add(superHeroPowers[6, i]);
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
                        imanta.PrintListOfPeople();
                        jugla.PrintListOfPeople();
                        lielupe.PrintListOfPeople();
                        break;
                    case "2":
                        Console.WriteLine($"Please choose a superhero/villain by number");
                        imanta.PrintOutSpecificPerson();
                        jugla.PrintOutSpecificPerson();
                        lielupe.PrintOutSpecificPerson();
                        break;
                    case "3":
                        imanta.AddHero();
                        jugla.AddHero();
                        lielupe.AddHero();
                        break;
                    case "4":
                        imanta.RemovePerson();
                        jugla.RemovePerson();
                        lielupe.RemovePerson();
                        break;
                    case "5":
                        foreach (Person person in imanta.PersonInTheDistrict)
                        {
                           if (person.CalculateLevel() > 1)
                           {
                            Console.WriteLine($"{person.Nickname} is higher than level 1");
                           }
                        }
                        foreach (Person person in jugla.PersonInTheDistrict)
                        {
                            if (person.CalculateLevel() > 1)
                            {
                                Console.WriteLine($"{person.Nickname} is higher than level 1");
                            }
                        }
                        foreach (Person person in lielupe.PersonInTheDistrict)
                        {
                            if (person.CalculateLevel() > 1)
                            {
                                Console.WriteLine($"{person.Nickname} is higher than level 1");
                            }
                        }
                        break;
                    case "6":
                        Console.WriteLine($"\n The average of level of heroes inside {imanta.Title} is : " +
                              $"{imanta.CalculateAvgHeroLevelInDistrict()}\n");
                        Console.WriteLine($"\n The average level of heroes inside {jugla.Title} is : " +
                            $"{jugla.CalculateAvgHeroLevelInDistrict()}\n");
                        Console.WriteLine($"\n The average of level of heroes inside {lielupe.Title} is : " +
                              $"{lielupe.CalculateAvgHeroLevelInDistrict()}\n");
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
                        imanta.PrintMaxCrimeTime();
                        jugla.PrintMaxCrimeTime();
                        lielupe.PrintMaxCrimeTime();
                        break;
                    case "8":
                        Console.WriteLine($"Total person count in {imanta.Title} is {imanta.TotalPersonCountInTheDistrict()}");
                        
                        break;
                    case "9":
                        
                        Console.WriteLine($" Largest average hero level is:\n{imanta.Title}: " +
                            $"{imanta.LargestAverageHeroLevelofDistrict()}\n{jugla.Title}: { jugla.LargestAverageHeroLevelofDistrict()}\n{lielupe.Title}:" +
                            $" { lielupe.LargestAverageHeroLevelofDistrict()}");
                       
                        break;
                    case "10":
                        Console.WriteLine($" The  amount of Persons in  district Imanta is >> {imanta.TotalPersonCountInTheDistrict()}");
                        Console.WriteLine($" The  amount of Persons in  district Jugla is >> {jugla.TotalPersonCountInTheDistrict()}");
                        Console.WriteLine($" The highest amount of persons is: {Math.Max(imanta.TotalPersonCountInTheDistrict(), jugla.TotalPersonCountInTheDistrict())}");
                        break;
                    case "11":
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
            Console.WriteLine($"1 - Show a list of superheroes and villains in districts");
            Console.WriteLine($"2 - Show specific hero/villain");
            Console.WriteLine($"3 - Adding a superhero");
            Console.WriteLine($"4 - Deleting a superhero");
            Console.WriteLine($"5 - Level info - higher level than 1 in districts");
            Console.WriteLine($"6 - Level info - average level in districts");
            Console.WriteLine($"7 - Maximum crime time in districts");
            Console.WriteLine($"8 - Information about villains in Jugla");
            Console.WriteLine($"9 - Average hero level in districts");
            Console.WriteLine($"10 - max person count");
            Console.WriteLine($"11 - Exit");
        }
    }
}




