// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumDigit(int num)
{
    int count = 0;
    num = Math.Abs(num);
    while (num > 0)
    {
        count = count + num % 10;
        num = num / 10;
    }
    return count;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число: ");
Console.WriteLine($"{number} -> {GetSumDigit(number)}");
