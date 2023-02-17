/* 48. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
Создайте массив, который является произведением пар чисел в одномерном массиве a. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
а) вариант, когда в массиве четное кол-во элементов. 
б) * вариант когда в массиве и четное и не четное кол-во элементов*/

void FillArray(int[] arr)
{
    Random random=new Random();
    for(int i=0;i<arr.Length;i++)
        arr[i]=random.Next(1,11);
}

void PrintArray(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
        System.Console.Write($"{arr[i]} ");
    System.Console.WriteLine();
}

void CreateArray(int[] arr, int[] newarr)
{
    for(int i=0;i<newarr.Length;i++)
        newarr[i]=arr[i]*arr[arr.Length-1-i];
}

System.Console.Write("Введите количество элементов массива: ");
int N=Convert.ToInt32(System.Console.ReadLine());
int[] a=new int[N];
FillArray(a);
PrintArray(a);
int[] b=new int[N/2+N%2];
CreateArray(a,b);
PrintArray(b);