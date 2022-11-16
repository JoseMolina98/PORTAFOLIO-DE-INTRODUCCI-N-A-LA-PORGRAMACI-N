// See https://aka.ms/new-console-template for more information
string[] aPalabras = { "HOLA", "Casa", "carro", "LAPIZ", "uno", "dos", "tres", "ocho", "nueve", "diez" };
string nombre = "ejemplo variable";
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Validando mayúsculas... " + aPalabras[i]);
    if (esMayuscula(aPalabras[i]))
    {
        Console.WriteLine("La palabra: " + aPalabras[i] + " es mayúscula");
    }
}

static bool esMayuscula(string input)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (!Char.IsUpper(input[i]))
            return false;
    }
    return true;
}
