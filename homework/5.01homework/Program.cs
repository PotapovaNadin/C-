/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

/*
int[ ] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindPositive (int [] array)
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array [i] % 2 == 0)
            count +=1;
    return count;
}

Console.WriteLine("Imput size");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(size, 100, 999));
FindPositive(CreateRandomArray(size, 100, 999));
int countPositive = FindPositive(CreateRandomArray(size, 100, 999));
Console.WriteLine($"Count of positive number is {countPositive}");
/*


Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int[ ] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindSumNegative (int [] array)
{   
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array [i] < 0)
            sum += array [i];
    return sum;
}

Console.WriteLine("Imput size");
int size = Convert.ToInt32(Console.ReadLine());
int [] currentArray = CreateRandomArray(size, -99, 99);
ShowArray(currentArray);
int sumNegative = FindSumNegative(currentArray);
Console.WriteLine($"Sum of negative numbers is {sumNegative}");
*/

/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76 */

/*
int [ ] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindMin (int [] array)
{   
    int min = array [0];
    for (int i = 0; i < array.Length; i++)
        if (array [i] < min)
            min = array [i];
    return min;
}

int FindMax (int [] array)
{   
    int max = array [0];
    for (int i = 0; i < array.Length; i++)
        if (array [i] > max)
            max = array [i];
    return max;
}

Console.WriteLine("Imput size");
int size = Convert.ToInt32(Console.ReadLine());
int [] currentArray = CreateRandomArray(size, 1, 99);
ShowArray(currentArray);
int min = FindMin(currentArray);
int max = FindMax(currentArray);
Console.WriteLine($"The difference between max and min is {max - min}");
*/
