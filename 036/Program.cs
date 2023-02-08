// 36. Написать программу вычисления произведения чисел от 1 до N.

System.Console.Write("Введите число: ");
int N=Convert.ToInt32(System.Console.ReadLine());
int factorial=1;
for (int i=2;i<=N;i++)
{
    factorial*=i;
}
System.Console.WriteLine($"Факториал {N} = {factorial}");
