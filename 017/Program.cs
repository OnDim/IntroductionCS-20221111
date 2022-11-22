// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int[] array = new int[6];
// Каждому индексу присваиваем значение
string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
System.Console.WriteLine("Введите число от 0 до 6: ");
int a=Convert.ToInt32 (System.Console.ReadLine());
Console.WriteLine(weekDays[a]);
if (a==0 || a==6) System.Console.WriteLine("YES!!! ВЫХОДНОЙ!!!"); else System.Console.WriteLine("No");
