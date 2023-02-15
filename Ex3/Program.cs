// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool NameDay(int WorkDay)
{
    if (WorkDay > 5 )
    {
        return true;
    }
    return false;
}

bool NoWeekDay(int number)
{
    if (number > 0 && number <=7)
    {
        return true;
    }
    System.Console.WriteLine("Такого дня недели еще не придумали");
    return false;
}

int WorkDay = Prompt("Введите день недели : ");
if (NoWeekDay(WorkDay))
{
    if (NameDay(WorkDay))
    {
        System.Console.WriteLine("Выходной день");
    }
    else
    {
        System.Console.WriteLine("Будний день");
    }
} 
