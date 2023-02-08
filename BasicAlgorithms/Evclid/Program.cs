int a=75,b=15;
int a1=a,b1=b;
while(a!=b)
    if (a>b)
        a-=b;
    else
        b-=a;
System.Console.WriteLine("NOD="+a);
System.Console.WriteLine("NOK="+(a1*b1)/a);