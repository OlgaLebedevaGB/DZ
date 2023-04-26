// Одномерные массивы
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
//  а первый - на последнем и т.д.)

// создаём новый

// через переменную изменить исходный массив

// void ReverseArray(int[] array)
// {
//     for (int i=0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }
void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)//array.Length - количество элементов 
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
// int [] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];//выделение памяти под массив
//     for(int i= 0; i < size; i++)//начало массива,
//         array[i] = new Random().Next(minValue, maxValue +1);
//     return array;
// };
// int [] myArray= CreateRandomArray(5, 3, 7);
// ShowArray(myArray);
// ReverseArray(myArray);
// ShowArray(myArray);


// // Задача 1 Напишите программу, которая принимает на вход три числа и проверяет, 
// // может ли существовать треугольник с сторонами такой длины.
// bool CheckTrin(int l1, int l2, int l3)
// {
//     if (l1<l2+l3 && l2<l1+l3 && l3<l1+l2) return true;
//     return false;
// }

// Console.WriteLine("Input size 1 - ");
// int l1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size 2 - ");
// int l2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size 3 - ");
// int l3=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ($" По заданным длинам труегольник -  {CheckTrin (l1,l2,l3)} " );

// Задача 2 Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// каждый последующий элементб- сумма двух предыдущих
// результат массив из элементов
// цикл с 2


void ShowIntMas (int [] array)
{
    for (int count=0; count <array.Length; count++) Console.WriteLine ($"Элемент массива {count} - {array[count]}");
}

int[] Fibonacci (int num1, int num2, int razm)
{
    int[] array = new int[razm];
    array[0]=num1;
    array[1]=num2;
    for (int i=2; i<razm; i++) array[i]=array[i-1]+array[i-2];
    return array;
}

// Console.Write ("Введите кол-во эл-в ряда - ");
// int razm = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите превое значние ряда - ");
// int num1= Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите превое значние ряда - ");
// int num2= Convert.ToInt32(Console.ReadLine());

// int[] fibArray= Fibonacci(num1,num2,razm);

// ShowIntMas (fibArray);

// Задача 3 Напишите программу, которая будет создавать копию
//  заданного массива с помощью поэлементного копирования.
// перекопировать все элементы


int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];//выделение памяти под массив
    for(int i= 0; i < size; i++)//начало массива,
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
};

int [] CopyArray (int[] array)
{
    int[] mas = new int [array.Length];
    for (int i=0; i<array.Length; i++) mas[i]=array[i];
    return mas;
}
Console.Write("Input a quantity of elements array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum possible element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum possible element: ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray (size,min,max);   // Гененрируем массив

ShowIntMas(myArray);
int [] newArray= CopyArray(myArray);
ShowIntMas(newArray);