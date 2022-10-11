/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4 */



Console.WriteLine("Введи количество чисел ");
int CountNumbers = int.Parse(Console.ReadLine());
int[] array = new int[CountNumbers];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введи число под номером - {i}");
    array[i] = int.Parse(Console.ReadLine());
    
}
for (int i = 0; i < array.Length; i++)
{

if (array[i] > 0)
    {
        count = count + 1;
    }
    
}
Console.WriteLine($"Количество положительных введенных чисел  [{String.Join(" ,", array)}] = {count}");


/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введи b1");
double b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введи k1");
double k1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введи b2");
double b2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введи k2");
double k2 = int.Parse(Console.ReadLine());

double x =  (b1 - b2) / (k2 - k1) ; // k2 * x + b2 = k1 * x + b1 ; k2X - k1X = b1 - b2 ; /9X - 5X = 2 - 4  4x = -2  x = -0.5 
double y = k2 * x + b2 ; // y = 9 * -0.5 + 4 y = -0.5

// Console.WriteLine($"({b1} - {b2}) / ({k2} - {k1})");
Console.WriteLine($"Точка пересечения двух прямых имеет координаты ({x};{y})");

