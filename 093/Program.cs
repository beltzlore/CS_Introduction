// 93. Задайте две матрицы. Напишите программу с подпрограммой MultiMatrix,
// которая  будет находить произведение двух матриц. 
// а) простым поэлементным перемножением.

int[,] MultiMatrix (int[,] m1, int[,] m2)
{
	int[,] m = new int[m1.GetLength(0),m1.GetLength(1)];
	for (int i=0;i<m.GetLength(0);++i)
		for (int j=0;j<m.GetLength(1);++j)
			m[i,j]=m1[i,j]*m2[i,j];
	return m;
}

void PrintMatrix (int[,] m)
{
	for (int i=0;i<m.GetLength(0);++i)
	{
		for (int j=0;j<m.GetLength(1);++j)
			System.Console.Write($"{m[i,j],4}");
		System.Console.WriteLine();
	}
}

int[,] matrix1 = { {1, 4, 7, 2},
                             {5, 9, 2, 3},
                             {8, 4, 2, 4},
                             {5, 2, 6, 7}};
int[,] matrix2 = { {1, 5, 8, 5},
                             {4, 9, 4, 2},
                             {7, 2, 2, 6},
                             {2, 3, 4, 7}};
int[,] matrix3 = MultiMatrix (matrix1, matrix2);
PrintMatrix (matrix3);
