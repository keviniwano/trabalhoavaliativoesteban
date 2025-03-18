using System;

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[10];

          
        for (int i = 0; i < 10; i++)
        {
            produtos[i] = new Produto();
            Console.Write($"Digite o nome do produto {i + 1}: ");
            produtos[i].Nome = Console.ReadLine();
            Console.Write($"Digite o preço do produto {i + 1}: ");
            produtos[i].Preco = decimal.Parse(Console.ReadLine());
        }

        
        Console.Write("Digite um valor para pesquisar os produtos: ");
        decimal valor = decimal.Parse(Console.ReadLine());

        
        Console.WriteLine("Produtos com preço até o valor digitado:");
        foreach (var produto in produtos)
        {
            if (produto.Preco <= valor)
            {
                Console.WriteLine($"- {produto.Nome}: R${produto.Preco}");
            }
        }
    }
}