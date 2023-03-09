// 84. Определить, являются ли введенные с клавиатуры символы правильной записью целого числа. 
// Вычислить сумму цифр введенного числа.

bool IsInt (string s)
{
    if (s[0]!='-' && !char.IsDigit(s,0)) return false;
    for (int i=1;i<s.Length;++i)
            if (!char.IsDigit(s,i)) return false;
    return true;
}

int SumOfDigits (string s)
{
    int sum=0;
    if (char.IsDigit(s,0)) sum+=Convert.ToInt32(s[0].ToString());
    for (int i=1;i<s.Length;++i)
        sum+=Convert.ToInt32(s[i].ToString());
    return sum;
}

string s=Console.ReadLine();
if (IsInt(s)) 
    System.Console.WriteLine($"Целое число, сумма его цифр {SumOfDigits(s)}");
        else
            System.Console.WriteLine("Не является целым числом");
