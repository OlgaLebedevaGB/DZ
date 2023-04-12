// семинар 2

// Задача1 Напишите программу, 
// которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

int CutNumber(int num)
{
    int hunderds = num / 100;
    int units = num % 10;

    int result = hunderds * 10 + units;
    return result;
}

int randNumber = new Random().Next(100, 1000);
int shortNumber = CutNumber(randNumber);

Console.Writeline($"New version of {randNumber} is {shortNumber}");


