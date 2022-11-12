

/* 
Задайте значение N. Напишите программу, которая 
выведет все чётные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2,"

 */
// f z tve ujdjh.

int SolveTasc64(int num)
{
    if (i >= num) return 0;
    else
        Console.WriteLine(num);
    return SolveTasc64(i + 1);
}


Console.Write("num: ");
int num = int.Parse(Console.ReadLine());

SolveTasc64(num);