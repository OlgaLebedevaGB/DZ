// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от 1 до N. Выполнить с помощью рекурсии.
// void ShowNums(int num)
// {
//     if (num > 1) ShowNums(num-1);
//     Console.Write(num + " ");
// }

// ShowNums(5);

// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр

// int SumOfDigits(int num)
// {
//     if(num != 0) return SumOfDigits(num / 10) + num % 10;
//     return 0;
// }
// Console.WriteLine(SumOfDigits(1234));

// Задайте значение m и n 
// И напишие программу которая будет выводить все натуральные числа
// в промежутке от M до N

// 1 способ
// void ShowNums2(int m, int n)
// {
//     if (n > m) 
//     {
//         ShowNums2(m, n-1);
//         Console.Write(n + " ");
//     }
    
//     if (m > n) 
//     {
//         Console.Write(m + " ");
//         ShowNums2 (m-1, n);  
//     }
//     if (m==n)
//     Console.Write(m +" ");  
// }
// ShowNums2(5, 1);

// 2 способ
void ShowNums2(int m, int n)
{

    Console.Write(m + " ");
    if (m > n) ShowNums2(m-1, n);
    if (m < n) ShowNums2(m+1, n);
}
ShowNums2(1,5);

// Напишите программу котораяна вход принимает два числа
// А и В и возводит число А в целую степень В
// int
// int MultiPlyNum (int A, int B)
// {
//     if (B !=0) return MultiPlyNum(A, B-1)*A;
//     return 1;
// }
// Console.WriteLine(MultiPlyNum(2,4));
