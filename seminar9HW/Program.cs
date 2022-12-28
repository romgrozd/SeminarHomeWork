// Домашняя работа 9.

// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
}
ShowNums(6);
*/

// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.Write("Input a number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int GetSumOfNums(int numM, int numN)
{
    if (numM == 0) return(numN * (numN + 1)) / 2;            
    else if(numN == 0) return(numM * (numM + 1)) / 2;       
    else if(numM == numN) return numM;                      
    else if(numM < numN) return numN + GetSumOfNums(numM, numN - 1);
    else return numM + GetSumOfNums(numN, numM + 1);     
}
Console.WriteLine($"Sum between numbers M and N = {GetSumOfNums(numM, numN)}");
*/

// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
Console.Write("Input a number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int AckermanFunction (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numN == 0) return AckermanFunction(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckermanFunction(numM - 1, AckermanFunction(numM, numN - 1));
return AckermanFunction(numM, numN);
}

Console.WriteLine($"Ackerman function is: A(m,n) = {AckermanFunction(numM, numN)}");
*/