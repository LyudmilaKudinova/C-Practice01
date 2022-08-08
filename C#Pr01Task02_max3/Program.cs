// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

int a = 2;
int b = 3;
int c = 7;

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

int d = 44;
int e = 5;
int f = 78;

Console.WriteLine("Найти максимальное число из: ");
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);

int max1 = d;

if (d > max1) max1 = d;
if (e > max1) max1 = e;
if (f > max1) max1 = f;

Console.Write("Максимальное из трёх чисел равно: ");
Console.WriteLine(max1);

int a1 = 22;
int b1 = 3;
int c1 = 9;

Console.WriteLine("Найти максимальное число из: ");
Console.WriteLine(a1);
Console.WriteLine(b1);
Console.WriteLine(c1);

int max2 = a1;

if (a1 > max2) max2 = a1;
if (b1 > max2) max2 = b1;
if (c1 > max2) max2 = c1;

Console.Write("Максимальное из трёх чисел равно: ");
Console.WriteLine(max2);