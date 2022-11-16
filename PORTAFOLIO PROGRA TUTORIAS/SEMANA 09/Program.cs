// See https://aka.ms/new-console-template for more information
int Calificacion;
Console.WriteLine("Ingrese la calificación obtenida: ");
int Calificación = int.Parse(Console.ReadLine());
if ((Calificación >= 0) && (Calificación <= 49))
{
    Console.WriteLine("La calificación obtenida es F ");
}
else if ((Calificación >= 50) && (Calificación <= 59))
{
    Console.WriteLine("La calificación obtenida es E");
}
else if ((Calificación >= 60) && (Calificación <= 69))
{
    Console.WriteLine("La calificación obtenida es D");
}
else if ((Calificación >= 70) && (Calificación <= 79))
{
    Console.WriteLine("La calificación obtenida es C");
}
else if ((Calificación >= 80) && (Calificación <= 89))
{
    Console.WriteLine("La calificación obtenida es B");
}
else if ((Calificación >= 90) && (Calificación <= 100))
{
    Console.WriteLine("La calificación obtenida es A");
}
else if (Calificación > 100)
{
    Console.WriteLine("La calificación introducida está fuera de rango");
}