// ConsoleKeyInfo keyInfo;
// do
// {
//     keyInfo=Console.ReadKey();
//     char c=keyInfo.KeyChar;
//     System.Console.WriteLine();
//     System.Console.WriteLine((int)c);
//     System.Console.WriteLine(keyInfo.KeyChar);
//     if (c>='0' && c<='9') System.Console.WriteLine("Digit");
//     if (c>='A' && c<='Z') System.Console.WriteLine("Big latin");
//     if (char.IsDigit(c)) System.Console.WriteLine("Digit");
//     System.Console.WriteLine(keyInfo.Key);
// }
// while (keyInfo.Key!=ConsoleKey.Escape);

// string s="Hello!"; //Неизменяемые immutable
// System.Console.WriteLine(s[2]);
// char[] chars=s.ToCharArray();
// chars[0]='h';
// s=new string(chars);
// System.Console.WriteLine(s);

// ReadLn(a,b,c) 3 4 5 

// Ввод нескольких значений

// string s=Console.ReadLine();
// string[] s1=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
// int[] a=new int[s1.Length];
// // for (int i=0;i<a.Length;++i)
// //     a[i]=Convert.ToInt32(s1[i]);
// int[] b=Array.ConvertAll<string,int>(s1,Convert.ToInt32); 
// for (int i=0;i<s1.Length;++i)
//     System.Console.WriteLine(b[i]);

// Sring VS StringBuilder

// using System.Text;
// System.Diagnostics.Stopwatch stopwatch=new System.Diagnostics.Stopwatch();
// stopwatch.Start();
// string s="";
// int N=30000;
// for (int i=0;i<N;++i)
//     s=s+"ABCDEFGHIGKLMNOPQRSTUVWXYZ";
// stopwatch.Stop();
// System.Console.WriteLine(stopwatch.ElapsedMilliseconds);
// stopwatch.Reset();
// stopwatch.Start();
// StringBuilder sb=new StringBuilder();
// for (int i=0;i<N;++i)
//     sb.Append("ABCDEFGHIGKLMNOPQRSTUVWXYZ");
// stopwatch.Stop();
// string s3=sb.ToString();
// System.Console.WriteLine(stopwatch.ElapsedMilliseconds);

int a=1,b=1;
Random r1=new Random(100);
Random r2=new Random(100);
System.Console.WriteLine(a==b);
System.Console.WriteLine(r1==r2);
string s1="Hello!";
string s2="hello!";
System.Console.WriteLine(s1==s2);
System.Console.WriteLine(s1.IndexOf("He"));
System.Console.WriteLine(s1.ToLower());
System.Console.WriteLine(s1.Concat(s2));

string[] s3=new string[3];
s3[0]="word";
s3[1]="word";
s3[2]="word";
string s4=String.Join(" ",s3); // Статический метод
System.Console.WriteLine(s4);
