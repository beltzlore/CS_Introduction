// 11. Дано число больше 9. Вывести на экран вторую цифру числа с конца.

System.Console.Write("Введите число: ");
int N=Convert.ToInt32(System.Console.ReadLine());
int d0,d1,d2;
d0=N%10;
d1=N/10%10;
d2=N/100;
System.Console.WriteLine($"Вторая цифра числа с конца: {d1}");
