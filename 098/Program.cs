// 98. Показать треугольник Паскаля.

int PascalsTriangle (int i, int j)
{
	int t=0;
	if (i==1 && j==0) t=1;
	if (j>0 && i>0) t=PascalsTriangle(i-1,j-1)+ PascalsTriangle(i,j-1);
	return t;
}

void PrintTriangle (int[,] m)
{
	for (int j=0;j<m.GetLength(1);++j)
	{
		for (int i=0;i<=j+1;++i)
			System.Console.Write($"{m[i,j],4}");
		System.Console.WriteLine();
	}
}

int size=10;
int[,] triangle = new int [size+1,size];
for (int i=0;i<size+1;++i)
	for (int j=0;j<size;++j)	
		triangle[i,j]= PascalsTriangle(i,j);
PrintTriangle(triangle);
