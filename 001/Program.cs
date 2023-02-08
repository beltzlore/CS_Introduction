// 1. С клавиатуры вводится целое число. Вывести квадрат числа.

System.Console.Write("Введите число: ");
string? s;
int a;
s=Console.ReadLine();
a=Convert.ToInt32(s);

Console.WriteLine(Math.Pow(a, 2));
