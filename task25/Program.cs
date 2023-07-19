// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double GetDegree (int foundation, int degree)
{
    return Math.Pow (foundation, degree);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = GetInput("Введите основание: ");
int numberB = GetInput("Введите степень: ");
Console.WriteLine($"{numberA}, {numberB} -> {GetDegree(numberA, numberB)}");
