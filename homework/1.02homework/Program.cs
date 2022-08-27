/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/* Console.Write("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{(number / 10) % 10}"); */

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* Console.Write("введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int currentNumber = number;

int FindThreeDigit (int third)
{   
    while (currentNumber > 999)
    {
       currentNumber = currentNumber/ 10;
    }
    if (currentNumber > 99)
    {
        third = currentNumber % 10;
        Console.WriteLine($"Третья цифра числа {number} - {third}");
    }
    if (currentNumber < 100)
    {
        Console.WriteLine($"третьей цифры нет");
    }
return (third);
} 
   
int thirdNumber = FindThreeDigit(number);
Console.WriteLine(thirdNumber);  */

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

/* Console.Write("введите число дня недели ");
int number = Convert.ToInt32(Console.ReadLine());

int Vyhodnoi (int number)
{
    if (number == 6 ^ number == 7)
        Console.WriteLine($"{number} - выходной день");
    if (number == 1 ^ number == 2 ^ number == 3 ^ number == 4 ^ number == 5)
        Console.WriteLine($"{number} - рабочий день");
    if (number > 7) 
        Console.WriteLine($"Не существует дня недели под номером {number}");
    return number;
}

int vyh = Vyhodnoi(number);
Console.WriteLine(vyh); */