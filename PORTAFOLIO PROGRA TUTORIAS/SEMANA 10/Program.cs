// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Runtime.CompilerServices;

Console.WriteLine("Ingrese una oración ");
string o = Console.ReadLine();
string[] words = o.Split(' ');

foreach (var word in words)
{
    string[] array = Console.WriteLine(word); 
    string[] list = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] == array[j])
            {
                count++; 
                if (n(array[i]))
                {
                    list[i] = array[i]; 
                }
            }
        }
        if (list[i] != 0)
        {
            Console.WriteLine(list[i] + "se repite: " + count);
        }
    }
    bool n (string num)
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] == num)
            {
                return false;
            }
        }
        return true; 
    }
}



