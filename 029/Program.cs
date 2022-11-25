// 29. Подсчитать сумму цифр в числе. Сделать подпрограмму.

/*
int a = int.Parse(Console.ReadLine());
int s = 0;
    while (a > 0)
    { 
        s = s + a % 10;
        a = a /10 ;
    }
 Console.WriteLine(s);
*/

int a = Convert.ToInt32(Console.ReadLine());
int Sum (int a)
{
int s=0;
while (a>0)
{ 
    s = s + a % 10;
    a = a /10 ;
}
    return s;
}  
Console.WriteLine(Sum(a));