// 61. Показать двумерный массив размером m×n, заполненный вещественными случайными числами.

double[,] Random2DArrayDouble(int N, int M, int min, int max)
{
    double[,] a=new double[N,M];
    Random random=new Random();
    for (int i=0;i<a.GetLength(0);i++)
        for (int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.NextDouble();
    return a;
}

void Print2DArray(double[,] a)
{
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
            System.Console.Write($"{a[i,j],5:F2} ");
        System.Console.WriteLine();    
    }
}    

double[,] a=Random2DArrayDouble(3,4,0,10);
Print2DArray(a);