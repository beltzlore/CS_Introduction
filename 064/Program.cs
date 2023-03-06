// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные, на их квадраты по значению.

int[,] RandomArray(int N, int M, int min, int max)
{
    int[,] a=new int[N,M];
    Random random=new Random();
    for (int i=0;i<a.GetLength(0);i++)
        for (int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max+1);
    return a;
}

void PrintArray(int[,] a)
{
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
            System.Console.Write($"{a[i,j],5} ");
        System.Console.WriteLine();    
    }
    System.Console.WriteLine();
}    

int[,] ChangeArray(int[,] a)
{
    int[,] b=new int[a.GetLength(0),a.GetLength(1)];
    for (int i=0;i<a.GetLength(0);i++)
        for (int j=0;j<a.GetLength(1);j++)
        {
            if (i%2==0 && j%2==0) b[i,j]=a[i,j]*a[i,j];
            else b[i,j]=a[i,j];
        }
    return b;    
}

int row,column;
row=4;
column=3;
int[,] array=RandomArray(row,column,0,10);
PrintArray(array);
array=ChangeArray(array);
PrintArray(array);

