// Задача 6. Напишите программу, которая на вход принимает число  и выдаёт является ли число чётным.

Console.WriteLine("Введите любое целое число  ");

int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0) 
{
    Console.WriteLine("Ура! Это чётное число.");
}

else
{
    Console.WriteLine("Упсс... Это не чётное число.");
}
