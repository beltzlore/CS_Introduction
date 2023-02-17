// 49. В указанном массиве целых чисел найдите разницу между максимальным и минимальным элементом.

int[] array=new int[10];
Random random=new Random();
for(int i=0;i<array.Length;i++)
    array[i]=random.Next(0,10);

for(int i=0;i<array.Length;i++)
    System.Console.Write($"{array[i]} ");
System.Console.WriteLine();

int max=array[0];
for(int i=1;i<array.Length;i++)
    max=int.Max(array[i],max);

int min=array[0];
for(int i=1;i<array.Length;i++)
    min=int.Min(array[i],min);

System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max-min}");

