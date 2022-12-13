// 83.  Подсчитать количество цифр среди вводимых с клавиатуры символов

string s=Console.ReadLine();
int k=0;
//Первый вариант программы

// for(int i=0;i<s.length;i++)
//    if (char.IsDigit(s[i])) k++;

// Второй вариант программы

foreach(char c in s) // каждый элемент строки
    if (char.IsDigit(c)) k++;

System.Console.WriteLine(k);    
