// Обмен значениями двух переменных
int a=5;
int b=7;
// КЛАССИЧЕСКИЙ СПОСОБ. - Обмнен двух переменных производится с использованием третьей.
/*int temp;
temp=a;
a=b;
b=temp;*/

// Без использования третьей переменной
/*a=a+b;
b=a-b;
a=a-b;
*/

// Сложный способ - для разбора
a=a^b;
b=a^b;
a=a^b;
System.Console.WriteLine($"a={a} b={b}");
