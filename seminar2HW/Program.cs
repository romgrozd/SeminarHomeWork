// Домашняя работа 2.

// Задача 1. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

/*
int CutNumber(int num)
{
    int des = num % 100;
    int result = des / 10;
    return result;
}

Console.WriteLine("Input a three digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int SedNum = CutNumber(num);

Console.WriteLine($"Second number {num} is {SedNum}");
*/

// Задача 2. Напишите программу, которая выводит третью цифру числа и сообщает, что третьей цифры нет.

/*
Console.WriteLine("Input a number: ");
int num = Convert.Toint32(Console.ReadLine());

void Third(int num)
{
    string numText = Convert.ToString(num);
    if(numText.Length > 2)
    {
        Console.WriteLine($"Third number: {numText[2]} ");
    }
}
Third(num);
*/

// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.WriteLine("Input a number representing the day of the week");
int numDay = Convert.ToInt32(Console.ReadLine());

void DayCheck(int numDay)
{
    if(numDay == 6 || numDay == 7)
    {
        Console.WriteLine("This day is weekend");
    }
    else
    Console.WriteLine("This day is not weekend");
}
DayCheck(numDay);
*/