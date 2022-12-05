// 56. Написать программу копирования массива

int[] MyArray(int size=10,int min=0,int max=100)
{
    int[] arr=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        arr[i]=random.Next(min,max+1);
    return arr;       
}

int[] MyArrayCopy(int[] arr)
{
    int[] copy=new int[arr.Length];
    for(int i=0;i<arr.Length;i++)
        copy[i] = arr[i];
    return copy;   
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

void PrintCopy(int[] b)
{
    for(int i=0;i<b.Length;i++)
        System.Console.Write($"{b[i],5}");
}

int[] a=MyArray(5,0,9);
Print(a);
System.Console.WriteLine();
int[] b=MyArrayCopy (a);
PrintCopy(b);
