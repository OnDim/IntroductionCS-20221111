// 31. Сгенирировать 10 случайных чисел. Показать кубы чисел, заканчиваюся
// на четную цифру.

/*
int r=10;
double t=r; // не явное приведение типов

double x=32:
//int o=Convert.ToInt32(x); // Есть возможность сделать конвертацию (действие)

int o=(int)x; // явное приведение типов - ответственность на программисте
*/

bool Test(int a)
{
    //if (a%2==0) return true; else return false;
    return a*a*a%10%2==0;
}


Random random=new Random(10);
for(int i=0;i<20;i++)
{
    int a=random.Next(1,100);
    int b=(int)Math.Pow(a,3);
    if (Test(b))
    System.Console.WriteLine($"{a}, {b}");
}