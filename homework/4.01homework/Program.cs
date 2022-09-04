/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
/*
int FindDegree(int A, int B)
{
    int degree = 1;
    for(int current = 1; current <= B; current++)
        degree *= A;
    return degree;
}

Console.Write("Imput number A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number B ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number {A} in {B} degree is {FindDegree(A, B)}");
*/
/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
/*
Console.WriteLine("Imput number ");
int num = Convert.ToInt32(Console.ReadLine());
int digit = 0;
int sum = 0;

int FindSumDigit(int num)
{
   while (num > 0)
    {    
        digit = num % 10;
        sum += digit; 
        num /= 10;
    }
    return sum;
}

Console.WriteLine($"Sum digits of {num} is {FindSumDigit(num)}");
*/

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

/*
int[ ] CreateArray(int size)
{
    int [] newArray = new int[size];
    int i = 0;
    while (i < size)
    {
        Console.WriteLine("Imput your number");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.WriteLine("Imput size");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateArray(size));
*/
