// Домашняя работа 3. 

// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндром.

/*
void Palindrom(int num)
{
    int temp = num;
    int reverse = 0;
    while(temp > 0)
    {
        int des = num % 10;
        reverse = reverse * 10 + temp % 10;
        temp = temp / 10;
    }
    if(num == reverse)
    {
        Console.Write($"{num} is palindrom.");
    }
    else
    Console.Write(%'{num} is not palindrom.");
}

Console.Write("Input an number ");
int num = Convert.ToInt32(Console.ReadLine());

Palindrom(num);
*/

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double Length = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    return Math.Round(Length, 2);
}

Console.Write("Input an x-coordinate of point A: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an y-coordinate of point A: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an z-coordinate of point A: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an x-coordinate of point B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an y-coordinate of point B: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an z-coordinate of point B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distanceBetweenAB = Distance(xA, yA, zA, xB, yB, zB);

Console.WriteLine($'Distance between points A and B is {distanceBetweenAB}");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов от 1 до N.

/*
void Cube(num)
{
    int counter = 1:
    while(counter <= num)
    {
        Console.Write($"{Meth.Pow(counter, 3)}");
        if(counter != num) Condsole.Write(", ');
        else Console.Write(". ");
    }
}

Console.WriteLine("Input an integer number ");
int num = Convert.ToInt32(Console.ReadLine());

Consdole.Write("The series of cube of number: ");
Cube(num);
*/