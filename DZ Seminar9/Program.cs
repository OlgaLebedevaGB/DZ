// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// 1 вариант
// string NumbersRec(int a, int b)
// {
//     if(a <=b) return NumbersRec(a + 1, b) +  $"{a} ";
//     else return String.Empty;
// }
// int a = 1;
// Console.Write("Задайте значение N: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(NumbersRec(a, b));

// 2 вариант
void ShowNums(int num)
{
    if (num > 1) ShowNums(num-1);
    Console.Write(num + " ");
}
Console.Write("Задайте значение N: ");
int b = Convert.ToInt32(Console.ReadLine());
ShowNums(b);

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumRec(int m, int n)
// {
//     if(n < m) return 0;
//     else return n + SumRec(m, n-1);
// }

// Console.Write("Задайте значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumRec(m, n));

// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Akkerman(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Akkerman(m - 1, 1);
//   else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// Console.Write("Задайте значение m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте значение n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int functionAkkerman = Akkerman(m, n);
// Console.Write($"Функция Аккермана ({m},{n}) = {functionAkkerman} ");