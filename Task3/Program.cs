// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();

Console.WriteLine("Введите номер четверти плоскости, в которой хотите задать координаты: ");

int quarter = int.Parse(Console.ReadLine());

while(quarter < 1 || quarter > 4)

{
Console.WriteLine("\nЭто не номер четверти. Введите цифру от 1 до 4: ");
quarter = int.Parse(Console.ReadLine() ?? "0");
}

if (quarter == 1)
    {
        Console.WriteLine("\nВы можете использовать положительные цифры от 0 до бесконечности по X и Y");
        Console.WriteLine();
    }
    else if (quarter == 2)
    {
        Console.WriteLine("\nВы можете использовать положительные цифры от 0 до бесконечности по Y и отрицательные от 0 до бесконечности по X");
        Console.WriteLine();
    }
    else if (quarter == 3)
    {
        Console.WriteLine("\nВы можете использовать отрицательные цифры от 0 до бесконечности по X и Y");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("\nВы можете использовать отрицательные цифры от 0 до бесконечности по Y и положительные от 0 до бесконечности по X");
        Console.WriteLine();
    }
