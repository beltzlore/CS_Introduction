// 47. Найти сумму чисел одномерного массива, стоящих на нечетной позиции.

int[] array=new int[10];
Random random=new Random();
for(int i=0;i<array.Length;i++)
    array[i]=random.Next(-9,10);

for(int i=0;i<array.Length;i++)
    System.Console.Write($"{array[i]} ");
System.Console.WriteLine();

int sum=0;
for(int i=1;i<array.Length;i+=2)
    sum=sum+array[i];
System.Console.WriteLine($"Сумма элементов на нечётных позициях: {sum}");

