// Инверсия массива

void Swap (ref int a, ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void PrintArray(int[] a)
{
for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();
}

void ReverseArray(int[] a)
{
    for (int i=0;i<a.Length/2;i++)
    {
        Swap(ref a[i], ref a[a.Length-1-i]);
    }
}

int[] a={3,2,7,1,9};
PrintArray(a);
ReverseArray(a);
PrintArray(a);