// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. Комментарий

//
Console.WriteLine("введите 3 числа и выведите какое больше");
int a, b, m;
Console.WriteLine("введите первое число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
m = Convert.ToInt32(Console.ReadLine());
if (a < b && b > m) 
{
    Console.WriteLine("  b  ");
}
else
{
    Console.WriteLine("  c  ");
}