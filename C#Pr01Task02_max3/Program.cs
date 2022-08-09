// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел:

Console.WriteLine("Введите три целых числа: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Найти максимальное число из: ");
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное из трёх чисел равно: ");
Console.WriteLine(max);