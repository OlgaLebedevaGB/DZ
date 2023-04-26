// Напишите программу, которая на вход принимает число и выдаёт, 
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


// Булевый вид метода
bool IsEven(int num)
{
    if(num % 2 ==0)
        return true;
    else
        return false;
}
// bool result = IsEven(4);
// Console.WriteLine(result);
             // или
// if(IsEven(4))
//     Console.WriteLine("Yes");
// else
//     Console.WriteLine("No");


// метод ввоза значения и конвертации в натуральное число
int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
// ПРИМЕР:
// int threedigitnumber = Prompt("Введите трехзначное число, пожалуйста: ");


// метод проверки цифры, обозначающей день недели на корректность
// bool ValidateWeekday(int daynumber)
// {
//     if(daynumber < 8 && daynumber > 0)
//     {
//         return true;
//     }
//     Console.WriteLine("Это не день недели");
//     return false;
// }


// метод - реверса числа
// int Reverse (int number)
// {
//     int digit = number % 10;
//     int revNumber = digit;
//     number /= 10;
//     while (number > 0)
//     {
//         digit = number % 10;
//         number /= 10;
//         revNumber *=10;
//         revNumber = revNumber + digit;
//     }
//     return revNumber;
// }


// Программа, которая принимает на вход число 
// и выдаёт количество цифр в числе
// int Quality(int number)
// {
//     int quantity = 0;
//     while (number != 0)
//     {
//         number = number / 10; // number/=10;
//         quantity++;
//     } 
//     return quantity;
// }
// Console.WriteLine("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = Quality(num);
// Console.WriteLine(result);


// программа, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
int Sum(int number)
{
    int sum = 0;
    int count = 0;
    while (number != 0)
    {
        count = number % 10; // number/=10;
        number /= 10;
        sum = sum + count;
    } 
    return sum;
}
// int num = EnterNum ("Введите число: ");
// int result = Sum(num);
// Console.WriteLine("Сумма цифр в числе равна: " + result);


// метод,который задает массив из случайных целых чисел
void FillArrau(int[] collection)
{
   int length = collection.Length;
   int index = 0;
   while (index < length) 
   {
        collection[index] = new Random().Next(1, 100);//диапазон чисел от 0 до 100)
        index++;
   }
}
// int [] array = new int[8];// пример массив из 8 элементов
// FillArrau(myArray);


// метод вывода на экран массива (элемент - значение)
void ShowIntMas (int [] array)
{
    for (int count=0; count <array.Length; count++) Console.WriteLine ($"Элемент массива {count} - {array[count]}");
}
// ShowIntMas (myArray);


// метод вывода массива на экран (элнмент1 пробел элемент2 ...)
void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)//array.Length - количество элементов 
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
// ShowArray(myArray);


// метод,который задает массив из случайных целых чисел с запросом диапазона чисел и их количества
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];//выделение памяти под массив
    for(int i= 0; i < size; i++)//начало массива,
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
};
// int size = Prompt("Input a quantity of elements array: ");
// int min = Prompt("Input a minimum possible element: ");
// int max = Prompt("Input a maximum possible element: ");
// int [] myArray = CreateRandomArray (size,min,max);
//             или
// Console.Write("Input a quantity of elements array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] myArray = CreateRandomArray (size,min,max);   // Гененрируем массив     



// программа, которая перевернёт(реверс) одномерный массив (последний элемент будет на первом месте,
//  а первый - на последнем и т.д.)
void ReverseArray(int[] array)
{
    for (int i=0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
// ReverseArray(myArray);


// ???
// int[] Return(int[] arr)
// {
//  int count = 0;
// 	int length = arr.Length / 2;
// 	int[] arrOut = new int[length];
// 	for (int i = 0; i < length; i++)
// 	{
// 		arrOut[i] = arr[i] * arr[arr.Length - 1 - i];
// 	}
// 	return arrOut;
// }


// программа, которая будет создавать копию
//  заданного массива с помощью поэлементного копирования.
int [] CopyArray (int[] array)
{
    int[] mas = new int [array.Length];
    for (int i=0; i<array.Length; i++) mas[i]=array[i];
    return mas;
}
// int [] newArray= CopyArray(myArray);
// ShowIntMas(newArray);


// метод,который задает массив из чисел с вводом количества элементов и самих элементов
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
// int size = Prompt ("Введите количество элементов массива: ");
// int[] array = CreateArray(size);
// ShowArray(array);


// метод Заполнение цикла случайными числами из указанного диапазона в формате double
double[] CreateRandomArray(int size, double minValue, double maxValue) 
{ 
    double[] array = new double[size]; 
    for(int i = 0; i < size; i++) 
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue; 
             
    return array; 
} 
// Console.Write("Input a quantity of elements: "); 
// int size = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input a minimum possible element: "); 
// double min = Convert.ToDouble(Console.ReadLine()); 
// Console.Write("Input a maximum possible element: "); 
// double max = Convert.ToDouble(Console.ReadLine()); 
// double[] array = CreateRandomArray(size, min, max); 
// ShowArray(array);


// метод задать массив вещественных чисел (double) c вводом чисел
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
// Console.WriteLine("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double [] myArray = CreateArrayDouble(size);


// Цикл for двойной
// for (int i = 2; i<=10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


// Сортировка массива от min
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i+1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) 
//             {
//             minPosition = j;
//             }
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// SelectionSort(arr);
// ShowArray(arr);


// Сортировка массива от max
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) 
            {
            maxPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
// SelectionSort(arr);
// ShowArray(arr);


// Задача Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// каждый последующий элементб- сумма двух предыдущих
// результат массив из элементов
// цикл с 2
int[] Fibonacci (int num1, int num2, int razm)
{
    int[] array = new int[razm];
    array[0]=num1;
    array[1]=num2;
    for (int i=2; i<razm; i++) array[i]=array[i-1]+array[i-2];// предыдущий элемент = i-1 и т.д.
    return array;
}