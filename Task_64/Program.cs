// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NaturNumNto1Rec(int number)
{
    if (number == 1) return number.ToString();
    return number + ", " + NaturNumNto1Rec(number - 1);
}

int PromptNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = PromptNumber("Задайте число : ");
Console.WriteLine($"{NaturNumNto1Rec(num)}");
