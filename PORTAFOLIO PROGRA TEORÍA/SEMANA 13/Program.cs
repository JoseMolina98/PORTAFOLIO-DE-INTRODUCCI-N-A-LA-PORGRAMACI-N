// See https://aka.ms/new-console-template for more information
int opción;
int menú;
int i;

do
{
    Console.WriteLine("Ingrese una de las opciones");
    Console.WriteLine("1. Ver el menú");
    Console.WriteLine("2. Seleccionar el menú deseado");
    Console.WriteLine("3. Mostrar Total a Pagar por el menú");
    Console.WriteLine("4. Preguntar si desea agregar más menus y agregarlos");
    Console.WriteLine("0. Salir");

    opción = int.Parse(Console.ReadLine());
} while (opción == 0);
   
switch (opción)
{
    case 1:
        Console.WriteLine("Pizza de Peperoni.");
        Console.WriteLine("Su precio es de: Q.125.00");
        Console.WriteLine("Hamburguesa.");
        Console.WriteLine("Su precio es de: Q.35.00");
        Console.WriteLine("Tacos al Pastor");
        Console.WriteLine("Su precio es de: Q. 25.00");
        Console.WriteLine("Burritos de carne");
        Console.WriteLine("Su precio es de: Q.50.00");
        break;

    case 2:
        do
        {
            Console.WriteLine("Seleccione el menú");
            Console.WriteLine("1. Pizza de Peperoni.");
            Console.WriteLine("2. Hamburguesa.");
            Console.WriteLine("3. Tacos al Pastor"); ;
            Console.WriteLine("4. Burritos de carne");
            i = int.Parse(Console.ReadLine());

        } while (i == 0);
        switch (i)
        {
            case 1:
                Console.WriteLine("El valor de este menú es de: Q.125.00");
                int p = 125;
                break;
            case 2:
                Console.WriteLine("El valor de este menú es de: Q.35.00");
                int a = 35;
                break;
            case 3:
                Console.WriteLine("El valor de este menú es de: Q.25.00");
                int b = 25;
                break;
            case 4:
                Console.WriteLine("El valor de este menú es de: Q.50.00");
                int c = 50;
                break;
        }
        break;

    case 3:
        Console.WriteLine("Su total a pagar es: ");
        
        break;

    case 4:
        Console.WriteLine("¿Desea agregar algo más?");
        Console.WriteLine("1. Para agregar más al menú");
        Console.WriteLine("2. Para salir");
        int l = int.Parse(Console.ReadLine());
        if (l == 1)
        {
            switch (opción)
        }
            if (l==2)
            {
                Console.WriteLine("Feliz día");
            }
        break;

    case 0:
        Console.WriteLine("Feliz día");
        break;
            default:
        Console.WriteLine("La opción ingresada no es válida");
        break;
}




