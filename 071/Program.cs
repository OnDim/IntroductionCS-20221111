// 71. Показать натуральные числа от 1 до N, N задано 

void PoPorydky(int N,int i)
{
    if (i<=N)
    {
        System.Console.WriteLine(i);
        PoPorydky(N,i+1);
    }
}
PoPorydky(15,1);