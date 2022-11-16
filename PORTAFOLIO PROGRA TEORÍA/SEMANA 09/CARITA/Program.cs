// See https://aka.ms/new-console-template for more information
/* 
 * Análisis 
 * Dibujar una carita con figura geométricas
 * Entradas: 
 * - Necesitamos que ingresen en la pantalla? No
 * - Sabemos como imprimir en pantalla? Si
 * - Que necesitamos? Círculos, rectángulos, triangulos 
 * - Descomposición? - Un método por figura para dibujarlos y un método para imprimir todo en pantalla 
 * 
 * Procesos: 
 * - Declarar variables 
 * - Crear la figura usando caracteres ***
 * - Imprimir
 * 
 * Salidas: 
 * - Carita dibujada en la pantalla 
 */

Console.WriteLine("Ejercicio Carita");
imprimirFigura();
// Declara Variables 
string circulo;
string rectangulo;
string triangulo; 

string crearRectangulo()
{
    return rectangulo = "******************* \n" +
                        "                 *                 * \n" +
                        "                 ******************* \n";
    
}


//Salto "\n"

string crearTringulo()
{
    return triangulo = "  *             *   \n" +
                "                * *           * *\n" +
                "               *   *         *   *\n" +
                "              *******       *******\n";
}

void crearCirculo()
{
    circulo = "                    ***************                  \n" +
              "                  ***             ***            \n" +
              "               ***                  ***          \n" +
              "             ***                      ***        \n" +
              "           ***                          ***      \n" +
              "         ***                              ***    \n" +
              "       ***     " + crearTringulo() +"        ***  \n" +
              "    ****                                      **** \n" +
              "    ****                                      **** \n" +
              "       ***                                  ***  \n" +
              "         ***     "+ crearRectangulo() +"  ***    \n" +
              "           ***                          ***      \n" +
              "             ***                      ***        \n" +
              "               ***                  ***          \n" +
              "                 ***              ***            \n" +
              "                 **************** \n";
    Console.WriteLine(circulo);
}

void imprimirFigura()
{
    crearCirculo();
    crearTringulo();
    crearRectangulo();
}


Console.ReadKey();