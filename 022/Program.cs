﻿// 22. По двум заданным числам проверять, является ли одно квадратом другого.

double a, b;
System.Console.Write("Введите a: ");
a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите b: ");
b=Convert.ToDouble(Console.ReadLine());

if (a*a==b)
    System.Console.WriteLine($"{b} является квадратом {a}");
if (b*b==a)
    System.Console.WriteLine($"{a} является квадратом {b}");

