// // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// // Найдите сумму отрицательных элементов массива.
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];//выделение памяти под массив
    for(int i= 0; i < size; i++)//начало массива,
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
};

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)//array.Length - количество элементов 
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int GetSumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i=0; i < array.Length; i++)
        if(array[i]<0) 
            sum += array[i];// sum = sum + array[i];
        return sum;
}

Console.WriteLine("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

Console.Write("Сумма отрицательных чисел" + GetSumOfNegatives(myArray));

Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.

int [] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i= 0; i < size; i++)
    {
        Console.Write("Введите элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
        return array;
};

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int [] Change (int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}
Console.WriteLine("Введите количество элементов массива: ");
int size =  Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);
Console.WriteLine();

int [] array2 = Change(array);
ShowArray(array2);

// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
массив и число 

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];//выделение памяти под массив
    for(int i= 0; i < size; i++)//начало массива,
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
};

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)//array.Length - количество элементов 
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
bool Metod(int [] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) return true;
    }
    return false;
}
int [] array = CreateRandomArray(6, -5, 2);
ShowArray(array);
Console.WriteLine(Metod(array, 7));


// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [a,b].

int QuantityOfElements(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] <= max && array[i] >= min) count++;
    return count;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum possible element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum possible element: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input lower boarder, please: ");
int boarderA = Convert.ToInt32(Console.ReadLine()); // запрашиваем пределы
Console.Write("Input top boarder, please: ");
int boarderB = Convert.ToInt32(Console.ReadLine());// запрашиваем пределы

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("The quantity of elements between boarders: " + QuantityOfElements(array, boarderA, boarderB));


Задача 4 для группы 4

public static int[] Return(int[] arr)
		{

			int count = 0;
			int length = arr.Length / 2;
			int[] arrOut = new int[length];
			for (int i = 0; i < length; i++)
			{
				arrOut[i] = arr[i] * arr[arr.Length - 1 - i];
			}
			return arrOut;
		}
