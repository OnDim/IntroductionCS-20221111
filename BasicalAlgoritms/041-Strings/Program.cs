//String

string s="asdf";
// immutable string (не изменяемые строки)
System.Console.WriteLine(s[0]); //можно обращаться к любому элементу строки (как в масивах)

//s[0]='S' // В строках так сделать нельзя
// Для внесения изменений в строках необходимо использовать следующую комбинацию
char[] cc=s.ToCharArray(); // Преобразуем string в массив
cc[0]='S'; // Изменяев элемент массива
s=new String(cc); //Создаем новый String

// Возхможно так же использовать тип: "StringBuilder"

System.Text.StringBuilder sb=new System.Text.StringBuilder("asda");
sb[0]='s';
s=sb.ToString();

string s1="Hello";
string s2="Hello";
System.Console.WriteLine(s1==s2); // Сравнивается содержимое, а не "место расположения".
System.Console.WriteLine(s1.CompareTo(s2)); // Метод сравнения строк (встроенный).
System.Console.WriteLine(String.Compare(s1,s2)); // Либо можно сравнивать так.

// s1.Length // Длина строки
// s2=s1.Substring(2,4); //Вырезание из строки и создание новой.
// System.Console.WriteLine(s1.IndexOf("as")); // Поиск необходимых элементов
// s1=s1.Replace('a','b'); // Замена элементов строки

// Подключение расширенных методов
// using System.Ling;