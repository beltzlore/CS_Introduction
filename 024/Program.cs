// 24. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0.//


System.Console.Write("Введите абсциссу точки: ");
double x=Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("Введите ординату точки: ");
double y=Convert.ToDouble(System.Console.ReadLine());
if (x>0 && y>0) System.Console.WriteLine("Точка находится в 1-й четверти");
if (x<0 && y>0) System.Console.WriteLine("Точка находится во 2-й четверти");
if (x<0 && y<0) System.Console.WriteLine("Точка находится в 3-й четверти");
if (x>0 && y<0) System.Console.WriteLine("Точка находится в 4-й четверти");