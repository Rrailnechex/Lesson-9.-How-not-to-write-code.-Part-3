

/* 
Задайте значение N. Напишите программу, которая 
выведет все чётные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2,"

 */

int SolveTasc64(int num, int i)
{
    if (i == num) return 0;
    else
        if (num % 2 == 0) Console.Write($"{num}, ");
    return SolveTasc64(num - 1, i);
}


Console.Write("num: ");
int num = int.Parse(Console.ReadLine());

Console.Write($"'");
SolveTasc64(num, 1);
Console.Write($"'");