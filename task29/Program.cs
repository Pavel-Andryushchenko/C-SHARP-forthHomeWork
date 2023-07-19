// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] RandomizeArray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

int[] InpootArray()
{
    Console.WriteLine("Введите массив из 8 элементов: ");
    int[] mas = new int[8];
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"Введите {i + 1} элемет: ");
        mas[i] = Convert.ToInt32(Console.ReadLine());
    }
    return mas;
}

int GetInput()
{
    Console.WriteLine("Введите 1 для ввода массива с клавиатуры");
    Console.WriteLine("Введите 2 для заполнения массива случайным образом");
    return Convert.ToInt32(Console.ReadLine());
}

int variety = GetInput();
int[] arr = new int[8];
if (variety == 1)
{
    arr = InpootArray();
    Console.Write($"[{string.Join(", ", arr)}]");
}
else
{
    if (variety == 2)
    {
    arr = RandomizeArray();
    Console.Write($"[{string.Join(", ", arr)}]");
    }
    else
    {
        Console.WriteLine("Некорректный ввод!");
    }
}








