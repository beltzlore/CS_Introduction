// See https://aka.ms/new-console-template for more information

string s="ПОТОП";
char[] s1=s.Reverse().ToArray();
string s2=new String(s1);
System.Console.WriteLine($"{s} >> {s2}");
if (s==s2) 
{
    System.Console.WriteLine("Палиндром");
}
else
{
    System.Console.WriteLine("Не палиндром");
}