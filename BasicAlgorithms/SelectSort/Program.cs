// Сортировка выбором

void SelectSort (int[] arr)
{
    for (int j=0;j<arr.Length;j++)
    {
        int iM=j;
        for (int i=j+1;i<arr.Length;i++)
        {
            if (arr[i]<arr[iM])
            {
                iM=i;
            }
        }
        int t=arr[j];
        arr[j]=arr[iM];
        arr[iM]=t;
    }
}

void PrintArray(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
        System.Console.Write($"{arr[i],5}");
}

int[] array={12, 54, 34, 2, 1, 76, 105, 13};
SelectSort (array);
PrintArray(array);
