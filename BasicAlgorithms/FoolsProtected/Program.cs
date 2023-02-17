int a;
bool f;
do
{
    f=int.TryParse(Console.ReadLine(), out a);
    if (!f)
    {
        System.Console.WriteLine("Error!");
    }
    else
    {
        System.Console.WriteLine(a);
    }
}
while(!f);
