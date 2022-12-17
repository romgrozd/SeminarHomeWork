// Домашняя работа 5.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
 {
     int[] array = new int[size];

     for(int i = 0; i < size; i++)
          array[i] = new Random().Next(minValue, maxValue +1);
     return array;
 }


 void ShowArray( int[] array)
 {
     for( int i = 0; i < array.Length; i++)
     {
         Console.Write(array [i] + " ");
     }
     Console.WriteLine();
 }
*/
 // Задача1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int CountOfEvenNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if( array[i] % 2 == 0)
        count++;

    return count;    
} 
 
 Console.Write("Input a number elements: ");
 int size = Convert.ToInt32(Console.ReadLine());
 int[] myArray = CreateRandomArray(size, 100, 999);
 ShowArray(myArray);

 int evenNum = CountOfEvenNum(myArray);
 Console.Write($"The quantity of even numbers is {evenNum}.");
*/


 // Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
 int SumOfOddIndex(int[] array)
 {
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(i % 2 != 0)
            sum += array[i];
    return sum;        
 }

 Console.Write("Input a number elements: ");
 int size = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a min possible value: ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a max possible value ");
 int max = Convert.ToInt32(Console.ReadLine());

 int[] myArray = CreateRandomArray(size, min, max);
 ShowArray(myArray);
 Console.WriteLine();

 int result = SumOfOddIndex(myArray);
 Console.Write($"Sum of odd index is {result}");
*/

 // Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
 {
     double[] array = new double[size];

     for(int i = 0; i < size; i++)
          array[i] = new Random().NextDouble() + new Random().Next(0, 100);
     return array;
 }


 void ShowArray( double[] array)
 {
     for( int i = 0; i < array.Length; i++)
     {
         Console.Write(array [i] + " ");
     }
     Console.WriteLine();
 }

 void DifMinMax(double[] array)
 {
    double minNum = array[0];
    double maxNum = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxNum) maxNum = array[i];
        if(array[i] < minNum) minNum = array[i];
    }

   Console.WriteLine($"max {maxNum}");
   Console.WriteLine($"min {minNum}");
   Console.WriteLine($"Difference between maximum number and minimum number = {maxNum - minNum}");   
 }

Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomDoubleArray(size, 0, 100);
ShowArray(myArray);
Console.WriteLine();
DifMinMax(myArray);
 */

 



