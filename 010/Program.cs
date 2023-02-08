// 10. Вывести на экран последнюю цифру целого числа, введенного с клавиатуры. 

System.Console.Write("Введите число: ");
int N=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Последняя цифра числа: {N%10}");
