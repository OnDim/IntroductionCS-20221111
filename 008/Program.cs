// 8. Вывести на экран числа от -N до N
int n = Convert.ToInt32(Console.ReadLine());
int i = -n;
while (i <= n)
{
    Console.Write($"{i} ");
    i++ ;
}