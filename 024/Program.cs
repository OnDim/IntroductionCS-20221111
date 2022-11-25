// 24. Вывести на экран таблицу квадратов чисел от 1 до N

/*
int Square (int sqr, int n)
{
    int i=1;
    while(i<=n)
    {
        sqr=i*i;
    }
    return sqr;
    i++;   
}
*/

int n=Convert.ToInt32(Console.ReadLine());
for (int i=1;i<=n;i++)
System.Console.WriteLine($"{i}, {Math.Pow(i,2)}");
    