using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!\n");

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "André Silva";
//conta1.conta = "110123-X";
//conta1.numero_agencia = 123;
//conta1.nome_agencia = "Agência Central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Nogueira";
//conta2.conta = "10106-X";
//conta2.numero_agencia = 321;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 100;

//Console.WriteLine("Saldo da Amanda pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André  pré- Transferência: " + conta1.saldo);
//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferência realizada com sucesso? " + transferencia);
//Console.WriteLine("Saldo da Amanda pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André  pós- Transferência: " + conta1.saldo);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = new Cliente();
//conta3.titular.nome = "André Silva";
//conta3.titular.profissao = "Programador C#";
//conta3.numero_agencia = 35;
//conta3.nome_agencia = "Agência Central";
//conta3.saldo = 100;

//Console.WriteLine(conta3.titular.nome);

//if (conta3.titular == null)
//{
//    Console.WriteLine("O campo titular está nulo.");
//}

Cliente sarah = new Cliente();
sarah.Nome = "Sarah Silva";

ContaCorrente conta4 = new ContaCorrente();
conta4.Saldo = 100;
conta4.Titular = sarah;
Console.WriteLine(conta4.Saldo);

Console.ReadKey();