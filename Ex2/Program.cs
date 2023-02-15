// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int NeedThirdNum(int number)
{
    while(number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidNum(int number)
{
    if (number < 100 )
    {
        System.Console.WriteLine("Нет третьей цифры");
        return false;
    }
    return true;
}

int number = Prompt("Введите число : ");
if (ValidNum(number))
{
    System.Console.WriteLine(NeedThirdNum(number));
}
