// Подсчитать количество цифр и сумму цифр.

int N=1234;
int counter=0;//счётчик
int sum=0;//сумматор

while (N!=0)
{
    counter++;
    int d=N%10;
    sum+=d;
    N/=10;
}
System.Console.WriteLine(counter);
System.Console.WriteLine(sum);