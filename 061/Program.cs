// 61. Показать двумерный массив размером m×n заполненный вещественными случайными числами

// Подпрограмма ввода двумерного массива

double[,] Random2DArray(int n,int m,int min=0,int max=10)
{
    double[,] a=new double[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
        for(int j=0;j<m;j++)
           a[i,j]=random.NextDouble()*10;
    return a;       
}

// Печать двумерного массива (из подпрограммы) на экран

void Print2DArray(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
            for(int j=0;j<a.GetLength(1);j++)
                System.Console.Write($"{a[i,j]}"+"  ");
                    System.Console.WriteLine();
        }
}


// Основная программа

double[,] a=Random2DArray(5,3);
Print2DArray(a);
