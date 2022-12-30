int weekday = Convert.ToInt32(DateTime.Now.DayOfWeek);
switch (weekday)
{
    case 0:
        Console.WriteLine("its Sunday");
        break;
        case 1:
        Console.WriteLine("its Monday");
        break ;
        case 2:
        Console.WriteLine("its Tuesday");
        break;
    case 3:
        Console.WriteLine("its Wednesday");
            break;
    case 4:
        Console.WriteLine("its Thursday");
            break;
    case 5:
        Console.WriteLine("its Friday");
        break;
    case 6:
        Console.WriteLine("its Saturday");
        break;  
        default:
        Console.WriteLine("ooopsi... your calender must be broken");
        break;
}
Console.WriteLine("Have a nice day!");
