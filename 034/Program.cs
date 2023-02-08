// 34. Определить количество цифр в числе. Сделать подпрограмму.

int DigitsCounter(int n)
{
    if (n==0) return 1;
    int counter=0;
    while(n!=0)
    {
        counter++;
        n/=10;
    }
    return counter;
}

int N=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(DigitsCounter(N));