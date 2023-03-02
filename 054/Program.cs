// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
// Принять первые числа равными 0 и 1.

void Fibonacci(int[] a)
{
    a[0]=0;
    a[1]=1;
    for (int i=2;i<a.Length;i++)
    {
        a[i]=a[i-1]+a[i-2];
    }
}

void PrintArray(int[] a)
{
for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();
}

int N=Convert.ToInt32(Console.ReadLine());
int[] fib=new int[N];
Fibonacci(fib);
PrintArray(fib);




