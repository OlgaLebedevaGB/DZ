// Задайте двумерный массив размером m+n, заполненный случайными вещественными числми
// double[,] CreateRandom2dArray(int rows, int columns, int maxValue, int minValue) // rows - строки; columns - столбцы; максимальное значение; минимальное значение пределов
// {
//     double[,] array = new double[rows, columns];

//     for (int i = 0; i < rows; i++)// заполняем все строки от 0 до rows
//         for (int j = 0; j < columns; j++)// заполяем все столбцы от 0 до columns
//             array[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;

//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(Math.Round((array[i,j]),1)+ " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Ввведите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введиде минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введиде максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);

//Напиште программу, которая на вход принимает позиции элемента в двумерном массиве 
// и возвращает значение этого элемента или же указание, что такого элемента нет. 
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

// void ElementValue (int[,] array, int index1, int index2)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == index1 && j == index2)
//                 Console.WriteLine ("Значение элемента: " + array[i,j]);
//         }
//     }
//     if (index1>array.GetLength(0) || index2 >array.GetLength(1))
//         Console.WriteLine ("Такого элемента нет");
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
// Show2dArray(myArray);
// Console.Write("Ввведите 1 позицию элемента: ");
// int position1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите 2 позицию элемента: ");
// int position2 = Convert.ToInt32(Console.ReadLine());
// ElementValue(myArray, position1, position2);

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
double[] AverageColumn(int[,] array)
{
    double mеаn = 0;
    double[] doubleArray = new double[array.GetLength(1)];
        for(int i = 0; i < array.GetLength(1); i++)
        {
            double sum = 0;
            for(int j = 0; j < array.GetLength(0); j++) 
                sum = sum + Convert.ToDouble(array[j,i]);
                mеаn = sum / Convert.ToDouble(array.GetLength(0));   
            doubleArray[i] = Convert.ToDouble(Math.Round(mеаn, 1));
        }
    return doubleArray;     
}

void ShowArrayDouble(double[] array)
{
    for(int i=0; i<array.Length; i++)//array.Length - количество элементов 
        Console.Write(array[i] + " ");
    Console.WriteLine();
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
double[] resultArray = AverageColumn(myArray);
ShowArrayDouble(resultArray);
