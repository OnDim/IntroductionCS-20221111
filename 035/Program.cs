// 35. Написать программу замены элементов массива на противоположные

int[] RandomIntArray(int size=5, int min=0, int max=10)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;       
}

// Подпрограмма замена элементов массива на противоположные
void Change(int[] a)
{    
    for(int i=0;i<a.Length;i++)
    {
        if (a[i]>0) a[i]=-a[i];
        else
        a[i]=a[i]*-1;      
    }
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] myArray=RandomIntArray(5,-9,9);
Console.WriteLine("Исходный массив:");
      Print(myArray);
      Change(myArray);
      System.Console.WriteLine();
Console.WriteLine("Измененный массив:");
      Print(myArray);
/*//задаем массив
int[] a=RandomIntArray(5,-9,9);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Измененный массив {Change(a)}");*/

 