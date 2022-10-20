// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();

Console.WriteLine("В этой программе вы можете проверить, является ли одно число квадратом другого.");

Console.WriteLine("\nВведите меньшее число: ");

int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("\nВведите большее число: ");

int b = int.Parse(Console.ReadLine() ?? "0");

if (Math.Pow(a,2) == b)

Console.WriteLine($"\nЧисло {b} является квадратом числа {a}");

else

Console.WriteLine($"\nЧисло {b} не является квадратом числа {a}");

Console.WriteLine();