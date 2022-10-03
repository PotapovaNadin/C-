/*Задача 64
Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа
в промежутке от M до N.
*/
/*

void ShowNums (int m, int n)
{
    if(n > m) ShowNums(m, n - 1);
    Console.Write(n + " ");
}

ShowNums(2,6);

*/
/*
Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int ShowNums (int m, int n)
{
    if(n >= m) return ShowNums(m, n - 1) + n;
    else return 0;
}

Console.Write(ShowNums(1,15));
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/
/*
int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AkkermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
return AkkermanFunction(m, n);
}

Console.WriteLine(AkkermanFunction(3,2));
*/