


/* 
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */



int SolveTask66(int start, int trueStart, int dist)
{
    if (dist == 0) return start;
    else
        trueStart++; start = start + trueStart; dist--;
    return SolveTask66(start, trueStart, dist);
}



Console.Write("start: ");
int start = int.Parse(Console.ReadLine());

Console.Write("end: ");
int end = int.Parse(Console.ReadLine());

int dist = end - start;

Console.WriteLine($"Сумма наткральных элементов: {SolveTask66(start, start, dist)}");