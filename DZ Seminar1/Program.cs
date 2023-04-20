// Задача 2: Нипиште программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
// {
//     Console.WriteLine("Max = " + num1);
// }
// else
// {
//     Console.WriteLine("Max = " + num2);
// }

// Задача 4: Напишите программу, которая принимает на вход три 
// числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введи первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введи второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введи третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if(max < num2)
// {
//     max = num2;
//     }
// if(max < num3)
// {
//     max = num3;
//     }
// Console.WriteLine("Максимальное число: " + max);

// Задача 6:Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число");
// double number = Convert.ToDouble(Console.ReadLine());
// double ostatok = number % 2;
// if(ostatok == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int i = 2;

while(i <= num)
{
    Console.Write(i + " ");
    i = i + 2;
}