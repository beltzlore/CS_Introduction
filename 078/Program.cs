// 78. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
// Принять первые числа равными 0 и 1. Использовать рекурсию.

int Fib (int N)
{
    int t=0;
    if (N<3) t=N-1;
        else
           t=Fib(N-1)+Fib(N-2);
    return t;
}

System.Console.Write("Введите N: ");
int N=Convert.ToInt32(System.Console.ReadLine());
for (int i=1;i<=N;++i)
{
    System.Console.Write($"{Fib(i),4}");
}
