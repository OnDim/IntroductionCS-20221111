// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
/*       
var n = int.Parse(Console.ReadLine());
Console.WriteLine("F1) 0");
Console.WriteLine("F2) 1");
int n_1 = 0;
int n_2 = 1;
 
for (int i = 3; i <= n; ++i)
{
    var n_3 = n_1 + n_2;
    Console.WriteLine("F{0}) {1}", i, n_3);
    n_1 = n_2;
    n_2 = n_3;
}
Console.ReadKey();
*/
// Второй вариант через массив

int m=10;
int[] a=new int[m];
a[0]=0;
a[1]=1;
for(int i=2;i<m;i++)
    a[i]=a[i-1]+a[i-2]; //рекурентная формула (следующее значение за счет использования предыдущих)
for(int i=0;i<m;i++)
    System.Console.Write($"{a[i]} ");