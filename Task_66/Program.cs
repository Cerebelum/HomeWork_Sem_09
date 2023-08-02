// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElementsMtoNRec(int startNumber, int finishNumber)
{
    if (finishNumber == startNumber) return startNumber;
    return finishNumber += SumElementsMtoNRec(startNumber, finishNumber - 1);
}

int PromptNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = PromptNumber("Введите начальное число: ");
int n = PromptNumber("Введите конечное число: ");
Console.WriteLine($"Сумма чисел от {m} до {n} равна {SumElementsMtoNRec(m, n)}");
