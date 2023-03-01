// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int progresSum(int St, int Fin)
{
    int PrSum = 1;
    if (Fin > St)
    {
        PrSum = ((Fin + St) * (Fin - St + 1)) / 2;
    }

    return PrSum;
}

System.Console.WriteLine("Entet 1st number: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Entet 2nd number: ");
int b = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"The Profressive sum from {a} to {b} is {progresSum(a, b)}");