// See https://aka.ms/new-console-template for more information
double F;
double C;
double Temp;
F = 0;
C = 0;

Console.WriteLine("Ingrese una temperatura en Fahrenheit, por favor:");
SolicitarInfo();
double resultado = CalculoTemp(F);

Console.WriteLine("El valor de la temperatura en Celcius es: " + C.ToString());

void SolicitarInfo()
{
    F = Convert.ToDouble(Console.ReadLine());
}

double CalculoTemp(double Temp)
{
    C = (F - 32) * 5/9;
    return C;
}

Console.ReadKey();
