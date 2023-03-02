// 52. Написать программу преобразования десятичного числа в двоичное.

int N=6;
int N2=0;
int k=0;
while(N!=0)
{
    N2=N2+N%2*(int)Math.Pow(10,k);
    N=N/2;
    k++;
}

Console.WriteLine(N2);
