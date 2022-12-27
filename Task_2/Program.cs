 //Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int a1, a2, a3;
int b1, b2, b3;

Console.WriteLine("Введите посследовательность координат: ");
Console.Write("a1: ");
a1 = Console.WriteLine(Console.ReadLine());
Console.Write("a2: ");
a2 = Console.WriteLine(Console.ReadLine());
Console.Write("a3: ");
a3 = Console.WriteLine(Console.ReadLine());

Console.Write("b1: ");
b1 = Console.ReadLine(Console.ReadLine());
Console.Write("b2: ");
b2 = Console.ReadLine(Console.ReadLine());
Console.Write("b3: ");
b3 = Console.ReadLine(Console.ReadLine());

double resultDoub = Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2) + Math.Pow(b3 - a3, 2);
double resultDoub = Math.Sqrt(resultDoub);
double resultDoub = Math.Round(resultDoub, 2);
Console.WriteLine(resultDoub);

/* я так и не нашел команды которые помагли б мне с решением этой задачи*/