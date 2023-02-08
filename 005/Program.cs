// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел.

int a,b,c,max;
System.Console.Write("Введите a: ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b: ");
b=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите c: ");
c=Convert.ToInt32(Console.ReadLine());
max=a;
if (b>a)
{    
    max=b;
} 
if (c>max)
{
    max=c;
}

System.Console.WriteLine($"max={max}");

