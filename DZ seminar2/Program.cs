// Задача № 10 Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
// int SecondDigit(int num)
// {
//     int dozens = num / 10;
//     int units = dozens % 10;
//     return units;
// }

// int threedigitnumber = Prompt("Введите трехзначное число, пожалуйста: ");
// if(threedigitnumber<100 || threedigitnumber>=1000)
// {
//     Console.WriteLine("Вы ввели не трёхзначноечисло, повторите ввод ");
//     return;
// }
// Console.WriteLine($"Введённое число: {threedigitnumber}");

// int result = SecondDigit(threedigitnumber);
// Console.WriteLine($"Bторая цифра этого числа: {result}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
int GetThirdRank (int Number)
{
    while (Number>999)
    {
        Number = Number / 10;
    }
    return Number % 10;
}
bool ValidateNumber (int number)
{
    if (number < 100)
    {
        Console.WriteLine("Tретьей цифры нет");
        return false;
    }
    return true;
}

int number = Prompt("Введите число: ");
if (ValidateNumber(number))
    {
        int result = GetThirdRank(number) % 10;
        Console.WriteLine($"Третья цифра этого числа: {result}");
    }

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// bool DayOff(int daynumber)
// {
//     if((daynumber == 6) || (daynumber == 7))
//     return true;
//     else
//     return false;   
// }

// bool ValidateWeekday(int daynumber)
// {
//     if(daynumber < 8 && daynumber > 0)
//     {
//         return true;
//     }
//     Console.WriteLine("Это не день недели");
//     return false;
// }

// int num = Prompt("Введите цифру, обозначающую день недели: ");
// if (ValidateWeekday(num))
// {
//     if(DayOff(num))
//         Console.WriteLine("Выходной день");
//     else
//         Console.WriteLine("Рабочий день");
// }
