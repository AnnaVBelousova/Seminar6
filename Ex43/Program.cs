// See https://aka.ms/new-console-template for more information
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
int k1 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());


int x;
int y;
if (k1 == k2) 
{
Console.WriteLine("Прямые не пересекаются");
}
else
{
    x = (b2 - b1)/(k1-k2);
    y = k1 * x + b1;


Console.WriteLine("x = "+ Convert.ToString(x));
Console.WriteLine("y = "+ Convert.ToString(y));
}