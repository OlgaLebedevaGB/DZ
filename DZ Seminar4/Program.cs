// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
int EnterNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// int numA = EnterNum("Введите число А: ");
// int numB = EnterNum("Введите число B: ");
// int result = numA;
// int count = 1; 
// while(numB > count)
// {
//     result = result * numA;
//     count++;
// }
// Console.WriteLine(result);

// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// int Sum(int number)
// {
//     int sum = 0;
//     int count = 0;
//     while (number != 0)
//     {
//         count = number % 10; // number/=10;
//         number /= 10;
//         sum = sum + count;
//     } 
//     return sum;
// }
 
// int num = EnterNum ("Введите число: ");
// int result = Sum(num);
// Console.WriteLine("Сумма цифр в числе равна: " + result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

void FillArrau(int[] collection)
{
   int length = collection.Length;
   int index = 0;
   while (index < length) 
   {
        collection[index] = new Random().Next(1, 100);
        index++;
   }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}
int [] array = new int[8];

FillArrau(array);
PrintArray(array);
