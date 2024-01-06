using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace primeiro_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Tipos de dados e variáveis
            // int - inteiros
            // real - double
            // char - caracter ''
            // string - texto ""
            // bool - lógico (s/n)

            int idade;
            double altura;
            char genero;
            string nome;

            idade = 20;
            altura = 1.60;
            genero = 'F';
            nome = "Nicole";

            Console.WriteLine("Tipos de dados");
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine(genero);
            Console.WriteLine(nome);
            Console.WriteLine(nome + " tem " + idade + " anos de idade e " + altura + "m de altura");

            int a=10, b=5;
            //Operações
            Console.WriteLine();
            Console.WriteLine("Operações");
            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine(a%b);

            //Saída de dados
            //Console.Write("Imprime sem quebrar linha");
            //Console.WriteLine("Imprime com quebra de linha");

            // Imprimir apenas duas casas decimais - necessário importar biblioteca "System.Globalization"
            Console.WriteLine();
            Console.WriteLine("Imprimir números decimais com formatação");
            CultureInfo CI = CultureInfo.InvariantCulture;
            double x = 2.3456;
            Console.WriteLine(x.ToString("F2", CI));
        }
    }
}