﻿// По номеру месяца определить время года. Условие с ИЛИ.
int month=4;
if (month==1 || month==2 || month==3)
{
    System.Console.WriteLine("Winter");
}
if (month==4 || month==5 || month==6)
{
    System.Console.WriteLine("Spring");
}
if (month==7 || month==8 || month==9)
{
    System.Console.WriteLine("Summer");
}
if (month==10 || month==11 || month==12)
{
    System.Console.WriteLine("Autumn");
}

// Вводится возраст человека и нужно определить, подходит ли он для работы. Условие с И.
int age=15;
if (age>=25 && age<=45) 
{
    System.Console.WriteLine("Подходит");
}
else
{
    System.Console.WriteLine("Не подходит");
}