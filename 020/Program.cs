// 20. Дано число. Проверить, кратно ли оно 7 и 23.

System.Console.Write("Введите число: ");
int N=Convert.ToInt32(System.Console.ReadLine());
if (N%7==0) System.Console.WriteLine($"{N} кратно 7");
if (N%23==0) System.Console.WriteLine($"{N} кратно 23");