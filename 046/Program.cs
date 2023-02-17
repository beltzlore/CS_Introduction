// 46. Создать массив из 123 элементов. Заполнить случайными положительными числами от 0 до 1000. 
// Найти количество элементов, которые принадлежат отрезку [10,99].

void FillArray(int[] arr)
{
    Random random=new Random();
    for(int i=0;i<arr.Length;i++)
        arr[i]=random.Next(0,1001);
}

void PrintArray(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
        System.Console.Write($"{arr[i]} ");
    System.Console.WriteLine();
}

int FindCount(int[] arr)
{
    int count=0;
    for(int i=0;i<arr.Length;i++)
        if(arr[i]>=10 && arr[i]<=99) count++;
    return count;
}

int[] array=new int[123];
FillArray(array);
PrintArray(array);
System.Console.WriteLine($"Количество элементов из отрезка [10,99]: {FindCount(array)}");
