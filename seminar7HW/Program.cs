// Домашняя работа 7.

// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandomDoubleArray()
{   
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        array[i,j] = new Random().NextDouble() + new Random().Next(0, 100);
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandomDoubleArray();
Show2dArray(myArray);
*/

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] CreateArray()
{   
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(1, 10);
    return array;
}


void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }    
    Console.WriteLine();
}

/*
void ShowElementArray(int[,] array)
{
    Console.Write("Input index of rows: ");
    int indexRows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input index of columns: ");
    int indexColumns = Convert.ToInt32(Console.ReadLine());
    if(indexRows < array.GetLength(0) && indexColumns < array.GetLength(1))
    Console.WriteLine(array[indexRows, indexColumns]);
    else Console.WriteLine($"{indexRows} , {indexColumns} is absent in array.");
}    

int[,] myArray = CreateArray();
Show2dArray(myArray);
ShowElementArray(myArray);
*/

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Используем массив из второй задачи.


void AverageOfColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];    
        Console.Write($"{sum / array.GetLength(0)} ");
    }      
} 
int[,] myArray = CreateArray();
Show2dArray(myArray); 
AverageOfColumns(myArray);




