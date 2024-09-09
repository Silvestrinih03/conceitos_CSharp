using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using ExerciciosPOO;


/*
    4. Crie um programa principal:
    Instancie um Carro e uma Moto.
    Chame os métodos Ligar(), EficiênciaCombustivel() e RealizarManutencao() para cada veículo.
 */

public class Program
{
    public static void Main(string[] args)
    {
        Carro carro = new Carro { 
            Marca = "Toyota",
            Modelo = "Etios",
            Ano = 2019,
            NumeroDePortas = 4
        };

        Moto moto = new Moto { 
            Marca = "Honda",
            Modelo = "CB 500F",
            Ano = 2023,
            cilindradas = 471
        };

        Console.WriteLine("Ligando carro: "+carro.Ligar());
        Console.WriteLine("Ligando moto: "+moto.Ligar());


        var kmcarro = 400;
        var lcarro = 40;
        var eficienciacarro = carro.EficienciaCombustivel(kmcarro, lcarro);

        var kmmoto = 300;
        var lmoto = 12;
        var eficienciamoto = moto.EficienciaCombustivel(kmmoto, lmoto);

        Console.WriteLine($"A eficiência de combustível do carro é: {eficienciacarro}");
        Console.WriteLine($"A eficiência de combustível do moto é: {eficienciamoto}");


        Console.WriteLine("Realizando manutenção no carro...\n"+carro.RealizarManutencao());

        Console.WriteLine("Realizando manutenção na moto...\n" + moto.RealizarManutencao());

    }
}