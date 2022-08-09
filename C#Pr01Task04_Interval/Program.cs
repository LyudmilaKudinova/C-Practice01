// Задача 8. Напишите программу, которая на вход принимаеи число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите любое целое положительное число  ");

int N = Convert.ToInt32(Console.ReadLine());

if(N < 0)
{
   Console.Write("Error! Это отрицательное число."); 
}

for(int x = 1; x < N; x++)
if (x % 2 == 0)
Console.WriteLine(x);
