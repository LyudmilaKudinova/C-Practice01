// Задача №2.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if(b > max)
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(b);
    Console.Write("Наименьшее число: ");
    Console.WriteLine(a);
}
else
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(a);
    Console.Write("Наименьшее число: ");
    Console.WriteLine(b); 
}   

// Проверка выполнена a = 5;  b = 7 -> max = 7  
                   // a = 2;  b = 10 -> max = 10
                    //a = -9; b = -3 -> max = -3