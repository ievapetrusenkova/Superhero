﻿/*
string name = "SuperSonic";
int age = 77;
string HeroPower1, HeroPower2, HeroPower3;
HeroPower1 = "runs superfast";
HeroPower2 = "invulnerability";
HeroPower3 = "light speed spin dash";
double salary = 1000;
bool isEvil = false;
double CookieCost = 1.29;
Console.WriteLine("=============");
Console.WriteLine(" Hero");
Console.WriteLine("===============");
Console.WriteLine($"Hero name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"HeroPowers: \n {HeroPower1}, \n {HeroPower2}, \n {HeroPower3}");
Console.WriteLine("==============");

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

Console.WriteLine("Please enter side A:");

string a = Console.ReadLine();
Console.WriteLine("Please enter side B:");
string b = Console.ReadLine();
Console.WriteLine("Please enter side C:");
string c = Console.ReadLine();

double.TryParse(a, out double A);
double.TryParse(b, out double B);
double.TryParse(c, out double C);
if ( A + B < C || B + C < A || C + A < B)
{ Console.WriteLine("triangle doesn't exist");
}
else if (A == B && B == C)
{
    Console.WriteLine("It is isosceles triangle");
}
else if (A != B && B != C && A !=C)
{ Console.WriteLine("It is scalene triangle");
}
else
{ Console.WriteLine("It is equilateral triangle");
}

