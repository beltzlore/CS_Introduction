﻿// 41. Задать массив из 8 элементов, заполненных нулями и единицами, вывести их на экран.

int[] array=new int[8];
Random random=new Random();
for(int i=0;i<array.Length;i++)
    array[i]=random.Next(0,2);

for(int i=0;i<array.Length;i++)
    System.Console.Write($"{array[i]} ");
