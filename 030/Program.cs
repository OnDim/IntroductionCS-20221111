// 30. Написать программу вычисления произведения чисел от 1 до N

int n = Convert.ToInt32(Console.ReadLine());
int i;
int multiplication = 1;
for (i=1; i <=n; i++)
{
    multiplication = multiplication*i;
}
Console.WriteLine(multiplication);