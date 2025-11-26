using System;
using System.ComponentModel;

class Conta3
{
    public Conta3(int agencia, int numconta, double saldo, Titular titular)
    {
        Agencia = agencia;
        NumConta = numconta;
        Saldo = saldo;
        Titular = titular;
    }

    public int Agencia {  get; set; }
    public int NumConta { get; set; }
    public double Saldo { get; set; }
    public int Limite { get; set; }
   
    public Titular Titular { get; set;}
    public void ExibirDados()
    {
       
        Console.WriteLine(Agencia);
        Console.WriteLine(NumConta);
        Console.WriteLine(Saldo);
        Console.WriteLine(Limite);

        Console.WriteLine(Titular.Nome);
        Console.WriteLine(Titular.Idade);
        Console.WriteLine(Titular.Cep);

    }
    void ReceberDados()
    {
        var titular = new Titular("Maria", 28, 12345678);
        var conta = new Conta3(123, 456, 500.50, titular);
        conta.Limite = 1000;

        conta.ExibirDados();


        conta.ExibirDados();
    }
}
class Titular
{
    public Titular(string nome, int idade, int cep)
    {
        Nome = nome;
        Idade = idade;
        Cep = cep;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }
    public int Cep { get; set; }

}


class Produtos
{
    public string Nome { get; set; }
    public int Estoque { get; set; }

    public void NovoProduto()
    {
        Produtos produto = new Produtos();
        Console.WriteLine("Qual o nome do produto?");
        produto.Nome = Console.ReadLine()!;
        Console.WriteLine("Quantas unidades do produto há em estoque?");
       if (!int.TryParse(Console.ReadLine(), out int estoque)) {
            Console.WriteLine("Valor invalido");
        }
       produto.Estoque = estoque;
    }
    public void ExibirProdutos(List<Produtos> produtos)
    {
        Console.WriteLine("Aqui estão todos os produtos:");
        foreach (var produto in produtos) {
            Console.Write($"Nome: {produto.Nome}");
            Console.Write($" Estoque: {produto.Estoque}");
        }
    }
}

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public int Notas { get; set; }
}
class Professor
{
    public string Nome { get; set; }
    public List<string> DissiplinasLecionadas { get; set; }

}
class Dissiplina
{
 
    public string Nome { get; set; }
    public List<string> Alunos { get; set; }

}
class ProdutoRestaurante
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

class Mesa
{
    public int Numero { get; set; }
    public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
}

class Pedido
{
    public ProdutoRestaurante Produto { get; set; }
    public int Quantidade { get; set; }
}

class Cardapio
{
    public List<ProdutoRestaurante> Itens { get; set; } = new List<ProdutoRestaurante>();
}

class Restaurante
{
    public List<Mesa> Mesas { get; set; } = new List<Mesa>();
    public Cardapio Cardapio { get; set; } = new Cardapio();
}




class Jogos
{
    public Jogos(string nome, int ano, string empresa)
    {
        Nome = nome;
        Ano = ano;
        Empresa = empresa;
    }

    public string Nome { get; set; }
    public string Empresa { get; set; }
    public int Ano { get; set; }


    public void CriarJogo()
    {
        
        Console.WriteLine("Qual o nome do seu jogo?");
        string nnome = Console.ReadLine()!;
        Console.WriteLine("Qual o ano do seu jogo?");
        if (!int.TryParse(Console.ReadLine(), out int nano))
        {
            Console.WriteLine("Valor invalido");
        }
        Console.WriteLine("Qual a empresa do seu jogo?");
        string nempresa = Console.ReadLine()!;
        Jogos jogo = new Jogos(nnome, nano, nempresa);

    }
    
}