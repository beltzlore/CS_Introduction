// 82. C клавиатуры вводится строка, разделенная точкой. Подсчитать количество символов до точки.

int Count (string s)
{
    string[] strings=s.Split('.');
    string string0=strings[0];
    return string0.Length;
}

string s=Console.ReadLine();
System.Console.WriteLine(Count(s));