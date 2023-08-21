// Screen Sound
string mensagemBoasVindas = "Bem-Vindo ao Screen Sound por Gabriel Ponzoni!";
/*Console.WriteLine(mensagemBoasVindas); //Q1: Ñ se usa print? Porque WriteLine(python se usa esse comando em leitura de arquivo?*/

void ExibirLogo()
{
    // Cabecalho do código;
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
"); // Usei o @ q é o "verbatin literal";
    Console.WriteLine(mensagemBoasVindas);

}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();

    Console.WriteLine("\nDigite 1 para registrar uma banda;");
    Console.WriteLine("Digite 2 para mostrar todas as bandas;");
    Console.WriteLine("Digite 3 para avaliar uma banda;");
    Console.WriteLine("Digite 4 para a média de uma banda;");
    Console.WriteLine("Digite -1 para sair;");

    Console.Write("\nDigite sua opção: "); // Depois de escrever o argumento da função ele ñ vai pular a linha;
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaInt) 
    {
        case 1: RegistrarBandas();
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt);
            break;
        case -1: Console.WriteLine("Tchau tchau :) ");
            break;
        default: Console.WriteLine("Informação inválida!");
            break;
    }

}

void RegistrarBandas()
{
    Console.Clear(); // Limpa tela
    Console.WriteLine("Registro de Bandas");
    Console.Write("Informe o nome de uma banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso! ");
    Thread.Sleep(2000); // Função de pausar o tempo da thread no terminal
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();
