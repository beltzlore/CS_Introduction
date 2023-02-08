// 8. Вывести на экран числа от -N до N.

System.Console.Write("Введите N: ");
int N=Convert.ToInt32(System.Console.ReadLine());
int i=-N;
while (i<=N)
{
    System.Console.WriteLine(i);
    i++;
}

