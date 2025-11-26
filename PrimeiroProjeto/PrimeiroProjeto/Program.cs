
using System;
using System.Threading.Tasks;
// par e impar do faça como eu
List<int> Par_Impar = new List<int>();
// dicionario do screen sound
Dictionary<string, List<double>> bandaRegistradas = new Dictionary<string, List<double>>();
bandaRegistradas.Add("Linkin Park", new List<double> { 10, 8, 6 });
bandaRegistradas.Add("The Beatles", new List<double>());
// dicionario e variavel da parte 1 do desafio 4
Dictionary<string, List<double>> alunos = new Dictionary<string, List<double>>();
string nomeAluno = "";
// dicionario e variavel da parte 2 do desafio 4
Dictionary<string, List<int>> produtos = new Dictionary<string, List<int>>();
string nomeProduto = "";
// // dicionario e variavel da parte 3 do desafio 4
Dictionary<string, string> perguntas = new Dictionary<string, string>();
string npergunta = "";
string Resposta = "";
// // dicionario e variavel da parte 3 do desafio 4
Dictionary<string, string> usuarios = new Dictionary<string, string>();
string usuario = "";
string senha = "";



await ExibirOpçõesDeApp();


// Screen Sound
//Exibir mensagem de boas vindas - Screen Sound

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeletras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeletras,'*') ;
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}
void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

    ");
    string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
    Console.WriteLine(mensagemDeBoasVindas);
}
async Task Screen_Sound()
{
    ExibirLogo();
    await ExibirOpçõesDoMenuSS();
}
// Registrar bandas screen sound
async Task RegistrarBanda()
{

    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso ");
    bandaRegistradas.Add(nomeDaBanda, new List<double>());
    Console.WriteLine("clique qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    await ExibirOpçõesDoMenuSS();
}
//Registrar Bandas screen sound
async Task MostrarBandasRegistradas()
{
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    var keys = bandaRegistradas.Keys.ToList();
      for (int i = 0; i < keys.Count; i++)
      {
          Console.WriteLine($"Banda: {keys[i]}");
      }
    

   /* foreach (string banda in bandaRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda} ");
    }
   */

    Console.WriteLine("clique qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    await ExibirOpçõesDoMenuSS();

}
//Avalia banda screen sound

async Task avaliarUmaBanda()
{
    ExibirTituloDaOpcao("Avaliar Bandas");
    Console.Write("\nQual banda deseja avaliar?");
    string nomeDaBanda = Console.ReadLine()!;
    if (string.IsNullOrWhiteSpace(nomeDaBanda))
    {
        Console.WriteLine("Digite algum nome!");
        Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        await ExibirOpçõesDoMenuSS();
    }
    else if (bandaRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual a nota que a banda {nomeDaBanda} merece: ");
        if (!int.TryParse(Console.ReadLine(), out int nota))
        {
            Console.WriteLine("Valor inválido!");
            Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            await ExibirOpçõesDoMenuSS();
        }
        bandaRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        
        await Task.Delay(3000);
        Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        await ExibirOpçõesDoMenuSS();
    }
    else {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("clique qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        await ExibirOpçõesDoMenuSS();
    }
}
//Exibir media de banda screen sound
async Task mediaBanda()
{
    ExibirTituloDaOpcao("Exibindo media de uma banda");
    Console.WriteLine("Deseja ver a media de notas de qual banda?");
    string Banda = Console.ReadLine()!;
    if (string.IsNullOrWhiteSpace(Banda))
    {
        Console.WriteLine("Digite algum nome!");
        Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        await ExibirOpçõesDoMenuSS();
    }
    else if (bandaRegistradas.ContainsKey(Banda))
    {
        double somanotas = bandaRegistradas[Banda].Sum();
        double numnotas = bandaRegistradas[Banda].Count;
        double media = somanotas / numnotas;
        Console.WriteLine($"A media da banda {Banda} é {media}");
    }
    else
    {
        Console.WriteLine("Não encontramos essa banda.");
    }

}

//Menu do Screen Sound
async Task ExibirOpçõesDoMenuSS()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para sair");
    Console.Write("\n Digite a sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            Console.Clear();
            await RegistrarBanda(); 
            break;
        case 2:
            Console.Clear();
            await MostrarBandasRegistradas();
            break;
        case 3:
            Console.Clear();
            await avaliarUmaBanda();
            break;
        case 4:
            Console.Clear();
            await mediaBanda();
            break;
        case 5:
            Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
            Console.WriteLine("Tchau Tchau *");
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;

    }
    Console.WriteLine("clique qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();


}

// Desafio: Hora da pratica
async Task Desafio()
{
    string curso = "curso de csharp";
    Console.WriteLine(curso);
    string nome = "Henrique";
    string sobrenome = " Ignacio ferreira Souza";
    Console.WriteLine(nome + sobrenome);

    Console.WriteLine("clique qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    await ExibirOpçõesDeApp();

}

// Desafio: Hora da pratica 2
async Task Desafio2()
{
    Console.WriteLine("\nParte 1:");
    Console.Write("Digite sua nota média: ");
    if (!int.TryParse(Console.ReadLine(), out int notaMedia))
    {
        Console.WriteLine("Valor inválido, digite um número.");
        return;
    }
    if (notaMedia >= 5)
    {
        Console.WriteLine("Nota suficiente para aprovação");
    }
    else
    {
        Console.WriteLine("Nota insuficiente para aprovação");
    }

    Console.WriteLine("\n \n Parte 2:");
    List<string> list = new List<string>() { "c#", "Java", "JavaScript" };
    Console.WriteLine(list[0]);
    Console.WriteLine("\n \n Parte 3:");
    List<string> list2 = new List<string>() { "c#", "Java", "JavaScript", "c++", "typescript" };
    Console.WriteLine("Qual termo da lista você quer? - Opções de 0 a 4");
    if (!int.TryParse(Console.ReadLine(), out int escolha) || escolha < 0 || escolha > 4)
    {
        Console.WriteLine("Valor invalido, digite um valor valido");
    }
    else
    {
        Console.WriteLine(list2[escolha]);
    }
    Console.WriteLine("clique qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    await ExibirOpçõesDeApp();

}

//Desafio: Hora da pratica 3
async Task Desafio3()
{

    //Parte 1

    Console.WriteLine("Digite o primeiro número");
    if (!int.TryParse(Console.ReadLine(), out int num1))
    {
        Console.WriteLine("Número nulo, insira algum valor");
    }
    Console.WriteLine("Digite o segundo número");
    if (!int.TryParse(Console.ReadLine(), out int num2))
    {
        Console.WriteLine("Número nulo, insira algum valor");
    }

    Console.WriteLine($"A soma de {num1} com {num2} é:" + (num1 + num2));
    Console.WriteLine($"A subtração de {num1} com {num2} é:" + (num1 - num2));
    Console.WriteLine($"A multiplicação de {num1} com {num2} é:" + (num1 * num2));
    if (num2 == 0)
    {
        Console.WriteLine("Não se pode dividir por 0, digite outro valor se quiser uma divisão");
        await Task.Delay(2000);
        return;
    }
    else
    {
        Console.WriteLine($"A divisão de {num1} com {num2} é:" + (num1 / num2));
    }

    // Parte 2

    List<string> minhasBandas = new List<string>();
    minhasBandas.AddRange("\n\nradiohead", "linkin Park", "Gorillaz", "Bee Gees", "Queen", "Arctic Monkeys");
    for (int i = 0; i < minhasBandas.Count; i++)
    {
        Console.WriteLine(minhasBandas[i]);
    }

    // Parte 3


    List<int> listaInteiros = new List<int>() { 1, 2, 3, 4, 55, 2, 5555, 234 };
    Console.WriteLine("\n" + listaInteiros.Sum());













    Console.WriteLine("clique qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    await ExibirOpçõesDeApp();
}

// Desafio: hora da pratica 4
async Task Desafio4()
{
    Console.WriteLine("\nParte 1");
    Console.WriteLine("Parte 2");
    Console.WriteLine("Parte 3");
    Console.WriteLine("Parte 4");
    Console.WriteLine("Digite 6 para sair");
    Console.Write("\n Digite a sua opção:");
    string opcao = Console.ReadLine()!;
    int opcaoN = int.Parse(opcao);
    switch (opcaoN)
    {
        case 1:

           await desafio4_parte1();

            break;
        case 2:
           await desafio4_parte2();

            break;
        case 3:
          await  desafio4_parte3();


            break;
        case 4:
           await desafio4_parte4();


            break;

        default:
            await Desafio4();
            break;
    }


}
// Parte 1:
async Task desafio4_parte1() {
    Console.WriteLine("\nDigite 1 para registrar um aluno");
    Console.WriteLine("Digite 2 para mostrar todas os alunos");
    Console.WriteLine("Digite 3 para dar nota a um aluno");
    Console.WriteLine("Digite 4 para exibir a média de um aluno");
    Console.WriteLine("Digite 5 para limpar o dicionario de alunos");
    Console.WriteLine("Digite 6 para sair");
    Console.Write("\n Digite a sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:

            Console.Write("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(nomeAluno))
            {
                Console.WriteLine("Digite algum nome!");
                Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                await Desafio4();
            }
            alunos.Add(nomeAluno, new List<double>());
            Console.WriteLine("Aluno registrado com sucesso");
            break;
        case 2:
            Console.WriteLine("Essa é a lista dos alunos:");

            foreach (string nomeAluno in alunos.Keys)
            {
                Console.WriteLine(nomeAluno);
            }

            break;
        case 3:
            Console.WriteLine("Deseja dar nota a qual aluno?");
            string Aluno = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(Aluno))
            {
                Console.WriteLine("Digite algum nome!");
                Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                await Desafio4();
            }
            else if (alunos.ContainsKey(nomeAluno))
            {
                Console.Write($"Digite uma nota do aluno {nomeAluno}: ");
                if (!int.TryParse(Console.ReadLine(), out int nota))
                {
                    Console.WriteLine("Número nulo, insira algum valor");
                }
                alunos[nomeAluno].Add(nota);
                Console.WriteLine($"Nota do aluno {nomeAluno} foi registrada com sucesso");

            }
            else
            {
                Console.WriteLine("Não encontramos esse aluno.");
            }
            break;
        case 4:

            Console.WriteLine("Deseja ver a media de notas de qual aluno?");
            Aluno = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(Aluno))
            {
                Console.WriteLine("Digite algum nome!");
                Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                await Desafio4();
            }
            else if (Aluno == nomeAluno)
            {
                double somaNotas = alunos[nomeAluno].Sum();
                double numNotas = alunos[nomeAluno].Count;
                double media = somaNotas / numNotas;
                Console.WriteLine($"A media do aluno {nomeAluno} é {media}");
            }
            else
            {
                Console.WriteLine("Não encontramos esse aluno.");
            }


            break;

        case 5:
            alunos.Clear();
            break;

        case 6:
            Console.WriteLine("Você escolheu a opção sair");
            Console.WriteLine("Tchau Tchau");
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;

    }
}
async Task desafio4_parte2()
{


    Console.WriteLine("\nDigite 1 para registrar um produto");
    Console.WriteLine("Digite 2 para alterar o esotque de um produto");
    Console.WriteLine("Digite 3 para mostrar todos os produtos");
    Console.WriteLine("Digite 4 para limpar o dicionario de produtos");
    Console.WriteLine("Digite 5 para sair");
    Console.Write("\n Digite a sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:

            Console.Write("Digite o nome do produto: ");
            nomeProduto = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(nomeProduto))
            {
                Console.WriteLine("Digite algum nome!");
                Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                await Desafio4();
            }
            produtos.Add(nomeProduto, new List<int>());
            Console.WriteLine("produto registrado com sucesso");
        
        break;
        case 2:
            Console.WriteLine("Deseja indicar o estoque de qual produto?");
            string Produto = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(Produto))
            {
                Console.WriteLine("Digite algum produto!");
                Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                await Desafio4();
            }
            else if (produtos.ContainsKey(Produto))
            {
                Console.Write($"Digite qual o estoque do produto {Produto}: ");
                if (!int.TryParse(Console.ReadLine(), out int estoque) || estoque <= 0)
                {
                    Console.WriteLine("Número nulo, menor ou igual a 0. Digite um valor valido! ");
                }
                alunos[Produto].Add(estoque);
                Console.WriteLine($"estoque do produto {Produto} foi registrada com sucesso");

            }
            else
            {
                Console.WriteLine("Não encontramos esse produto.");
            }
            break;
        case 3:
            Console.WriteLine("Essa é a lista dos produtos:");

            foreach (string nomeProduto in produtos.Keys)
            {
                Console.WriteLine($"Nome: {nomeProduto}  estoque: {string.Join(", ", produtos[nomeProduto])}");

            }

            break;
        
        case 4:

            produtos.Clear();
            break;
        case 5:
            Console.WriteLine("Você escolheu a opção sair");
            Console.WriteLine("Tchau Tchau");
            break;
   
            
        default:
            Console.WriteLine("Opção invalida");
            break;

    }



}
async Task desafio4_parte3()
{
    Console.WriteLine("\nDigite 1 para registrar uma pergunta");
    Console.WriteLine("Digite 2 para mostrar todas as perguntas");
    Console.WriteLine("Digite 3 para responder a uma pergunta");
    Console.WriteLine("Digite 5 para limpar o dicionario de perguntas");
    Console.WriteLine("Digite 6 para sair");
    Console.Write("\n Digite a sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:

            Console.Write("Digite a pergunta: ");
            npergunta = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(npergunta))
            {
                Console.WriteLine("Digite alguma pergunta!");
                Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                await Desafio4();
            }
            perguntas.Add(npergunta, "");
            Console.WriteLine("Pergunta registrado com sucesso");
            break;
        case 2:
            Console.WriteLine("Essa é a lista das perguntas:");

            foreach (string pergunta in perguntas.Keys)
            {
                Console.WriteLine(pergunta);
            }

            break;
        case 3:
            Console.WriteLine("Deseja responder a qual pergunta?");
            string Pergunta = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(Pergunta))
            {
                Console.WriteLine("Digite algum pergunta!");
                Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                await Desafio4();
            }
            else if (perguntas.ContainsKey(Pergunta))
            {
                Console.Write($"Digite a resposta da pergunta:  {npergunta}: ");
                Resposta = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(Resposta))
                {
                    Console.WriteLine("Digite alguma Resposta!");
                    Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                    await Desafio4();
                }
                perguntas[Pergunta] = Resposta;
                Console.WriteLine($"Resposta da pergunta {Pergunta} foi registrada com sucesso");

            }
            else
            {
                Console.WriteLine("Não encontramos esse pergunta.");
            }
            break;
        case 4:

            Console.WriteLine("Deseja responder qual pergunta?");
            Pergunta = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(Pergunta))
            {
                Console.WriteLine("Digite alguma resposta!");
                Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                await Desafio4();
            }
            else if (Pergunta == npergunta)
            {
                Console.WriteLine($"Qual a resposta da pergunta {npergunta}");
                string tentativa = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(tentativa))
                {
                    Console.WriteLine("Digite alguma resposta!");
                    Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                    await Desafio4();
                }
                else if (tentativa == Resposta)
                {
                    Console.WriteLine($"A resposta resposta está coreta!");
                }
                else
                {
                    Console.WriteLine($"A resposta resposta está incoreta!");
                }
            }
            else
            {
                Console.WriteLine("Não encontramos esse pergunta.");
            }


            break;

        case 5:
            perguntas.Clear();
            break;

        case 6:
            Console.WriteLine("Você escolheu a opção sair");
            Console.WriteLine("Tchau Tchau");
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;

    }
}
async Task desafio4_parte4()
{
    Console.WriteLine("\nDigite 1 para registrar um usuario");
    Console.WriteLine("Digite 2 para mostrar todos os usuario");
    Console.WriteLine("Digite 3 para logar em um usuario");
    Console.WriteLine("Digite 4 para limpar o dicionario de usuario");
    Console.WriteLine("Digite 5 para sair");
    Console.Write("\n Digite a sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:

            Console.Write("Digite o usuario: ");
            string newusuario = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(newusuario))
            {
                Console.WriteLine("Digite algum usuario!");
                Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                await Desafio4();
            }
            Console.Write("Digite a senha: ");
            string newsenha = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(newsenha))
            {
                Console.WriteLine("Digite alguma senha!");
                Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                await Desafio4();
            }

            usuarios.Add(newusuario, newsenha);
            Console.WriteLine("Usuario registrado com sucesso");
            break;
            case 2:
            Console.WriteLine("Essa é a lista dos usuarios:");

            foreach (string usuario in usuarios.Keys)
            {
                Console.WriteLine(usuario);
            }

            break; 


        case 3:
            Console.WriteLine("Deseja logar em qual usuario?");
            string Usuario = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(Usuario))
            {
                Console.WriteLine("Digite alguma resposta!");
                Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                await Desafio4();
            } else if (usuarios.ContainsKey(usuario))
            {
                Console.Write("Digite a senha: ");
                newsenha = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(newsenha))
                {
                    Console.WriteLine("Digite alguma senha!");
                    Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                    await Desafio4();
                }
                if (senha == newsenha)
                {


                    Console.WriteLine($"A resposta resposta está coreta!");
                    Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                    await Desafio4();
                }
                else
                {
                    Console.WriteLine($"A resposta resposta está incoreta!");
                    Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                    await Desafio4();
                }
            } else
            {
                Console.WriteLine("Não encontramos esse usuario");
            }
             break;
           case 4:
            usuarios.Clear();
            break;

        case 5:
            Console.WriteLine("Você escolheu a opção sair");
            Console.WriteLine("Tchau Tchau");
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }

}


// "Faça como eu fiz: primeiro jogo com c#" - Jogo
async Task jogo()
{
    Random rnd = new();
    int randomNumber = rnd.Next(0, 100);
    Console.WriteLine("Temos um número aleatorio de 1 a 100, tente adivinhar qual é!");
    if (!int.TryParse(Console.ReadLine(), out int palpite) || palpite < 0 || palpite > 100)
    {
        Console.WriteLine("Valor invalido, digite um valor valido");
    }
    do
    {
        Console.WriteLine("Você errou!");
        if (palpite > randomNumber)
        {
            Console.WriteLine("Seu palpite é maior que o número");
        }
        else
        {
            Console.WriteLine("Seu palpite é menor que o número");
        }
        Console.WriteLine("De um novo palpite:");
        palpite = Convert.ToInt32(Console.ReadLine());

    } while (palpite != randomNumber);
    Console.WriteLine("Você acertou!");
    Console.WriteLine("O jogo acabou");



    Console.WriteLine("clique qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    await ExibirOpçõesDeApp();

}
// "Faça como eu fiz:" - for e foreach
async Task for_foreach()
{
    Console.WriteLine("digite o novo número(a soma de todos os números será o número de vez que a impreção irá se repetir): ");
    if (!int.TryParse(Console.ReadLine(), out int num) || num < 0)
    {
        Console.WriteLine("Digite um valor valido");
        return;
    }
    Par_Impar.Add(num);
    Console.WriteLine("Deseja digitar um novo número ou exibir a lista?\n1 - Novo Número // 2 - Exibir Lista");
    if (!int.TryParse(Console.ReadLine(), out int escolha) || (escolha != 1 && escolha != 2))
    {
        Console.WriteLine("Digite um valor válido");
        return;
    }
    if (escolha == 1)
    {
        await for_foreach();
        return;
    }
    else if (escolha == 2)
    {
        Console.WriteLine("Deseja usar for ou foreach? 1 - for 2 - foreach");
        if (!int.TryParse(Console.ReadLine(), out int For_Foreach) || (For_Foreach != 1 && For_Foreach != 2))
        {
            Console.WriteLine("Digite um valor valido");
            return;

        }
        Console.WriteLine("tem certeza que quer iniciar a lista(Ela só irá parar quando acabar os números)? 1 - Sim 2 - Não");
        if (!int.TryParse(Console.ReadLine(), out int certeza) || (certeza != 1 && certeza != 2))
        {
            Console.WriteLine("Digite um valor valido");
            return;

        }
        else if (certeza == 1)
        {
            if (For_Foreach == 1)
            {
                Console.WriteLine("Os numeros pares são:");
                for (int i = 0; i < Par_Impar.Count; i++)
                {
                    
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Par_Impar.Clear();
                return;
            }
            else if (For_Foreach == 2)
            {
                var numeros = Enumerable.Range(1, Par_Impar.Count).ToList();
                Console.WriteLine("Os numeros pares são:");

                foreach (var i in numeros)
                    {
                    if (i % 2 == 0)
                    {

                        Console.WriteLine(i);
                    }
                    Par_Impar.Clear();


                }
                ;
                return;
            }

        }
        else { return; }


    }


    Console.WriteLine("clique qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    await ExibirOpçõesDeApp();
}

// "Faça como eu fiz:" - media de lista
async Task mediaDeLista()
{
    Dictionary<string, List<int>> carros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};
    string nomeCarro = "";
    Console.WriteLine("\nDigite 1 para mostrar todos os carros");
    Console.WriteLine("Digite 2 para ver a media de vendas de um carro");
    Console.WriteLine("Digite 3 para sair");
    Console.Write("\n Digite a sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            Console.WriteLine("Essa é a lista dos carros:");

            foreach (string carro in carros.Keys)
            {
                Console.WriteLine(carro);
            }
            break;
        case 2:
            Console.WriteLine("Deseja ver a media de vendas de qual carro?");
            string Carro = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(Carro))
            {
                Console.WriteLine("Digite algum nome!");
                Console.WriteLine("\nclique qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                await Desafio4();
            }
            else if (carros.ContainsKey(Carro))
            {
                double somavendas = carros[nomeCarro].Sum();
                double numvendas = alunos[nomeCarro].Count;
                double media = somavendas / numvendas;
                Console.WriteLine($"A media do aluno {nomeCarro} é {media}");
            }
            else
            {
                Console.WriteLine("Não encontramos esse carro.");
            }


            break;
        case 3:
            Console.WriteLine("Você escolheu a opção sair");
            Console.WriteLine("Tchau Tchau");
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}


async Task ExibirOpçõesDeApp()
{
    int escolha = 100;
    while (escolha != 0)
    {
        Console.WriteLine("\nVocê que executar qual função?");
        Console.WriteLine("1 - Screen Sound");
        Console.WriteLine("2 - Desafio Hora da pratica");
        Console.WriteLine("3 - Desafio Hora da pratica 2");
        Console.WriteLine("4 - Desafio Hora da pratica 3");
        Console.WriteLine("5 - Desafio Hora da pratica 4");
        Console.WriteLine("6 - Faça como eu fiz: Jogo");
        Console.WriteLine("7 - Faça como eu fiz: for e foreach");
        Console.WriteLine("8 - Faça como eu fiz: Media de lista");
        Console.WriteLine("0 - Sair");


        escolha = Convert.ToInt32(Console.ReadLine() ?? "0");
        switch (escolha)
        {
            case 0:
                Console.WriteLine("Tchau Tchau :) \nO programa se encerrará em 3 segundos ");
                await Task.Delay(3000);
                break;
            case 1:
                Console.Clear();
                await Screen_Sound();
                break;
            case 2:
                Console.Clear();
                await Desafio();
                break;
            case 3:
                Console.Clear();
                await Desafio2();
                break;
            case 4:
                Console.Clear();
                await Desafio3();
                break;
            case 5:
                Console.Clear();
                await Desafio4();
                break;
            case 6:
                Console.Clear();
                await jogo();
                break;
            case 7:
                Console.Clear();
                await for_foreach();
                break;
            case 8:
                Console.Clear();
                await mediaDeLista();
                break;



            default:
                Console.WriteLine("Não temos essa opção");
                break;

        }

    }
    
}

