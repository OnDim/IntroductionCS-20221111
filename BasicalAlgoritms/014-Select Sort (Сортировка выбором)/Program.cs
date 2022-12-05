// Сортировка выбором

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

void SelectSort(int[] a,out int count)
{
    count=0;
    int im;
    for(int i=0;i<a.Length;i++)
    {
        im=i;
        for(int j=i+1;j<a.Length;j++) if (a[im]>a[j]) im=j;
        Swap(ref a[i], ref a[im]);        
    }
}

int [] a =RamdomIntArray(10,0,10);
PrintArray(a);
int count=0;
SelectSort(a, out count);
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine(count);