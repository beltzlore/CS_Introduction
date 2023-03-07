// 70. Показать натуральные числа от 1 до N, N задано.

void NumberSeries (int N)
{
    if (N!=0)
    {
        NumberSeries(N-1);
        System.Console.Write($"{N} ");
    }
}    

NumberSeries(120);
