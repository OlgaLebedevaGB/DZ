﻿// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно,
//  программа должна вывести сообщение для пользователя.

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
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}


void ReverseArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0)-1; i++)
        for(int j = i+1; j<array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
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
ReverseArray(myArray);
Show2dArray(myArray);

// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }
    Console.WriteLine();
}

void ReversArray (int[,] array, int row1, int row2)
{
    if (row1 == row2 || row1 < array.GetLength(0) || row2 < array.GetLength(0)) Console.WriteLine("Строки равны замена не требуется или таких строк нет");
    else
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1,j];
            array[row1,j] = array[row2,j];
            array[row2,j] = temp;
        }
    }
}

Console.Write("Введите колличество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива = ");
int miValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива = ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, miValue, maxValue);
Show2dArray(myArray);

Console.Write("Введите первую струко для замены = ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую струко для замены = ");
int row2 = Convert.ToInt32(Console.ReadLine());
ReversArray(myArray, row1, row2);
Show2dArray(myArray);


// void ReverseArray(int[,] array)
// {
//     for (int i = 1; i < array.GetLength(0); i++)
//         for (int j = 0; j < i; j++)
//         {
//             int temp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = temp;
//         }
// }

// int[,] myArray = Create2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);
// ReverseArray(myArray);
// Show2dArray(myArray);

// Task 2. Задайте двумерный массив. Напишите программу, которая поменяет местами любые две строки массива.
// void, array, rows

// void RandomChangeRows(int[,] array, int row1, int row2)
// {
//     if (row1 < array.GetLength(0) && row2 < array.GetLength(0) && row1 >= 0 && row2 >= 0)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//         Show2dArray(array);
//     }
//     else
//         Console.WriteLine("Sorry, I cannot :c");
// }

// Console.WriteLine("Input first row, please: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input row into change with first row, please: ");
// int row2 = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);
// RandomChangeRows(myArray, row1, row2);
// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.
int[] MinimumElement(int[,] array)
{
    int min = array[0, 0];
    int minX = 0;
    int minY = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minX = i;
                minY = j;
            }
        }
    }
    int[] coord = { minX, minY };
    return coord;
}

void DeleteRowAndColumn(int[,] array, int[] coord)
{
    for (int i = 0; i < array.GetLength(0); i++) array[i, coord[1]] = 0;
    for (int j = 0; j < array.GetLength(1); j++) array[coord[0], j] = 0;
}

int[,] myArray = Create2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
int[] result = MinimumElement(myArray);
DeleteRowAndColumn(myArray, result);
Show2dArray(myArray);