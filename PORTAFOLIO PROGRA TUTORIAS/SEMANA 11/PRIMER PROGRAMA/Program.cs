// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

int[,] matriz = new int[3, 3];
Console.WriteLine("Ingrese 9 números para la matriz: ");
matriz[0, 0] = int.Parse(Console.ReadLine());
matriz[1, 0] = int.Parse(Console.ReadLine());
matriz[2, 0] = int.Parse(Console.ReadLine());
matriz[0, 1] = int.Parse(Console.ReadLine());
matriz[1, 1] = int.Parse(Console.ReadLine());
matriz[2, 1] = int.Parse(Console.ReadLine());
matriz[0, 2] = int.Parse(Console.ReadLine());
matriz[1, 2] = int.Parse(Console.ReadLine());
matriz[2, 2] = int.Parse(Console.ReadLine());

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; i++)
    {
        if (matriz[i, j] != matriz[j, i])
        {
            Console.WriteLine("La matriz no es simétrica");
        }
        else
        {
            Console.WriteLine("La matriz es simétrica");
        }
    }
}

