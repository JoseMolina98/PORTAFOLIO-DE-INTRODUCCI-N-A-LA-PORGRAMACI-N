// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;

double r;
double pi;
double h;
double b;
double area;
double P;
double AP;


pi = 3.1416;
r = 0;
h = 0;
b = 0;
P = 0;
AP = 0;

Console.WriteLine("Ingrese un valor para el radio con decimales");
solicitarDatos();
double resultado = CA(r);

Console.WriteLine("El valor del área es: " + area.ToString());

Console.WriteLine("Ingrese el valor de base del rectángulo");
baseDatos();

Console.WriteLine("Ingrese el valor de la altura del rectángulo");
alturaDatos();
double respuesta = PR(P);

Console.WriteLine("El valor del perímetro del rectángulo es: " + P.ToString());
double L = APP(AP); 
Console.WriteLine("El valor del área del rectángulo es: " + AP.ToString());

void solicitarDatos()
{
    r = Convert.ToDouble(Console.ReadLine());
}

void baseDatos()
    {
    b = Convert.ToDouble(Console.ReadLine());
}

void alturaDatos()
{
    h = Convert.ToDouble(Console.ReadLine());
}

double CA(double radio)
{
    area = pi * Math.Pow(r, 2);
    return area; 
}

double PR(double Perimetro)
{
    P = 2 * (b + h);
    return P;
}

double APP(double areaP)
{
    AP = b * h;
    return AP;
}

Console.ReadKey(); 