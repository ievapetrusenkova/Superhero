/*
## Lesson 3 - Variables and Data Types
- Create variables:
    - Hero name - String
    - Hero age - int
    - Hero powers - heroPower1, heroPower2, heroPower3
    - Create "Hero Card" view. Print variables to console
*/
string name = "SuperSonic";
int age = 77;
string HeroPower1, HeroPower2, HeroPower3;
HeroPower1 = "runs superfast";
HeroPower2 = "invulnerability";
HeroPower3 = "light speed spin dash";
double salary = 1000;
bool isEvil = false;
double CookieCost = 1.29;
Console.WriteLine("=======GENERAL INFO======");
Console.WriteLine(" Hero");
Console.WriteLine("===============");
Console.WriteLine($"Hero name: {name}");
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

int deedTimeInHours1 = 6;
int deedTimeInHours2 = 7;
int deedTimeInHours3 = 8;
int TotalHours = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
int AverageHours = TotalHours / 3;
int TotalCookies = TotalHours * 5;
double boughtCookies = Math.Floor(salary / CookieCost);
double DailySalary = Math.Round(salary / 30, 2);

Console.WriteLine($"\n Total time {name} spent:  { TotalHours}h");
Console.WriteLine($"\n Average hours {name} spent: {AverageHours}h");
Console.WriteLine($"\n {name} will get {TotalCookies} cookies!");
Console.WriteLine($"\n {name} can buy { boughtCookies } cookies");
Console.WriteLine($"\n {name} earns daily { DailySalary }");
if (!isEvil)
{
    Console.WriteLine($"\n {name} Protects the city and earns his cookies");
}
else
{
    Console.WriteLine("\n The villain is stealing the cookie supply");
}
Console.WriteLine($"\n {name} earns {salary} eur/month");*/

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






