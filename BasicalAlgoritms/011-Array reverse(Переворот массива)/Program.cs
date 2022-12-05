// Переворот массива

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

void Reverse(int[] a)
{
    for(int i=0;i<a.Length/2;i++)
        Swap(ref a[i],ref a[a.Length-1-i]);
}

// Основна программа
int N=10;
int[] a=RamdomIntArray(N,0,200);
PrintArray(a);
System.Console.WriteLine();
Reverse(a); // использование собственного метода
//a=a.Reverse().ToArray(); //Использование стандартной функции, без написания отдельной подпрограммы
PrintArray(a);
 