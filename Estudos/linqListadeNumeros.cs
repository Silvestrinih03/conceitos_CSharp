using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        /*LINQ (Language Integrated Query) - conjunto de recursos do C# que permite 
        consultar coleções de dados de maneira similar ao SQL. LINQ pode ser usado 
        para manipular e consultar vários tipos de fontes de dados, como coleções 
        de objetos em memória (ex.: arrays, listas), bancos de dados, XML, 
        e até mesmo fontes de dados remotos..*/
        
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // LINQ para selecionar números pares
        var numerosPares = from numero in numeros
                           where numero % 2 == 0
                           select numero;

        Console.WriteLine("Números pares:");
        foreach (var numero in numerosPares)
        {
            Console.WriteLine(numero);
        }
    }
}
