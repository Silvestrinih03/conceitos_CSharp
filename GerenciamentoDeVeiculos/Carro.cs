using ExerciciosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Carro : Veiculo, IManutencao
    {

        /*2. Crie uma classes derivada Carro: Implemente o método EficiênciaCombustivel() e adicione o atributo NumeroDePortas*/

        public int NumeroDePortas {  get; set; }

        public override double EficienciaCombustivel(double km, double litro)
        {
            // Eficiencia carro = distanciaPercorrida/combustivelConsumido * (1 + PesoAdicional/1000) >> 400/40x(1+200/1000)
            //var pesoadicional = 200;

            return km/(litro * (1 + 200/1000));
        }

        public string RealizarManutencao()
        {
            return "Manutenção no carro realizada com sucesso!";
        }
    }
}
