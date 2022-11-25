// 26. Найти сумму чисел от 1 до А


int a = Convert.ToInt32(Console.ReadLine());
int i;
int sum = 0;
for (i=1; i <=a; i++)
{
    sum = sum+i;
}
Console.WriteLine(sum);
