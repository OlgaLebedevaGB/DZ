// метод генерации двумерных массивов
// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // rows - строки; columns - столбцы; максимальное значение; минимальное значение пределов
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)// заполняем все строки от 0 до rows
//         for (int j = 0; j < columns; j++)// заполяем все столбцы от 0 до columns
//             array[i,j] = new Random().Next(minValue, maxValue +1);

//     return array;
// }


//метод вывода двумерного массива на экран
// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j]+ " ");

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

// int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);


//Задача Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
//Ai,j = i+j. Выведите полученный массив на экран.
// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // rows - строки; columns - столбцы; максимальное значение; минимальное значение пределов
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)// заполняем все строки от 0 до rows
//         for (int j = 0; j < columns; j++)// заполяем все столбцы от 0 до columns
//             array[i,j] = new Random().Next(minValue, maxValue +1);

//     return array;
// }

// int[,] CreateArray(int rows, int columns) // rows - строки; columns - столбцы; максимальное значение; минимальное значение пределов
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)// заполняем все строки от 0 до rows
//         for (int j = 0; j < columns; j++)// заполяем все столбцы от 0 до columns
//             array[i,j] = i + j;

//     return array;
// }

// Console.Write("Ввведите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateArray(rows, columns);
// Show2dArray(myArray);

//Задача Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // rows - строки; columns - столбцы; максимальное значение; минимальное значение пределов
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)// заполняем все строки от 0 до rows
//         for (int j = 0; j < columns; j++)// заполяем все столбцы от 0 до columns
//             array[i,j] = new Random().Next(minValue, maxValue +1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j]+ " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void EventIndex (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i +=2)
//         for (int j = 0; j < array.GetLength(1); j+=2)
//             array[i,j]*=array[i,j];
// }

// Console.Write("Ввведите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввведите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введиде минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введиде максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);
// EventIndex(myArray);
// Show2dArray(myArray);

//Задача Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали масива (с индексами (0,0); (1,1) и т.д.).
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // rows - строки; columns - столбцы; максимальное значение; минимальное значение пределов
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)// заполняем все строки от 0 до rows
        for (int j = 0; j < columns; j++)// заполяем все столбцы от 0 до columns
            array[i, j] = new Random().Next(minValue, maxValue + 1);

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
int DiagSum(int[,] array)
{
    int sum = array[0, 0];
    for (int i = 1; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum = sum + array[i, i];
    return sum;
}

Console.Write("Ввведите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиде минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиде максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Console.WriteLine($"Сумма диагональных элементов - {DiagSum(myArray)}");
