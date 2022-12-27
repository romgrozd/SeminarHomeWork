// Домашняя работа 8.
/*
int[,] CreateRandomArray()
{   
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue, maxValue + 1);
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
*/

// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void SortToDescendingNumArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int n = 0; n < array.GetLength(1) - 1; n++)
            {
                if(array[i, n] < array[i, n + 1])
                {
                    int temp = array[i, n + 1];
                    array[i, n + 1] = array[i, n];
                    array[i, n] = temp;
                }
            }    
        }
    }
}
int[,] myArray = CreateRandomArray();
Show2dArray(myArray);
SortToDescendingNumArray(myArray);
Show2dArray(myArray);
*/

//Задача 2.Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
void MinSumOfRowsArray(int[,] array)
{
    int sum = 0;
    int indexMinRow = 0;
    int minSum = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        minSum += array[0, j];
    }
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if(sum < minSum)
        { 
            minSum = sum;
            indexMinRow = i;
        }
        sum = 0;
    }
    Console.Write($"Number of row with min sum of elements is {indexMinRow + 1}");
    
}
int[,] myArray = CreateRandomArray();
Show2dArray(myArray);
MinSumOfRowsArray(myArray);
*/

// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateMatrix()
{   
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] matrix1 = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        matrix1[i,j] = new Random().Next(minValue, maxValue + 1);
    return matrix1;
}


void ShowMatrix(int[,] matrix1)
{
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
            Console.Write(matrix1[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}   

int[,] matrixFirst = CreateMatrix();
int[,] matrixSecond = CreateMatrix();
ShowMatrix(matrixFirst);
ShowMatrix(matrixSecond);
int[,] resultMatrix = MultiplicationMatrix(matrixFirst, matrixSecond);
ShowMatrix(resultMatrix);
*/


// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[,,] CreateRandom3dArray()
{   
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of planes: ");
    int planes = Convert.ToInt32(Console.ReadLine());

    int[,,] array = new int[rows, columns, planes];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < planes; k++)
            array[i,j,k] = new Random().Next(10, 99);
        }    
    return array;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for(int k = 0; k < array.GetLength(2); k++)

            Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
            Console.WriteLine();
        }    
        
    }
}

int[,,] myArray = CreateRandom3dArray();
Show3dArray(myArray);
*/

// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
int[,] SpiralArray()
{
    int N = 4;
    int M = 4;
    int[,] array = new int[N, M];

    int startI = 0, endI = 0, startJ = 0, endJ = 0;

    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= N * M)
    {
        array[i, j] = k;
        if (i == startI && j < M - endJ - 1) j++;
        else if (j == M - endJ - 1 && i < N - endI - 1) i++;
        else if (i == N - endI - 1 && j > startJ) j--;
        else i--;

        if ((i == startI + 1) && (j == startJ) && (startJ != M - endJ - 1))
        {
            startI++;
            endI++;
            startJ++;
            endJ++;
        }
        k++;
    }
    return array;
}

void ShowSpiralArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = SpiralArray();
ShowSpiralArray(myArray);
*/

