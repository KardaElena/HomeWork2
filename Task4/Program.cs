// Найти расстояние между точками в пространстве 2D/3D


Console.Clear();

Console.WriteLine("В этой программе вы можете найти расстояние между двумя точками в пространстве. \nВведите цифру 2, чтобы выбрать 2D или цифру 3, чтобы выбрать 3D: ");
int a = int.Parse(Console.ReadLine() ?? "0");
double z1 = 0, z2 = 0;

Console.WriteLine();

while (a<2 || a>3)

{
    Console.WriteLine("Это не похоже на то, что нужно. Введите 2 или 3: ");
    a = int.Parse(Console.ReadLine() ?? "0");
}

Console.WriteLine("Введите координату первой точки по X: ");
double x1 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите координату второй точки по X: ");
double x2 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите координату первой точки по Y: ");
double y1 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите координату второй точки по Y: ");
double y2 = double.Parse(Console.ReadLine() ?? "0");

if (a == 3)

{Console.WriteLine("Введите координату первой точки по Z: ");
z1 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите координату второй точки по Z: ");
z2 = double.Parse(Console.ReadLine() ?? "0");}

Console.WriteLine($"\nРасстояние между двумя точками равно {Math.Sqrt((Math.Pow(x2-x1, 2)) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2))}");

Console.WriteLine();



