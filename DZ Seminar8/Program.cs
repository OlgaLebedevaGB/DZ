// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
int[,] CreateRandom2dArray(int rows, int columns, int maxValue, int minValue) // rows - строки; columns - столбцы; максимальное значение; минимальное значение пределов
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)// заполняем все строки от 0 до rows
        for (int j = 0; j < columns; j++)// заполяем все столбцы от 0 до columns
            array[i,j] = new Random().Next(minValue, maxValue +1);

    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+ "   ");

        Console.WriteLine();
    }
    Console.WriteLine();
}
// void Sort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i+1; j < array.Length; j++)
//         {
//             if(array[j] > array[minPosition]) 
//             {
//             minPosition = j;
//             }
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// void Main(int[,] myArray, int rows, int columns)
// {
//     Console.WriteLine("Исходный массив");
//     Show2dArray(myArray);
//     Console.WriteLine("Сортировка по строкам: ");
//     int[] row = new int[columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//             row[j] = myArray[i, j];
//         Sort(row);
//         Insert(true, i, row, myArray);
//     }
// }
// void Insert(bool isRow, int dim, int[] source, int[,] dest)
// {
//     for (int k = 0; k < source.Length; k++)
//     {
//         if (isRow)
//             dest[dim, k] = source[k];
//         else
//             dest[k, dim] = source[k];
//     }
// }

// Console.Write("Ввведите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введиде минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введиде максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(rows, columns, maxValue, minValue);
// Main(myArray, rows, columns);
// Show2dArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

void SumInLines(int[,] numbers)
{
    int[] sumInLines = new int[numbers.GetLength(0)];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sumInLines[i] += numbers[i, j];
        }
        Console.WriteLine($"Cумма {i+1} строки = {sumInLines[i]} ");
    }
    int minI = 0;
    for (int i = 0; i < sumInLines.Length; i++)
    {
        if (sumInLines[minI] > sumInLines[i]) minI = i;
    }
    Console.Write($"\nНаименьшая сумма элементов: {sumInLines[minI]}, номер строки с ней: {minI + 1}");    
}
bool ValidatePalindrom (int[,] myArray)
{
    if(myArray.GetLength(0) == myArray.GetLength(1)) 
        return true;
    else 
        return false; 
}

Console.Write("Ввведите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиде минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиде максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(rows, columns, maxValue, minValue);
Show2dArray(myArray);
if(ValidatePalindrom(myArray))
{
    Console.WriteLine("массив не прямоугольный");
    }
else
    SumInLines(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// int[,] matrixMultiplication(int[,] a1, int[,] a2)
// {
//     int[,] b = new int[a1.GetLength(0), a2.GetLength(1)];

//     for (int i = 0; i < a1.GetLength(0); i++)
//         for (int j = 0; j < a2.GetLength(0); j++)
//             for (int k = 0; k < a2.GetLength(1); k++)
//                 b[i, k] += a1[i, j] * a2[j, k];
//     return b;
// }
// int[,] array2D1 = new int[2, 2] { { 2, 4 }, { 3, 2 } };
// Show2dArray(array2D1);
// int[,] array2D2 = new int[2, 2] { { 3, 4 }, { 3, 3 } };
// Show2dArray(array2D2);
// int [,] result = matrixMultiplication(array2D1, array2D2);
// Show2dArray(result);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// void Show3dArray(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int n = 0; n < array.GetLength(2); n++)
//             {
//                 Console.Write($"{array[i,j,n]} {(i, j, n)} ");
//             }
//             Console.WriteLine();
//         }
//     }
//     Console.WriteLine();
// }

// int[,,] array3D = new int[2, 2, 2] { { { 11, 22}, { 33, 44 } },
//                                     { { 55, 66 }, { 77, 88 } } };
// Show3dArray(array3D);

// Задача 62. Напишите программу, которая заполнит 
// спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void SpiralCreate2dArray(int[,] mas, int rows, int columns)
// {
//     int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = columns;
//     for (int i = 0; i < mas.Length; i++)
//     {
//         mas[row, col] = i + 1;
//         if (--gran == 0)
//         {
//             gran = columns * (dirChanges % 2) + rows * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
//             int temp = dx;
//             dx = -dy;
//             dy = temp;
//             dirChanges++;
//         }
//         col += dx;
//         row += dy;
//     }               
// }
// int rows = 4;
// int columns = 4;
// int[,] mas = new int[rows, columns];
// Show2dArray(mas);
// SpiralCreate2dArray(mas, rows, columns);
// Show2dArray(mas);