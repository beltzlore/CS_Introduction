// 9. Вывести на экран четные числа от 1 до N.
int i=2;
int N;
System.Console.Write("Введите N: ");
N=Convert.ToInt32(System.Console.ReadLine());
while(i<=N)
{
    System.Console.WriteLine(i);
    i+=2;
}
