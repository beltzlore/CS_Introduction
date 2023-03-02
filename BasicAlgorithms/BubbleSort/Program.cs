// Сортировка пузырьком

int BubbleSort(int[] arr)
{
    int k=0;
    for (int j=0;j<arr.Length;j++)
    {
        for (int i=0;i<arr.Length-1-j;i++)
        {
            if (arr[i]>arr[i+1])
            {
                int t=arr[i];
                arr[i]=arr[i+1];
                arr[i+1]=t;
                k++;
            }
        }
    }    
    return k;
}

void PrintArray(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
        System.Console.Write($"{arr[i],5}");
}

int[] array={12, 54, 34, 2, 1, 76, 105, 13};
int k=BubbleSort (array);
Console.WriteLine($"{k}");
PrintArray(array);

