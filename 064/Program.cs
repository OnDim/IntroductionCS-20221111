// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

// Подпрограмма ввода двумерного массива

int[,] Random2DArray(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
        for(int j=0;j<m;j++)
           a[i,j]=random.Next(min,max+1);
    return a;       
}

// Печать двумерного массива (из подпрограммы) на экран

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
            for(int j=0;j<a.GetLength(1);j++)
                System.Console.Write($"{a[i,j],4}");
                    System.Console.WriteLine();
        }
}
// Замена четных элементов на их квадраты по значению (a[i,j]=a[i,j])

void MathPow2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
                if (i%2==0 && j%2==0)
                    a[i,j]=a[i,j]*2;
}

// Основная программа

int[,] a=Random2DArray(5,5);
Print2DArray(a);
System.Console.WriteLine();
MathPow2DArray(a);
Print2DArray(a);
