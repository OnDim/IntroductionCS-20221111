// Вывести числа от 1 до N без использования цикла

void Loop(int N,int i)
{
    if (i<=N)
    {
        System.Console.WriteLine(i);
        Loop(N,i+1);
    }
}
Loop(10,1);