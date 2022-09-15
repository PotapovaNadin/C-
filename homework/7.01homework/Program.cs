﻿/*
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
/*
double [,] CreateRandom2dArray()
{
    Console.Write("Input number of rows : ");
    int m = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Input number of columns : ");
    int n = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Input min possible value : ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value : ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double [,] newArray = new double[m, n];

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            newArray[i,j] = Convert.ToDouble(new Random().Next(minValue*10, maxValue*10))/10;
        }
    }

    return newArray;
}

void Show2dArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }

}

double [,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/

/*
Задача 50. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
/*
int [,] CreateRandom2dArray()
{
    Console.Write("Input number of rows : ");
    int rows = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Input number of columns : ");
    int columns = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Input min possible value : ");
    int minValue = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Input max possible value : ");
    int maxValue = Convert.ToInt32 (Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

void FindElement (int [,] array)
{   Console.Write("Input posision of rows: ");
    int r = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Input posision of columns : ");
    int c = Convert.ToInt32 (Console.ReadLine());
    if (r > array.GetLength(0) || c > array.GetLength(1))
        Console.WriteLine("The number is not in the array");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (r == i && c == j)
                Console.WriteLine(array[i,j]);
        }
    }
}

int [,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
FindElement(newArray); 
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

/*
Console.Write("Input number of rows : ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input number of columns : ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input min possible value : ");
int minValue = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input max possible value : ");
int maxValue = Convert.ToInt32 (Console.ReadLine());

int [,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
Console.WriteLine($"{SredColumns(newArray)}");

int [,] CreateRandom2dArray()
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }

}

double SredColumns (int [,] array)
{
    double sum = 0;
    double sred = 0;
   
    for(int j = 0; j < array.GetLength(1); j++)       
        {
            for (int i = 0; i < array.GetLength(0); i++)
            sum += array [i,j];    
            Console.Write($"{sred = sum/columns} ", " ");
            sum = 0;
        }
    
        Console.WriteLine();
    return sum;
}    
*/
