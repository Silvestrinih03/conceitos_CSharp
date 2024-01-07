using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using System.Reflection.Emit; //Formartar números

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

            //int idade;
            //double altura;
            //char genero;
            //string nome;

            //idade = 20;
            //altura = 1.60;
            //genero = 'F';
            //nome = "Nicole";

            //Console.WriteLine("Tipos de dados");
            //Console.WriteLine(idade);
            //Console.WriteLine(altura);
            //Console.WriteLine(genero);
            //Console.WriteLine(nome);
            //Console.WriteLine(nome + " tem " + idade + " anos de idade e " + altura + "m de altura");

            //int a=10, b=5;
            ////Operações
            //Console.WriteLine();
            //Console.WriteLine("Operações");
            //Console.WriteLine(a+b);
            //Console.WriteLine(a-b);
            //Console.WriteLine(a*b);
            //Console.WriteLine(a/b);
            //Console.WriteLine(a%b);

            ////Saída de dados
            ////Console.Write("Imprime sem quebrar linha");
            ////Console.WriteLine("Imprime com quebra de linha");

            //// Imprimir apenas duas casas decimais - necessário importar biblioteca "System.Globalization"
            //Console.WriteLine();
            //Console.WriteLine("Imprimir números decimais com formatação");
            CultureInfo CI = CultureInfo.InvariantCulture;
            //double x = 2.3456;
            //Console.WriteLine(x.ToString("F2", CI));

            //Processamento de dados e casting em C#
            //int x = 5;
            //double y = 2 * x;
            //Console.WriteLine(x);
            //Console.WriteLine(y.ToString("F2", CI));

            //double b1, b2, h, area;
            //b1 = 6.0;
            //b2 = 8.0;
            //h = 5;
            //area = (b1 + b2) / 2 * h;
            //Console.WriteLine();
            //Console.WriteLine(area);


            // Expressões somente com inteiro resulta em um inteiro
            //int a=5, b=2;
            //double resultado = (double)a / b;
            //Console.WriteLine(a + "/" + b + " = " + resultado);

            //double c = 5.2;
            //int d = (int)c;
            //Console.WriteLine();
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            // Entrada de dados
            double salario1, salario2;
            string nome1, nome2;
            int idade;
            char sexo;

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            nome1= Console.ReadLine();

            Console.WriteLine("Digite o salário da primeira pessoa: ");
            salario1=double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            nome2=Console.ReadLine();

            Console.WriteLine("Digite o salário da segunda pessoa: ");
            salario2 =double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Digite uma idade: ");
            idade=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexo: ");
            sexo=char.Parse(Console.ReadLine());

            Console.WriteLine("Nome 1: " + nome1);
            Console.WriteLine("Salário: " + salario1.ToString("F2", CI));
            Console.WriteLine("Nome 2: " + nome2);
            Console.WriteLine("Salário: " + salario2.ToString("F2", CI));
            Console.WriteLine("Idade: "+idade);
            Console.WriteLine("Sexo: "+sexo);

        }
    }
}