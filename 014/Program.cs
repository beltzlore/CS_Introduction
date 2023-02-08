/* 14. С клавиатуры вводятся два числа a и b. 
Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.*/

int a,b,odd;
System.Console.Write("Введите число a: ");
a=Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число b: ");
b=Convert.ToInt32(System.Console.ReadLine());
odd=a%b;
if (odd!=0)
{
    System.Console.WriteLine($"Остаток от деления {a} на {b}: {odd}");
}
else 
{
    System.Console.WriteLine($"{a} кратно {b}");
}