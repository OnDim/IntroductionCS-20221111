// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.
// Зависит от раскладки клавиатуры.

string str = Console.ReadLine();
char letter = 'a';
int g = str.Count(ch => ch == letter);
System.Console.WriteLine(g); 

 
