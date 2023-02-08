// 2. С клавиатуры вводятся два вещественных числа. Проверить, является ли одно из них квадратом второго.

double a, b;
System.Console.Write("Введите a: ");
a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите b: ");
b=Convert.ToDouble(Console.ReadLine());

if (a*a==b)
    System.Console.WriteLine($"{b} является квадратом {a}");
if (b*b==a)
    System.Console.WriteLine($"{a} является квадратом {b}");

