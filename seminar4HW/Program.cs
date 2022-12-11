// Домашняя работа 4

// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int ExponentNumber(int numA, int numB)
{
    int result = 1;
    int current = 1; 
    while(current <= numB) 
    {
      result = result * numA;
      current++;
    }
        return result;
    
}
Console.WriteLine("Input an integer number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input an integer number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int result = ExponentNumber(numA, numB);
Console.WriteLine($"{numA} exponentiantion {numB} is {result}.");
*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumOfDigits(int num)
{
    int sum = 0;
    while(num > 0)
    {
        int digit = num % 10;
        sum += digit;
        num /= 10;
    }
    return sum;
}
Console.Write("Input an integer number ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SumOfDigits(num);
Console.WriteLine($"Sum digits of num is {result}.");
*/

// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[8];
    for(int i = 0; i < 8; i++)
    {
        Console.Write($"Input elemet of array index {i}: ");
        array[i] = Convert.ToInt32(Console. ReadLine());
    }
    return array;
} 
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] array = CreateArray(8);
ShowArray(array);
*/





    
   

    
    



