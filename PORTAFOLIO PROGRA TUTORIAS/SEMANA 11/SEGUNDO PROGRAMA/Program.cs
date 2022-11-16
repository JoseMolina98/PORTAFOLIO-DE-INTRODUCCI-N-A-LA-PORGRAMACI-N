// See https://aka.ms/new-console-template for more information


int[,] matriz = new int[5,2];
Console.WriteLine("Ingrese los valores de la matriz");
matriz[0,0] = int.Parse(Console.ReadLine());
matriz[1,0] = int.Parse(Console.ReadLine());
matriz[2,0] = int.Parse(Console.ReadLine());
matriz[3,0] = int.Parse(Console.ReadLine());
matriz[4,0] = int.Parse(Console.ReadLine());
matriz[0,1] = int.Parse(Console.ReadLine());
matriz[1,1] = int.Parse(Console.ReadLine());
matriz[2,1] = int.Parse(Console.ReadLine());
matriz[3,1] = int.Parse(Console.ReadLine());
matriz[4,1] = int.Parse(Console.ReadLine());



Console.WriteLine("El doble de los números es: "); 
for (int i = 0; i < matriz.GetLength(0);  i++)   
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i,j] = matriz[i,j] * matriz[i,j];
        Console.Write(matriz[i,j] + " ");    
    }
    Console.WriteLine(" ");
}

Console.WriteLine("El promedio de sus dobles es: ");

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i, j] = (matriz[i, j] * matriz[i, j]) / 2;
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine(" ");
}
