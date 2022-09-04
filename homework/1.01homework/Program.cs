/* Задача 2.
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 

Console.Write("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (number1 > number2)
    max = number1;
else max = number2;

Console.WriteLine($"Максимальное число {max}");
*/

/* Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 
*/
/*
Console.Write("введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
int max;

if (a > b) max = a;
else max = b;
if (c > max) max = c;

Console.WriteLine($"Максимальное число {max}");*/

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */
/*
Console.Write("введите число ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) Console.WriteLine($"{a} - четное число");
else Console.WriteLine($"{a} -  нечетное число");
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */
/*
Console.Write("введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index < N)

   { if (index % 2 == 0)
        Console.Write($"{index},  ");
    index++;
   } */