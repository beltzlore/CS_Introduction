// 86. Подсчитать, сколько раз определенный символ (например 'a') встречается в строке.

int CharCount (string s, char f)
{
    int count=0;
    for (int i=0;i<s.Length;++i)
        if (s[i]==f) ++count;
    return count;
}

string s=Console.ReadLine();
char find=Convert.ToChar(Console.ReadLine());
System.Console.WriteLine($"Количество символа '{find}' = {CharCount(s,find)}");