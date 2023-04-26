// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// int [] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];//выделение памяти под массив
//     for(int i= 0; i < size; i++)//начало массива,
//         array[i] = new Random().Next(minValue, maxValue +1);
//     return array;
// };

// void ShowArray(int[] array)
// {
//     for(int i=0; i<array.Length; i++)//array.Length - количество элементов 
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int NumEven (int [] array)
// {
//     int quantity = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//             quantity = quantity +1;
//     }
//     return quantity;
// }

// Console.WriteLine("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int min = 100;
// int max = 999;
// int [] myArray = CreateRandomArray(size, min, max);

// ShowArray(myArray);
// int quantity = NumEven(myArray);
// Console.WriteLine("Количество чётных чисел в массиве: " + quantity);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int [] CreateRandomArrayFrom_100UpTo100(int size)
// {
//     int[] array = new int[size];//выделение памяти под массив
//     for(int i= 0; i < size; i++)//начало массива,
//         array[i] = new Random().Next(-100, 100);
//     return array;
// }
// int SumOfOdd (int [] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i=i+2)
//         sum = sum + array[i];
//     return sum;
// }

// int size = 4;
// int [] myArray = CreateRandomArrayFrom_100UpTo100(size);
// ShowArray(myArray);
// Console.WriteLine("Сумма элементов, стоящих на нечётных позициях " + SumOfOdd(myArray));

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// double [] CreateArrayDouble(int size)
// {
//     double[] array = new double[size];
//     for(int i= 0; i < size; i++)
//     {
//         Console.Write("Введите элемент: ");
//         array[i] = Convert.ToDouble(Console.ReadLine());
//     }
//         return array;
// };

// void ShowArrayDouble(double[] array)
// {
//     for(int i=0; i<array.Length; i++)//array.Length - количество элементов 
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }
// double MetodMax(double[] array)
// {
//     double max = array[0];
//     for(int i = 1; i < array.Length; i++)
//     {
//         if(array[i] > max)
//         max = array[i];
//     }
//     return max;
// }
// double MetodMin(double[] array)
// {
//     double min = array[0];
//     for(int i = 1; i < array.Length; i++)
//     {
//         if(array[i] < min)
//         min = array[i];
//     }
//     return min;
// }
// Console.WriteLine("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double [] myArray = CreateArrayDouble(size);
// ShowArrayDouble(myArray);
// double max = MetodMax(myArray);
// double min = MetodMin(myArray);
// double result = max - min;
// Console.WriteLine("Разница между максимальным и минимальным элементом массива = " + (result));

// Способ получения случайных чисел в массиве в формате double

double[] CreateRandomArray(int size, double minValue, double maxValue) 
{ 
    double[] array = new double[size]; 
 
    for(int i = 0; i < size; i++) 
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue; 
             
    return array; 
} 
 
void ShowArray(double[] array) 
{ 
    for(int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
     
    Console.WriteLine(); 
}
 
Console.Write("Input a quantity of elements: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a minimum possible element: "); 
double min = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Input a maximum possible element: "); 
double max = Convert.ToDouble(Console.ReadLine()); 
double[] array = CreateRandomArray(size, min, max); 
ShowArray(array);

