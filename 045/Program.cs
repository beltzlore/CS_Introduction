// 45. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел.

void FillArray(int[] arr)
{
    Random random=new Random();
    for(int i=0;i<arr.Length;i++)
        arr[i]=random.Next(100,1000);
}

void PrintArray(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
        System.Console.Write($"{arr[i]} ");
    System.Console.WriteLine();
}

bool IsEven(int value)
{
    return value%2==0;    
}

int OddCount(int[] arr)
{
    int count=0;
    for(int i=0;i<arr.Length;i++)
        if(!IsEven(arr[i])) count++;
    return count;
}

int EvenCount(int[] arr)
{
    int count=0;
    for(int i=0;i<arr.Length;i++)
        if(IsEven(arr[i])) count++;
    return count;
}

int[] array=new int[10];
FillArray(array);
PrintArray(array);
System.Console.WriteLine($"Количество нечётных чисел: {OddCount(array)}");
System.Console.WriteLine($"Количество чётных чисел: {EvenCount(array)}");