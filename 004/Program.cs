﻿Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine("Nubmer Max = " + a); 
}
else if (b > c)
{
    Console.WriteLine("Number Max = " + b);
}
else
{
    Console.WriteLine("Number Max = " + c);
}
Console.ReadLine();