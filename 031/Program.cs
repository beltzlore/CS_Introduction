// 31. Вывести на экран кубы чисел от 1 до N.

System.Console.Write("Введите число: ");
int N=Convert.ToInt32(System.Console.ReadLine());
for(int i=1;i<=N;i++)
{
    System.Console.WriteLine(Math.Pow(i,3));
}
