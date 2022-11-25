// 28. Определить количество цифр в числе. Сделать подпрограмму.

/* без использования подпрограмм
int N=Convert.ToInt32(Console.ReadLine());
N=Math.Abs(N);
int count=0;
while (N>0)
{
    N=N/10;
    count++;
}
System.Console.WriteLine(count);
*/


// Подпрограмма
int CountDigits(int Number)
{
    Number=Math.Abs(Number);
    int count=0;
    if (Number==0) count=1;
    while (Number>0)
    {
        Number=Number/10;
        count++;
    }
    return count;
}

// Основная программа
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountDigits(N));