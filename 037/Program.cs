﻿// 37. Компьютер придумывает число и определяет, заканчивается ли куб этого числа на чётную цифру.

bool Test(int n)
{
    return n%2==0;
}

Random random=new Random();
for(int i=0;i<10;i++)
{
    int a=random.Next(1,100);
    int b=(int)Math.Pow(a,3);
    if (Test(a))
        System.Console.WriteLine($"{a},{b}");
}

