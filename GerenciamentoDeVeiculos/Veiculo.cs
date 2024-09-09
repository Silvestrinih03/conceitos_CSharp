using ExerciciosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public abstract class Veiculo
    {
        /*1. Crie uma classe base Veiculo:
            Encapsule as propriedades Marca, Modelo e Ano.
            Defina um método Ligar() (Pode só imprimir "Vroom vroom" por hora)
            Defina um método abstrato EficiênciaCombustivel() que calcula a eficiência de combustível do veículo.*/

        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public string Ligar()
        {
            return "Vroom Vroom";
        }

        public abstract double EficienciaCombustivel(double km, double litro);


    }
}