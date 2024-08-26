using System;
using System.Linq;
using System.Collections.Generic;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Teclado", Preco = 100.00 },
            new Produto { Nome = "Mouse", Preco = 50.00 },
            new Produto { Nome = "Monitor", Preco = 700.00 },
            new Produto { Nome = "Cabo HDMI", Preco = 30.00 }
        };

        // LINQ para selecionar produtos com preço acima de 50
        var produtosCaros = from produto in produtos
                            where produto.Preco > 50
                            select produto;

        Console.WriteLine("Produtos com preço acima de 50:");
        foreach (var produto in produtosCaros)
        {
            Console.WriteLine($"{produto.Nome}: R$ {produto.Preco}");
        }
    }
}
