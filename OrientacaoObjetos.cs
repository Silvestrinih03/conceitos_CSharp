/*
1) Classes e Objetos:
    Crie uma classe Carro com atributos: marca, modelo, ano. Implemente um método que exiba essas informações.
    Crie objetos dessa classe e chame o método para exibir as informações dos carros criados.

2) Encapsulamento:
    Crie uma classe ContaBancaria com atributos saldo e titular. O saldo deve ser acessado apenas por métodos. Implemente métodos para depositar e sacar, garantindo que não seja 
    possível sacar mais do que o saldo disponível.

3) Herança:
    Crie uma classe Animal com o método fazerSom(). Depois, crie classes derivadas Cachorro e Gato, cada uma implementando o método fazerSom() de uma forma específica.

4) Polimorfismo:
    Usando as classes do exercício anterior, crie uma função que recebe um objeto da classe Animal e chama o método fazerSom(). Teste essa função com objetos de Cachorro e Gato.

5) Composição:
    Crie uma classe Endereco com atributos como rua, cidade e estado. Agora, crie uma classe Pessoa que tenha um atributo endereco, representando a composição entre as duas classes. Implemente um método em Pessoa para exibir as informações do endereço.

6) Classes Abstratas:
    Crie uma classe abstrata Funcionario com atributos nome e salario. Depois, crie duas classes derivadas Gerente e Desenvolvedor, cada uma com um método calcularBonus() que retorna um valor diferente para cada tipo de funcionário.

7) Interfaces:
    Crie uma interface Autenticavel com um método autenticar(). Depois, crie uma classe Usuario que implementa essa interface, definindo como será o processo de autenticação (por exemplo, verificar uma senha).
*/


// Exercício 01
using System;
using System.Security.Cryptography;
using ExerciciosPOO;

namespace ExerciciosPOO
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public short Ano { get; set; }
    }

    public class ListarCarros
    {
        public List<Carro> GetCarros(List<Carro> Objcarro)
        {
            var carros = new List<Carro>();
            foreach (Carro obj in Objcarro) { carros.Add(obj); }

            foreach (var carro in carros)
            {
                Console.WriteLine(carro.Marca);
                Console.WriteLine(carro.Modelo);
                Console.WriteLine(carro.Ano);
            }

            return carros;
        }
    }

    public class PopulaCarros
    {
        // new está construindo um objeto (mesmo que vazio)
        public List<Carro> ObjCarro = new List<Carro>
        {
            new Carro
            {
                Marca = "Toyota",
                Modelo = "Etios",
                Ano = 2019
            },
            new Carro
            {
                Marca = "Toyota",
                Modelo = "Yaris",
                Ano = 2024
            }
        };
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var mainClass = new PopulaCarros();
            var metodo = new ListarCarros();

            metodo.GetCarros(mainClass.ObjCarro);
            Console.ReadLine();
        }
    }
}


// Exercício 02
using System;
using System.Security.Cryptography;
using ExerciciosPOO;


public class Cliente
{
    public long Id { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }

    public Cliente()
    {

    }
}

public class GeraClientes
{
    public static List<Cliente> ReturnClientes()
    {
        List<Cliente> ListaClientes = new List<Cliente>
        {
            new Cliente()
            {
                Id = 1,
                Titular = "João Pedro",
                Saldo = 1800.00
            },
            new Cliente()
            {
                Id = 2,
                Titular = "Nicole",
                Saldo = 300000.00
            }
        };

        return ListaClientes;
    }
}

public class ContaBancaria
{
    private double Saldo { get; set; }

    public ContaBancaria(double saldo)
    {
        Saldo = saldo;
    }

    public double Depositar(double valor)
    {
        return Saldo += valor;
    }

    public string Sacar(double valor)
    {
        if (Saldo < valor) 
        {
            return "Você não tem saldo suficiente.";
        }
        else
        {
            Saldo -= valor;
            return "Seu saldo é de " + Saldo + "R$"; 
        }
    }

    public double ConsultaSaldo()
    {
        return Saldo;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var valor = 100;
        var id = 1;

        var clientes = GeraClientes.ReturnClientes();

        var cliente = clientes.FirstOrDefault(x => x.Id == id);

        if (cliente != null)
        {
            var Conta = new ContaBancaria(cliente.Saldo);

            var postDeposito = Conta.Depositar(valor);

            Console.WriteLine("Deposito: " + postDeposito.ToString());

            var postSaldo = Conta.Sacar(valor*10);

            Console.WriteLine(postSaldo);

            // Sacar mais que o possível
            postSaldo = Conta.Sacar(1000);

            Console.WriteLine(postSaldo);
        }

        Console.ReadLine();
    }
}


// Exercício 03
using System;
using System.Security.Cryptography;
using ExerciciosPOO;

public class Animal
{
    public string RetornarSom(String Som)
    {
        return Som;
    }
}

public class Cachorro : Animal
{
    public String Som = new String("Auau");

}

public class Gato : Animal
{
    public String Som = new String("Miaaal");
}

public class Program
{
    public static void Main(string[] args)
    {
        var cachorro = new Cachorro();

        var gato = new Gato();

        var somcachorro = cachorro.RetornarSom(cachorro.Som);
        Console.WriteLine("Som do cachorro: "+ somcachorro);

        var somgato = gato.RetornarSom(gato.Som);
        Console.WriteLine("Som do gato: " + somgato);
    
        Console.ReadLine();
    }
}

// Exercício 04
using System;
using System.Security.Cryptography;
using ExerciciosPOO;

public class Animal
{
    public virtual String RetornarSom()
    {
        return "Som genérico de animal";
    }
}

public class Cachorro : Animal
{
    public String Som = new String("Auau");

    public override String RetornarSom() 
    {
        return Som; 
    }

}

public class Gato : Animal
{
    public String Som = new String("Miaaal");

    public override String RetornarSom()
    {
        return Som;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var cachorro = new Cachorro();

        var gato = new Gato();

        var somcachorro = cachorro.RetornarSom();
        Console.WriteLine("Som do cachorro: "+ somcachorro);

        var somgato = gato.RetornarSom();
        Console.WriteLine("Som do gato: " + somgato);
    
        Console.ReadLine();
    }
}

// Exercício 05
using System;
using System.Security.Cryptography;
using ExerciciosPOO;

public class Endereco
{
    public String Rua { get; set; }
    public String Cidade { get; set; }
    public String Estado { get; set; }

    public Endereco(String rua, String cidade, String estado) 
    {
        Rua = rua;
        Cidade = cidade;
        Estado = estado;
    }
}

public class Pessoa
{
    public string Nome { get; set; }
    public Endereco Endereco { get; set; }

    public Pessoa (string nome, Endereco endereco) {
        Nome = nome;
        Endereco = endereco;
    }

    public void ExibirPessoa()
    {
        Console.WriteLine("Info Pessoa:" + Nome + "\n" + Endereco.Rua + " " + Endereco.Cidade + " " + Endereco.Estado);
    }
}

public class Program()
{
    public static void Main(string[] args)
    {
        var nome = "Nicole";
        var endereco = new Endereco("Rua socorro", "Campinas", "SP");

        Pessoa pessoa = new Pessoa(nome, endereco);

        pessoa.ExibirPessoa();

        Console.ReadLine();
    }
}