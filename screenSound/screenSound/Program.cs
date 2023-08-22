// Screen Sound
string mensagemBoasVindas = "Bem-Vindo ao Screen Sound por Gabriel Ponzoni!";
List<string> listaDeBandas = new List<string> {"U2","The Beatles","Calypso"};

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
        case 2: MostrarListaBandas();
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
    Console.WriteLine("******************");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("******************\n");
    Console.Write("Informe o nome de uma banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso! "); // Em python o $ é o equivalente a f-string; 
    Thread.Sleep(2000); // Função de pausar o tempo da thread no terminal;
    Console.Clear();
    ExibirOpcoesDoMenu();   
}

void MostrarListaBandas()
{
    Console.Clear();
    Console.WriteLine("******************************");
    Console.WriteLine("Bandas registradas no sistema:");
    Console.WriteLine("******************************\n");
    /*    for (int i = 0; i < listaDeBandas.Count; i++) // Count é como se fosse a função length do python;
        {
            Console.WriteLine($"{i+1}ª Banda: {listaDeBandas[i]}");
        } ou ~~      */
    int i = 1;
    foreach (string banda in listaDeBandas)
    {
        Console.WriteLine($"{i}ª Banda: {banda}");
        i++;
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu...");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();
