// 80. Вывести на экран кодировку символов по ASCII(с 32 до 122)

int min=int.Parse(Console.ReadLine());
int max=int.Parse(Console.ReadLine());
for (int i=min; i<=max; i++)
    Console.WriteLine(i.ToString() + "-й символ таблицы ASCII: " + (char)i);
