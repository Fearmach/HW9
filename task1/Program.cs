// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void GapNumberSum(int numM, int numN, int sum)
{
if (numM > numN)
{
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
return;
}
sum += (numM++);
GapNumberSum(numM, numN, sum);
}

Console.WriteLine("Введите начальное число M:");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число N:");
int N = int.Parse(Console.ReadLine());

GapNumberSum(M, N, 0);
