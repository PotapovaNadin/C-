// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3
/*
Console.WriteLine("Input count numbers ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
int i = 0;

int FindPositiveNumbers (int M)
{
    while(i < M)
        {
            Console.WriteLine("Input number ");
            int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                    count++;
            i++;
        }
    return count;
}

int countPositiveNumbers = FindPositiveNumbers(M);
Console.WriteLine($"Count of positive numbers is {countPositiveNumbers}");
*/

// Задача 43: Напишите программу,
// которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
Console.WriteLine("Input b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());
double y, x;

x = (-b2 + b1)/(-k1 + k2);
y = k2 * x + b2;

Console.WriteLine($"The point of intersection of two straight lines is {x},{y}");
*/
