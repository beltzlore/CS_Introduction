﻿// 42. Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива.

int[] array=new int[12];
Random random=new Random();
for(int i=0;i<array.Length;i++)
    array[i]=random.Next(-9,10);
    
for(int i=0;i<array.Length;i++)
    System.Console.Write($"{array[i]} ");
System.Console.WriteLine();

int sp=0;
for(int i=0;i<array.Length;i++)
    if (array[i]>0)
        sp=sp+array[i];

int sn=0;
for(int i=0;i<array.Length;i++)
    if (array[i]<0)
        sn=sn+array[i];

System.Console.WriteLine($"Сумма положительных чисел: {sp}");
System.Console.WriteLine($"Сумма отрицательных чисел: {sn}");