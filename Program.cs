/*
## Lesson 3 - Variables and Data Types
- Create variables:
    - Hero name - String
    - Hero age - int
    - Hero powers - heroPower1, heroPower2, heroPower3
    - Create "Hero Card" view. Print variables to console
*/
using Superhero;

namespace SuperHero // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
         Hero MyHero = new Hero( "Johnny", "Smith", "SuperSonic", 4, heroType.hero, 9);
            MyHero.PrintInfo();

            Hero MySuperHero = new Hero();
            MySuperHero.PrintInfo();
            string[] superHeroNameList = { "Flash", "WonderWoman", "Storm" };
                 int[] superHeroAgeList = { 20, 230, 44 };
                 string[,] superHeroPowers2D ={ { "superFast", "superStrengh", "hardPunch" },
                 {"strengh", "speed", "abilityToFly" },
                 {"WeatherManipulation","TemperatureModification", "flight" } };
                 bool isMenuRunning = true;
             do
             {
                string menuItems;

                Console.WriteLine($"Welcome to the superhero application!");
                Console.WriteLine($"Select what to do:");
                Console.WriteLine($"1 - Show a list of superheroes");
                Console.WriteLine($"2 - Show specific hero");
                Console.WriteLine($"3 - Adding a superhero");
                Console.WriteLine($"4 - Deleting a superhero");
                Console.WriteLine($"5 - Exit");

                menuItems = Console.ReadLine();
                switch (menuItems)
                {
                    case "1":
                        Console.WriteLine("============List=of=superheroes============");
                        for (int i = 0; i < superHeroNameList.Length; i++)
                        {
                            Console.WriteLine($"{i}. {superHeroNameList[i]}");
                        }
                        Console.WriteLine("===========================================");
                        break;
                    case "2":
                        Console.WriteLine($"Please choose a superhero by number");

                        for (int i = 0; i < superHeroNameList.Length; i++)
                        {
                            Console.WriteLine($"{i}. {superHeroNameList[i]}");
                        }

                        int.TryParse(Console.ReadLine(), out int chosenNumber);
                        Console.WriteLine($"You have chosen {superHeroNameList[chosenNumber]}");

                        Console.WriteLine("Choose what type of info to show");
                        Console.WriteLine($"1 - GENERAL INFO");
                        Console.WriteLine($"2 - FINANCIAL INFO");
                        string showMenu = Console.ReadLine();
                        if (showMenu == "1")
                        {
                            Console.WriteLine("*********************GENERAL INFO******************");
                            Console.WriteLine($"Hero: {superHeroNameList[chosenNumber]}");
                            Console.WriteLine($"Age:  {superHeroAgeList[chosenNumber]} year old");
                            Console.WriteLine($"Hero powers: \n ");
                            for (int i = 0; i < superHeroPowers2D.GetLength(1); i++)
                            {
                                Console.WriteLine($"{i}. {superHeroPowers2D[chosenNumber,i]} ");
                            }
                            Console.WriteLine("******************************************** \n \n");
                        }
                        else if(showMenu == "2")
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
                            
                            Console.WriteLine($"\n Hero can buy { boughtCookies } cookies");
                            Console.WriteLine($"\n Hero earns daily { DailySalary }");
                            Console.WriteLine($"Our hero spent {TotalHours} hours doing deeds");
                            Console.WriteLine($"Our hero on average spent {AverageHours} hours per deed");
                            Console.WriteLine($"For the deeds our hero got as a reward {rewardMoney} EUR");
                        }
                        break;
                    case "3":
                            Console.WriteLine("What is the new superhero name?");
                            string superHeroName = Console.ReadLine();
                            superHeroNameList = (string[])superHeroNameList.Append(superHeroName);
                            Console.WriteLine($"SuperHero {superHeroName} Added!");
                        break;
                    case "4":
                            Console.WriteLine("Which superhero to remove?");
                        for (int i = 0; i < superHeroNameList.Length; i++)
                        {
                            Console.WriteLine($"{i}. {superHeroNameList[i]}");
                        }
                        int.TryParse(Console.ReadLine(),out int positionToRemove);
                        Console.WriteLine($"SuperHero {superHeroNameList[positionToRemove]} Removed!");
                        List<string> list = new List<string>(superHeroNameList);
                        list.RemoveAt(positionToRemove);

                        superHeroNameList = list.ToArray();
                        break;
                    case "5":
                        isMenuRunning = false;
                        Console.WriteLine($"Good bye!");
                        break;
                    default:
                        Console.WriteLine("Please choose from the available menu!");
                        break;
                 }
                } while (isMenuRunning);

                string HeroName = "SuperSonic";
                int age = 77;
                string HeroPower1, HeroPower2, HeroPower3;
                HeroPower1 = "runs superfast";
                HeroPower2 = "invulnerability";
                HeroPower3 = "light speed spin dash";
                bool isEvil = false;
                double salary = 1000;
                Console.WriteLine("=======GENERAL INFO======");
                Console.WriteLine(" Hero");
                Console.WriteLine("===============");
                Console.WriteLine($"Hero name: {HeroName}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"HeroPowers: \n {HeroPower1}, \n {HeroPower2}, \n {HeroPower3}");
                Console.WriteLine("==============");

                // Cookie calculation
                /*
                 * - Continue working on Hero Card view
                    - Add new variables - deedTimeInHours1, deedTimeInHours2, deedTimeInHours3 (INT), holding time that a deed took to complete
                     - Add methods to calculate:
                    - Total time spent on deeds
                    - Average time spent on one deed
                    - How many cookies Hero will get. 5 cookies per hour
                 */
                Console.WriteLine("***************FINANCIAL INFO*****************************");

                

                if (!isEvil)
                {
                    Console.WriteLine($"\n {HeroName} Protects the city and earns his cookies");
                }
                else
                {
                    Console.WriteLine("\n The villain is stealing the cookie supply");
                }
                Console.WriteLine($"\n {HeroName} earns {salary} eur/month");

                // DEED
                char deed = 'A';

                switch (deed)
                {
                    case 'A':
                    case 'B':
                        Console.WriteLine("Perfect! You are so brave!");
                        break;
                    case 'C':
                        Console.WriteLine("Good! But You can do better!");
                        break;
                    case 'D':
                    case 'E':
                        Console.WriteLine("It is not good! You should choose your bad or good side!");
                        break;
                    case 'G':
                        Console.WriteLine("Bad, you are true villain");
                        break;
                    default:
                        Console.WriteLine("Undefined grade, please regrade it");
                        break;
                }
          
        }
         
    }

}

//  BUSINESS REQUIREMENTS
// 1. I would like to see a menu, to select different parts of superhero information card
// 2. A list of superheroes - arrays/ maybe lists
// 3, Add a new superhero
// 4. Showing a specific superhero information
// 5. Delete the superhero from the list
//
//
//
//
// A. A list of their powers
// 






