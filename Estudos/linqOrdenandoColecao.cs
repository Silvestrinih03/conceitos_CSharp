using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] nomes = { "Nicole", "Amanda", "Bruno", "Carlos", "Eduardo" };

        // LINQ para ordenar os nomes alfabeticamente
        var nomesOrdenados = from nome in nomes
                             orderby nome
                             select nome;

        Console.WriteLine("Nomes ordenados:");
        foreach (var nome in nomesOrdenados)
        {
            Console.WriteLine(nome);
        }
    }
}
