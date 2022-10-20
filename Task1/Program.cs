// Дано число, обозначающее день недели. Выяснить, является ли номер дня недели выходным

Console.Clear();

Console.WriteLine("В этой программе вы можете узнать по номеру дня недели, является ли он выходным.");
Console.WriteLine("\nВведите номер дня недели: ");

int number = int.Parse(Console.ReadLine() ?? "0");

while (number < 1 || number > 7)
{
Console.WriteLine("Это не номер дня недели. Введите номер дня недели от 1 до 7: ");
number = int.Parse(Console.ReadLine() ?? "0");
}

if (number == 6 || number == 7)
Console.WriteLine("Это выходной день");

else
Console.WriteLine("Это будний день");


