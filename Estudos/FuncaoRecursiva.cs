using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    internal class Teste
    {
        /*Printar de 10 a 0 na tela em um único método*/
        
        public void ContagemRegressiva(int numero)
        {
            if (numero <= 0) { Console.WriteLine("O menor número possível para essa função é 1!"); }
            else
            {
                numero--;

                Console.WriteLine("O numero agora é: " + numero);

                if (numero != 0)
                {
                    ContagemRegressiva(numero);
                }
            }
        }

        //public void metodo2()
        //{
        //    ContagemRegressiva(-1);
        //}
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Teste teste = new Teste();
        
        teste.ContagemRegressiva(10);

        Console.WriteLine("BREAK\n");
        teste.ContagemRegressiva(-1);

        Console.WriteLine("BREAK\n");
        teste.ContagemRegressiva(0);

        Console.ReadLine();
    }
}