// С клавиатуры вводится число - день недели. Определить день недели.

int day=1;
switch (day)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    default:
        Console.WriteLine("не правильный ввод");
        break;
}
//GOTO - использовать нельзя - оперетор безусловного перехода.