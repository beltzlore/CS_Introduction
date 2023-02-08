/* 15. С клавиатуры вводится целое число. 
Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).*/

int N, d2;
System.Console.Write("Введите число: ");
N=Convert.ToInt32(System.Console.ReadLine());
if (N<100)
{
    System.Console.WriteLine("NO");
}
else
{
    d2=N/100%10;
    System.Console.WriteLine($"Третья цифра числа: {d2}");
}



