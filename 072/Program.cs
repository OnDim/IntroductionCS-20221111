// 72. Показать натуральные числа от N до 1, N задано

void PoPorydky(int N,int i)
{
    if (i<=N)
    {
        System.Console.WriteLine(i);
        PoPorydky(N,i+1);
    }
}
PoPorydky(15,1);
