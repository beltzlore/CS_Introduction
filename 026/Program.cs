// Программа проверяет пятизначное число на палиндромом. 

System.Console.Write("Введите пятизначное число: ");
int N=Convert.ToInt32(System.Console.ReadLine());
if (N%10==N/10000 && N/10%10==N/1000%10) System.Console.WriteLine("Это палиндром");
else System.Console.WriteLine("Это не палиндром");
