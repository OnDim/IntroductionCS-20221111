// 37. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

// Заполнение массива
int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;       
}

// Подпрограмма количество четных чисел
int NumberOfEven(int[] a)
{
    int s=0;
    for(int i=0;i<a.Length;i++)
        if (a[i]%2==0) s=s+1;
    return s;    
}

//Подпрограмма количество нечетных чисел.
int NumberOfOdde(int[] a)
{
    int s=0;
    for(int i=0;i<a.Length;i++)
        if (a[i]%2!=0) s=s+1;
    return s;  
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

//задаем массив
int[] a=RandomIntArray(5,100,999);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Количество положительных {NumberOfEven(a)}");
System.Console.WriteLine($"Количество отрицательных {NumberOfOdde(a)}");
