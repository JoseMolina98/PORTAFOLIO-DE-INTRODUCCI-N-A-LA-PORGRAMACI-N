// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Enunciado :
// Crear un programa que evalue edad de una persona y sepa si es menor de 10 años su entrada es gratis
// Si es mayor de 10 y menor de 15 su entrada vale Q15.00
// Si es mayor de 15 años y menor de 21 su entrada vale Q.25.00
// Si es mayor de 21 años su entrada vale Q.35.00
// Si es de la tercera edad su entrada es gratis
// Si es menor de 10 años solo puede ver PG 13
// Si es mayor de 10 años y menor de 15 años puede ver PG13 y PG15 si está acompañado de un adulto. 
// Si es mayor de 15 años y menor de 21 años puede ver PG15
// Si es mayor de 21 años puede ver todas.
// Si es de la tercera edad puede ver todas. 




// Variables: Edad, Precio, clasificación

int edad;
double precio;
string clasificación;
string adulto = "";

Console.WriteLine("==========Bienvenido al Cine ==========");
Console.WriteLine("Ingrese edad :");
edad = Convert.ToInt32(Console.ReadLine());

if (edad < 10) 
{
    Console.WriteLine("El costo de la entrada es Q.0.00");
}
else
{
if (edad >10 && edad <15)
    {
        Console.WriteLine("¿Estas acompañado de un adulto?");
        adulto = Console.ReadLine();

        if (adulto.ToLower() == "si")
        {
            clasificación = "PG15";
        }
        else
        {
            clasificación = "PG13";
        }
        precio = 15.00;
       
        Console.WriteLine("El costo de entrada es " +"Q."+ precio + " y su clasificación es " + clasificación);
    }
else
    {
        if (edad > 15 && edad < 21)
        {
            Console.WriteLine("El costo de la entrada es de Q.25.00 y su clasificación es PG15");
        }
        else
        {
            if (edad > 21 && edad < 60)
            {
                Console.WriteLine("El costo de la entrada es de Q.35.00 y puede ver cualquier clasificación");
            }
            else
            {
                if (edad > 60) ;
                {
                    Console.WriteLine("El costo de la entrada es Q.0.00 y puede ver cualquier clasificación");
                }
            }
        }
        
    }
}


Console.ReadKey();


