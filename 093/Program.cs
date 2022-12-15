// 93. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Ввода двумерного массива

int[,] Random2DMatrix(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
        for(int j=0;j<m;j++)
           a[i,j]=random.Next(min,max+1);
    return a;       
}


// Печать двумерного массива (из подпрограммы) на экран

void Print2DMatrix(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
            for(int j=0;j<a.GetLength(1);j++)
                System.Console.Write($"{a[i,j],4}");
                    System.Console.WriteLine();
        }
}


// Умножение матриц (по элементам)

int [,] Multi (int[,] a, int[,] b)
{
    int [,] c = new int[a.GetLength(0), b.GetLength(1)];
    for (int i=0; i<b.GetLength(1); i++)
    {    
        for (int j=0; j<b.GetLength(0);j++)
        {
            c[i,j]=0;
            c[i,j] = a[i,j] * b[i,j];
        }
    }
    return c;
}    

// Основная программа

System.Console.WriteLine("Программа для умножения матриц");
int[,] MatrixA=Random2DMatrix(3,3);
int[,] MatrixB=Random2DMatrix(3,3);

System.Console.WriteLine("Матрица А: ");
Print2DMatrix(MatrixA);
System.Console.WriteLine();
System.Console.WriteLine("Матрица В: ");
Print2DMatrix(MatrixB);
System.Console.WriteLine();
System.Console.WriteLine("По элементное произведение матриц А и В; ");
int [,] MatrixC = Multi(MatrixA, MatrixB);
Print2DMatrix(MatrixC);
