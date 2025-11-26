class ContaBancaria
{
    public int ID;
    public string titular;
    public double saldo;
    public int senha;

    public ContaBancaria(int id, string titular, double saldo, int senha)
    {
        this.ID = id;
        this.titular = titular;
        this.saldo = saldo;
        this.senha = senha;
    }
    void ExibirInformacoes()
    {
        Console.WriteLine($"O id da primeira conta é: {ID}");
        Console.WriteLine($"O titular da primeira conta é: {titular}");
        Console.WriteLine($"O saldo da primeira conta é: {saldo}");
        Console.WriteLine($"A senha da primeira conta é: {senha}");
    }


}


class carro
{
    public int ID;
    public string nome;
    public int velocidade;
    public carro(int id, string nome, int velocidade)
    {
        this.ID = id;
        this.nome = nome;
        this.velocidade = velocidade;
    }

    carro carro1 = new carro(1111, "camaro", 100);

    void acelerar()
    {
        velocidade = velocidade + 5;
    }
    void frear()
    {
        velocidade = velocidade - 5;
    }
    void buzinar()
    {
       Console.WriteLine("fon-fon");
    }
}

/* class exemplo
{
    void e()
    {
        ContaBancaria conta1 = new ContaBancaria(1111, "Matheus", 5000, 1027);

        Console.WriteLine($"O id da primeira conta é: {conta1.ID}");
        Console.WriteLine($"O titular da primeira conta é: {conta1.titular}");
        Console.WriteLine($"O saldo da primeira conta é: {conta1.saldo}");
        Console.WriteLine($"A senha da primeira conta é: {conta1.senha}");
    }
}
*/






