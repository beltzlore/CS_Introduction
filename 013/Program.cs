// 13. Удалить вторую цифру целого числа, введенного с клавиатуры.

int N,d0,d1;
System.Console.Write("Введите число: ");
N=Convert.ToInt32(System.Console.ReadLine());
d0=N%10;
d1=N/100;
System.Console.WriteLine(d1*10+d0);