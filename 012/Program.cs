// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа.

System.Console.Write("Введите число: ");
int N=Convert.ToInt32(System.Console.ReadLine());
int d0,d1;
d0=N%10;
d1=N/10;
if (d0>d1) 
{
    System.Console.WriteLine($"Наибольшая цифра числа: {d0}");
}
else
{
    System.Console.WriteLine($"Наибольшая цифра числа: {d1}");
}