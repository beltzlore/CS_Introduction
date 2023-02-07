// С клавиатуры вводятся 2 числа. Найти и вывести на экран их сумму.

int a,b,sum;
System.Console.Write("Введите a: ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b: ");
b=Convert.ToInt32(Console.ReadLine());
sum=a+b;
// 1. Конкатенация (склеивание) строк
System.Console.WriteLine(a+"+"+b+'='+sum);
// 2. Форматированный вывод
System.Console.WriteLine("{0:F2}+{1:F2}={2:G4}",a,b,sum);
// 3. Интерполяция строк
System.Console.WriteLine($"{a}+{b}={sum}");

// С клавиатуры вводятся 2 числа. Найти и вывести на экран максимальное из них.
int max;
if (a>b)
{    
    max=a;
}
else  
{  
    max=b;
}
System.Console.WriteLine($"max={max}");