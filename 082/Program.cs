// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

string str=Console.ReadLine();
String word = str.Substring(0, str.IndexOf('.')); // обрезаем строку до "." (Подсмотрел в Инете)
int k=0;
foreach (char c in word)
   if (char.IsLetterOrDigit(c)) k++;
   
System.Console.WriteLine(k);