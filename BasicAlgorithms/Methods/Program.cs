// Напишите подпрограмму нахождения расстояния между двумя точками.

double x1=0,y1=0,x2=2,y2=2;
double distance=Distance(x1,y1,x2,y2);
System.Console.WriteLine(distance);

double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
}