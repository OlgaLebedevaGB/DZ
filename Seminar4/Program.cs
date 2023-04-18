// // Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
int Quality(int number)
{
    int quantity = 0;
    while (number != 0)
    {
        number = number / 10; // number/=10;
        quantity++;
    } 
    return quantity;
}
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = Quality(num);
Console.WriteLine(result);

// // Напишите программу, которая принимает на вход число (А)
//  и выдаёт сумму чисел от 1 до А.
// int Num (int a)
// {
//     int N = 1;
//     int sum = 0;
//     while (N<=a)
//     {
//         sum = sum + N;
//         N ++;
//     }
//     return sum;   
// }

//     Console.WriteLine("Ведите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int result = Num(a);
//     Console.WriteLine(result);

// Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.

// int Num (int a)
// {
//     int N = 1;
//     int con = 1;
//     while (N<=a)
//     {
//         con = con * N;
//         N ++;
//     }
//     return con;   
// }

//     Console.WriteLine("Ведите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int result = Num(a);
//     Console.WriteLine(result);

