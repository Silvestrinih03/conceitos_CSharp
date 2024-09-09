using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        
        // Declarando e inicializando um array de inteiros
        int[] numeros = { 1, 2, 3, 4, 5 };

        // Exibindo os elementos do array
        Console.WriteLine("Elementos do array:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}