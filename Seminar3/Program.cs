//Метод ссобщает номер четверти
// Программа принимает номер и сообщает значение переменных х и y
// void ShowRange(int quard)
// {
//     if(quard ==1) Console.WriteLine("x > 0 and y > 0");
//     else if (quard == 2) Console.WriteLine("x < 0 and y > 0");
//     else if (quard == 3) Console.WriteLine("x < 0 and y < 0");
//     else if (quard == 4) Console.WriteLine("x > 0 and y < 0");
//     else Console.WriteLine("Неверный номер четверти");
// }

// Console.Write("Введите номер четверти": );
// int quard = Convert.ToInt32(Console.ReadLine());
// ShowRange(quard); 


// Task 2(not void). Напишите программу, которая принимает на вход координаты точки (X и Y),
//         и выдаёт номер четверти плоскости, в которой находится эта точка.
// int ShowQuad(int x, int y)
// {
//     if(x > 0 && y > 0) 
//         return 1;
//     else if(x<0 && y>0)
//         return 2;
//     else if(x<0 && y<0)
//         return 3;
//     else if(x>0 && y<0)
//         return 4;
//     else 
//         return -1;
// }
// Console.WriteLine("Введите координаты точки X");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки Y");
// int Y = Convert.ToInt32(Console.ReadLine());
// int result = ShowQuad(X,Y);
// Console.WriteLine($"Точка находится в {result} четверти плоскости");


// // Task 3. Напишите программу, 
// //         которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.


// int EnterNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void Quad(int num)
// {
//     int current = 1;
//     while(current <= num)
//     {
//         Console.WriteLine($"{current} - {current * current}");
//         current++;
//     }
// }
// int num = EnterNum("Введите число: ");
// Quad(num);

// // Task 4. Напишите программу, которая принимает на вход координаты двух точек 
// //         и находит расстояние между ними в 2D пространстве.
double Gipot (double x1, double y1, double x2, double y2)
{
    double distX = x2-x1;
    double distY = y2-y1;
    double result = Math.Sqrt(distX*distX + distY*distY);
    return result;
}
Console.Write ("Введите значение x1 - ");
int x1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите значение y1 - ");
int y1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите значение x2 - ");
int x2 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите значение y2 - ");
int y2 = Convert.ToInt32(Console.ReadLine()); 

double rez = Math.Round(Gipot (x1,y1,x2,y2),4);

Console.Write ($"Расстояние между точками 1 и 2  составляет  - {rez}");