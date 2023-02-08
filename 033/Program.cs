// 33. Возведите число А в натуральную степень B, используя цикл.

System.Console.Write("Введите число A: ");
int A=Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число B: ");
int B=Convert.ToInt32(System.Console.ReadLine());
int C=1;
for(int i=1;i<=B;i++)
{
    C*=A;
}
System.Console.WriteLine($"{A} в степени {B} = {C}");
