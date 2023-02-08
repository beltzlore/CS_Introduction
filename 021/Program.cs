// Дано число, обозначающее день недели. Выяснить, является ли этот день выходным.

System.Console.WriteLine("Введите номер дня недели");
int day=Convert.ToInt32(System.Console.ReadLine());
if (day==6 || day==7) System.Console.WriteLine("Выходной");
else
    if (day>=1 && day<=5) System.Console.WriteLine("Рабочий");
    else
        System.Console.WriteLine("Это не день недели");
