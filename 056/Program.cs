// 56. Написать программу копирования массива.

void FillArray(int[] a)
{
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
    {
        a[i]=random.Next(0,100);
    }
}

void CopyArray(int[] a, int[] b)
{
    for (int i=0;i<a.Length;i++)
    {
        b[i]=a[i];
    }
}

void PrintArray(int[] a)
{
for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();
}

int length=10;
int[] a=new int[length];
int[] b=new int[length];
FillArray(a);
PrintArray(a);
CopyArray(a,b);
PrintArray(b);
