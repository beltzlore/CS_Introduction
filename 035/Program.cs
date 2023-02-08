// 35. Подсчитать сумму цифр в числе. Сделать подпрограмму.

int SumDigits(int N)
{
    int sum=0;
    while (N!=0)
    {
        int d=N%10;
        sum+=d;
        N/=10;
    }
    return sum;
}

System.Console.Write("Введите число: ");
int N=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Сумма цифр числа = {SumDigits(N)}");