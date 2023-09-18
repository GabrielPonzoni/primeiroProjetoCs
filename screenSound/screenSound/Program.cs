// Screen Sound
string mensagemBoasVindas = "Bem-Vindo ao Screen Sound por Gabriel Ponzoni!";
//List<string> listaDeBandas = new List<string> {"U2","The Beatles","Calypso"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());

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
        case 3: AvaliarUmaBanda();
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

    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Informe o nome de uma banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso! "); // Em python o $ é o equivalente a f-string; 
    Thread.Sleep(2000); // Função de pausar o tempo da thread no terminal;

    Console.Clear();
    ExibirOpcoesDoMenu();   
}

void MostrarListaBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Bandas registradas no sistema:");

    /*    for (int i = 0; i < listaDeBandas.Count; i++) // Count é como se fosse a função length do python;
        {
            Console.WriteLine($"{i+1}ª Banda: {listaDeBandas[i]}");
        } ou ~~      */

    int i = 1;

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"{i}ª Banda: {banda}");
        i++;
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu...");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length; // coleta as letras do vetor string inserido na função;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*'); // cria uma string com base no valor de letras substituindo por asteriscos

    // Cabecalho proprimente dito;
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    // se a banda existir no dicionário >> Atribuir uma nota
    // senão volta ao menu principal 

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar bandas");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!; // exclamação serve para n aceitar valor nulo na opção
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\nQual que é a nota que a banda {nomeDaBanda} merece? ");
        int nota = int.Parse(Console.ReadLine());
        bandasRegistradas[nomeDaBanda].Add(nota); // as chaves serve para acessar a segunda parte do dicionário "Tvalue"
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso na banda {nomeDaBanda}!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi registrada!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

ExibirOpcoesDoMenu();
