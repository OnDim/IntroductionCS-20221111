// Алгоритм Эвклида

/*int a=30;
int b=15;

while(a!=b)
    if (a>b)
        a=a-b;
    else
        b=b-a;
System.Console.WriteLine(a);    
*/

/* Алгоритм Эвклида со счетчиком 
int k=0;
int GCD(int a, int b)
{
    while(a!=b)
    {
        k++;
        if (a>b)
            a=a-b;
        else
            b=b-a;
    }
    return a;
}
System.Console.WriteLine(GCD(1,5000));
System.Console.WriteLine(k);
*/

// Ускоренный алгоритм Эвклида
int k=0;
int QuickGCD(int a, int b)
{
    while(a!=0 && b!=0)
    {
        k++;
        if (a>b)
            a=a%b;
        else
            b=b%a;
    }
    return a+b;
}
System.Console.WriteLine(QuickGCD(1,5000));
System.Console.WriteLine(k);