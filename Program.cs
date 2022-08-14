using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!\n");

Console.WriteLine(@"Escolha uma opção: 
1 - Criar Conta.
2 - Ver Conta.
");

var opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Console.WriteLine("Digite seu nome: \n");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite seu CPF: \n");
        var cpf = Console.ReadLine();
        Console.WriteLine("Digite sua profissão: \n");
        var profissao = Console.ReadLine();

        Console.WriteLine(@"Escolha uma agência: 
        1 - Agência Central.
        2 - Segunda Agência.
        ");
        var agencia = Console.ReadLine();
        
        Random rd = new Random();
        var first = rd.Next(00000, 99999);
        var second = rd.Next(0, 9);

        var conta = $"{first}-{second}";
        int numero_agencia = second;

        CriarConta(agencia, conta, numero_agencia);

        Console.WriteLine($@"Sua conta foi criada com sucesso!
        Aqui estão suas informações;
        Cliente {nome}
        CPF {cpf}
        Agência {agencia}
        Conta {conta}
        Número da Agência {numero_agencia}
        Obrigado por fazer parte do nosso banco!
        ");

        break;
    case "2":
        Console.WriteLine("Ver Conta");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}

void CriarConta(string agencia, string conta, int numero_agencia)
{
    Cliente titular = new Cliente();
    Console.WriteLine(titular);
    ContaCorrente conta_corrente = new ContaCorrente(titular, agencia, conta, numero_agencia);
}

Console.ReadKey();