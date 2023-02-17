// 44. Определить, присутствует ли в заданном массиве, некоторое число.
// Линейный поиск

int[] array=new int[10];
Random random=new Random();
for(int i=0;i<array.Length;i++)
    array[i]=random.Next(-9,10);

for(int i=0;i<array.Length;i++)
    System.Console.Write($"{array[i]} ");
System.Console.WriteLine();

int find=5;
int j=0;
while(j<array.Length && array[j]!=find) j++;

if(j==array.Length)
    System.Console.WriteLine("NO");
else    
    System.Console.WriteLine($"Element {find} found at index {j}");