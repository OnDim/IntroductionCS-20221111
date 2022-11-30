/*// Модификатор "ref"

void Swap(ref int a, ref int b) // "ref"erence-ссылка
{
    int t=a;
    a=b;
    b=t;
}

void Calculator(int a,int b,ref int sum,ref int multi)
{
    sum=a+b;
    multi=a*b;
}

int a=3,b=5;

System.Console.WriteLine($"a={a} b={b}");
Swap(ref a,ref b);
System.Console.WriteLine($"a={a} b={b}");
int sum=0,multi=0;
Calculator(a,b,ref sum,ref multi);
*/


//Модификатор "out"
void Swap(ref int a, ref int b) // "ref"erence-ссылка
{
    int t=a;
    a=b;
    b=t;
}

void Calculator(int a,int b,out int sum,out int multi)
{
    sum=a+b;
    multi=a*b;
}

int a=3,b=5;

System.Console.WriteLine($"a={a} b={b}");
Swap(ref a,ref b);
System.Console.WriteLine($"a={a} b={b}");
int sum,multi;
Calculator(a,b,out sum,out multi);

// Метод "TryParse" с модификатором "out"
bool flag;
int x;
do
{
    flag=int.TryParse(Console.ReadLine(),out x);
    if (flag==false) System.Console.WriteLine("Введите целое число: ");
}
while(flag==false);