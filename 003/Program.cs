// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них. 

int a,b,max;
System.Console.Write("Введите a: ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b: ");
b=Convert.ToInt32(Console.ReadLine());
max=a;
if (b>a)
{    
    max=b;
}
System.Console.WriteLine($"max={max}");
