/* Задача 2

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int x1 = Prompt("Введите X1 =>");
int y1 = Prompt("Введите Y1 =>");
int z1 = Prompt("Введите Z1 =>");
int x2 = Prompt("Введите X2 =>");
int y2 = Prompt("Введите Y2 =>");
int z2 = Prompt("Введите Z2 =>");

//AB = √(xb — xa)2 + (yb — ya)2 + (zb — za)2
double result = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);

System.Console.WriteLine(result);