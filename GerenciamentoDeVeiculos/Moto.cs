using ExerciciosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Moto : Veiculo, IManutencao
    {
        /*2. Crie a classe derivada Moto: Implemente o método EficiênciaCombustivel() e adicione o atributo Cilindradas*/

        public int cilindradas { get; set; }

        public override double EficienciaCombustivel(double km, double litro)
        {

            // Eficiencia moto = distanciaPercorrida/combustivelConsumido * (1 - Cilidradas/2000) >> 300/ 12x(1+471/2000)

            return km / (litro * (1 - cilindradas / 2000));
        }

        public string RealizarManutencao()
        {
            return "Manutenção na moto realizada com sucesso!";
        }
    }
}
