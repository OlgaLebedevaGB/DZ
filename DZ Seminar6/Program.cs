// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int SumNor(int size)
// {
//     int count = 0;
//     for(int i= 0; i < size; i++)
//     {
//         int num = Prompt("Введите элемент: ");
//         if (num > 0) count ++;   
//     }
//         return count;
// }
// int size = Prompt ("Введите количество чисел: ");
// Console.WriteLine("Количество чисел больше 0: " + SumNor(size));

// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
double PromptDouble(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
bool ValidateParallelism(double k1, double k2)
{
    if(k1 == k2)
        return true;
    else
        return false;
}
double b1 = PromptDouble("Введите значение b1:");
double k1 = PromptDouble("Введите значение k1:");
double b2 = PromptDouble("Введите значение b2:");
double k2 = PromptDouble("Введите значение k2:");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
ValidateParallelism(k1,k2);
if(ValidateParallelism(k1,k2))
    Console.WriteLine("Прямые параллельны");
    if(b1 == b2)
        Console.WriteLine("Прямые совпадают");
else Console.WriteLine ($"Точка пересечения прямых ({x};{y})");

