// 71. Показать натуральные числа от N до 1, N задано.

void ReverseNumberSeries (int N)
{
    if (N!=0)
    {
        System.Console.Write($"{N} ");
        ReverseNumberSeries(N-1);
    }
}  

ReverseNumberSeries(120);
