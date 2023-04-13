// семинар 2

// Задача1 Напишите программу, 
// которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

// int CutNumber(int num)
// {
//     int hunderds = num / 100;
//     int units = num % 10;

//     int result = hunderds * 10 + units;
//     return result;
// }

// int randNumber = new Random().Next(100, 1000);
// int shortNumber = CutNumber(randNumber);

// Console.WriteLine($"New version of {randNumber} is {shortNumber}");

// bool IsEven(int num)
// {
//     if(num % 2 ==0)
//         return true;
//     else
//         return false;
// }bool result = IsEven(4);
// Console.WriteLine(result);

// или



//Задача - Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа
// int MaxDigits(int randNumber)
// {
//     int units = randNumber % 10;
//     int dozents = randNumber / 10;
//     if (units > dozents) return units;
//     else return dozents;
// }
// int random = new Random().Next(10, 100);
// int randomNumber = MaxDigits(random);
// Console.WriteLine(random);
// Console.WriteLine(randomNumber);

// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому.

// bool Even(int num1, int num2)
// {
// if (num2 % num1 == 0)
// return true;
// else
// return false;
// }

// Console.WriteLine("Input first number, please: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number, please: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// bool result = Even(num1, num2);
// Console.WriteLine(result);

// Напишите программу, которая принимает на вход число n и проверяет, 
// кратно ли оно одновременно a и b.

// bool Even(int num1, int num2, int arg)
// {
// if (num1 % arg == 0 && num2 % arg == 0)
// return true;
// else
// return false;
// }

// Console.WriteLine("Input first number, please: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number, please: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number, please: ");
// int arg = Convert.ToInt32(Console.ReadLine());

// bool result = Even(num1, num2, arg);
// Console.WriteLine(result);

// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

bool Square(int num1, int num2)
{
if ((num1 * num1 == num2) || (num2 * num2 == num1))
return true;
else
return false;
}

Console.WriteLine("Input first number, please: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number, please: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = Square(num1, num2);
Console.WriteLine(result);
