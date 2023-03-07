// 74. Найти сумму цифр числа.

int SumOfDigits (int N)
{
    if (N==0) return 0;
    else return SumOfDigits(N/10)+N%10;
}

System.Console.WriteLine(SumOfDigits(1234));