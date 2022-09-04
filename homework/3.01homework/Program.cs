/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да  */

/* Console.Write("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int FindPolindrom(int number)
{
    int firstNumber = number / 10000;
    int secondNumber = number % 10000 / 1000;
    int fourNumber = number % 100 / 10;
    int fifthNumber = number % 10;
    if (firstNumber == fifthNumber && secondNumber == fourNumber)
        Console.WriteLine($"{number} - является палиндромом.");
    else Console.WriteLine($"{number} - не является палиндромом.");
    return (number);
}

int polindrom = FindPolindrom(number);
*/
/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/*
Console.Write("Введите значение А - х1 ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение А - y1 ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение А - z1 ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение B - х2 ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение B - y2 ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение B - z2 ");
double z2 = Convert.ToInt32(Console.ReadLine());

double FindDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine($"Расстояние между данными точками составляет {distance}");
    return distance;
}

double dis = FindDistance(x1,y1,z1,x2,y2,z2);
*/
/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/*
Console.Write("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int FindKub(double N)
{   
    int kub = 1;
    int i = 1;
    while (i <= N)
    {
        kub = i * i * i;
        Console.Write($"{kub} ");
        i+=1;
    }
    return kub;
} 

int Kubik = FindKub(N);
*/


