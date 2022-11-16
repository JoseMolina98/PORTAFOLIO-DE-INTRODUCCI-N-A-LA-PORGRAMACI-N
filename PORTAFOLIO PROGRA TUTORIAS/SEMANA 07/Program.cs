// See https://aka.ms/new-console-template for more information
Console.WriteLine("Actividad No. 03. Laboratorio");
double a, b;

Console.WriteLine("Ingrese un primer valor: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un segundo valor: ");
b = double.Parse(Console.ReadLine());   

if (a >= b)
{
    Console.WriteLine("verdadero");
}

else 
{
    Console.WriteLine("Falso");
}

Console.ReadKey();