﻿// 20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У,
// причем X ≠ 0 и Y ≠ 0

// тип имя (аргументы)
int Part(double x, double y)
{
//тело подпрограммы
    
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x<0 && y<0) return 3;
    if (x>0 && y<0) return 4;
    return 0;
}

double x=Convert.ToDouble(Console.ReadLine());
double y=Convert.ToDouble(Console.ReadLine());
int p=Part(x,y);
/*if (x>0 && y>0) part=1;
if (x<0 && y>0) part=2;
if (x<0 && y<0) part=3;
if (x>0 && y<0) part=4;*/
System.Console.WriteLine("Part:"+p);