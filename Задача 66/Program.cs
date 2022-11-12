


/* 
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

//int[] theArray = new int[];

int SolveTask66(int m, int n)
{
    return m == n - 1 ? m : SolveTask66(m + 1, n) + m;
}



Console.Write("m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма наткральных элементов: {SolveTask66(m + 1, n)}");