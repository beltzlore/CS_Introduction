// 6. Написать программу вычисления значения функции y = sin(a). 

double a,y;
System.Console.Write("Введите угол в градусах: ");
a=Convert.ToDouble(System.Console.ReadLine());
y=Math.Sin(Math.PI*a/180); 
System.Console.WriteLine($"y={y:G4}");
