void Swap(ref int x, ref int y)
{
// Стандартный обмен
int t=x;
x=y;
y=t;
}

void Calculator (int a, int b, out int sum, out int sub)
{
    sum=a+b;
    sub=a-b;
}
// Обмен без создания третьей переменной (только для целых чисел)
// a=a+b;
// b=a-b;
// a=a-b;
int a=4;
int b=5;
System.Console.WriteLine($"a={a} b={b}");
Swap(ref a, ref b);
System.Console.WriteLine($"a={a} b={b}");
Calculator(a,b,out int s,out int sb);
System.Console.WriteLine($"sum={s} sub={sb}");