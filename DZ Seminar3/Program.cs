// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
int EnterNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// int Reverse (int number)
// {
//     int digit = number % 10;
//     int revNumber = digit;
//     number /= 10;
//     while (number > 0)
//     {
//         digit = number % 10;
//         number /= 10;
//         revNumber *=10;
//         revNumber = revNumber + digit;
//     }
//     return revNumber;
// }

// bool ValidatePalindrom (int number, int revNumber)
// {
//     if(number == revNumber)
//     return true;
//     else
//     return false; 
// }

// int number = EnterNum("Введите число, проверяемое на палиндромность ");
// int revNumber = Reverse(number);
// if(ValidatePalindrom(number, revNumber))
//     Console.WriteLine("Да");
//     else
//     Console.WriteLine("Нет");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// // //  и находит расстояние между ними в 3D пространстве.
// int EnterNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double distX = x2-x1;
//     double distY = y2-y1;
//     double distZ = z2-z1;
//     double result = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2) + Math.Pow(distZ, 2));
//     return result;
// }

// int x1 = EnterNum("Введите значение x1 - ");
// int y1 = EnterNum("Введите значение y1 - ");
// int z1 = EnterNum("Введите значение z1 - ");
// int x2 = EnterNum("Введите значение x2 - ");
// int y2 = EnterNum("Введите значение y2 - ");
// int z2 = EnterNum("Введите значение z2 - ");

// double rez = Math.Round(Distance (x1,y1,z1,x2,y2,z2),2);

// Console.Write ($"Расстояние между точками 1 и 2 составляет  - {rez}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

void Cube(int num)
{
    int current = 1;
    while(current <= num)
    {
        Console.WriteLine($"{current} - {Math.Pow(current, 3)}");
        current++;
    }
}
int num = EnterNum("Введите число: ");
Cube(num);
