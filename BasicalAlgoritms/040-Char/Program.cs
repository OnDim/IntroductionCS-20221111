// Char

char c='a'; //содержит один элемент
c='\x64'; // пример кодировки элемента (возможно '\x0064')
c='\u0064'; // ('\u64' - не возможно)
char b='a';
System.Console.WriteLine((int)b);
System.Console.WriteLine(c.ToString()+b.ToString()); // преобразование в тип String
// Проверку лучше производить встроенными функциями
if (Char.IsDigit(b)) System.Console.WriteLine("It's digit");




