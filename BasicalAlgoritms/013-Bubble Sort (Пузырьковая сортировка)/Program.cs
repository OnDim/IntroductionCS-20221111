// Пзырьковая сорторовка

// Подпрограмма - "Инициализация массива"
int[] RamdomIntArray(int N,int min,int max)
{
    int[] a=new int[N];
    Random random=new Random(); //Генерация псевдослучайных чисел
    for(int i=0;i<a.Length;i++) //Алгоритм генерации массива
        a[i]=random.Next(0,200);  
    return a;
}

// Подпрограмма - "Вывод массива на экран"
void PrintArray(int[] a)
{
    for(int i=0;i<a.Length;i++)     
        System.Console.Write($"{a[i],5}");
}

// Обработка массива в соответствии с условиями задачи

void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void BubbleSort(int[] a)
{
    for(int i=0;i<a.Length;i++)
        for(int j=0;j<a.Length-1-i;j++)
            if (a[j]>a[j+1])
                Swap(ref a[j],ref a[j+1]);

}


int [] a =RamdomIntArray(10,0,10);
PrintArray(a);
BubbleSort(a);
System.Console.WriteLine();
PrintArray(a);