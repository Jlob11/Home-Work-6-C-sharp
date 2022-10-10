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