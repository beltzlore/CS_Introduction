// Двумерный массив

int[,] a=new int[4,3]{{1,2,3},
                      {1,2,3},
                      {1,2,3},
                      {1,2,3}};

for (int i=0;i<a.GetLength(0);i++)
    for (int j=0;j<a.GetLength(1);j++)
        a[i,j]=i*10+j;
for (int i=0;i<a.GetLength(0);i++)
{
    for (int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],5}");
    System.Console.WriteLine();    
}