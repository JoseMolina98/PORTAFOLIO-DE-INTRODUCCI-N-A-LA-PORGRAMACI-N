// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;

int[] Vector;
int ContadorDatos = 0;
Console.WriteLine("Ingrese la cantidad");
ContadorDatos = int.Parse(Console.ReadLine());
Vector = new int[ContadorDatos];

for (int i = 0; i < ContadorDatos; i ++)
{
    Console.WriteLine("Ingrese el valor");
    Vector[i] = int.Parse(Console.ReadLine());
    Console.ReadKey();
}

if (Vector[i] % 2 == 0)
{
    Console.WriteLine("Es un número par");
}
else
{
    Console.WriteLine("Es un número impar");
}

