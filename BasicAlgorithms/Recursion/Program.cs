// Вывести на экран числа от 1 до N без использования циклов.

void Loop (int i, int N)
{
    System.Console.Write($"{i,4}");
    if (i<N) Loop(i+1,N);
}

// Факториал

int F (int N)
{
    if (N>0) return F(N-1)*N;
    else return 1;
}

// Числа Фибоначчи

int Fib (int N)
{
    if (N==0) return 0;
        else
            if (N==1) return 1;
                else
                    return Fib(N-1)+Fib(N-2);
}

// Возведение в степень

double Power (int a, int b)
{
    if (b==0) return 1;
    else 
        if (b>0) 
            return Power(a,b-1)*a;
        else    
            return Power(a,b+1)*1/a;
}

Loop(1,20);
System.Console.WriteLine();
System.Console.WriteLine(F(5));
System.Console.WriteLine(Fib(5));
System.Console.WriteLine(Power(2,-3));