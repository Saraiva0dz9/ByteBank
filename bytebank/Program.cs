﻿using bytebank.Conta;
using bytebank.Titular;

//ContaCorrente contaDoLeonardo = new ContaCorrente();
//contaDoLeonardo.titular = "Leonardo Saraiva";
//contaDoLeonardo.numeroAgencia = 09;
//contaDoLeonardo.conta = "1010-x";
//contaDoLeonardo.saldo = 100;
//Console.WriteLine("Saldo da conta do Leonardo = " + contaDoLeonardo.saldo);

//ContaCorrente contaDoLeonardo2 = new ContaCorrente();
//contaDoLeonardo2.titular = "Leonardo Saraiva";
//contaDoLeonardo2.numeroAgencia = 09;
//contaDoLeonardo2.conta = "1010-x";
//contaDoLeonardo2.saldo = 100;
//Console.WriteLine("Saldo da conta do Leonardo = " + contaDoLeonardo2.saldo);

//contaDoLeonardo = contaDoLeonardo2;

//Console.WriteLine(contaDoLeonardo == contaDoLeonardo2);    


//ContaCorrente contaDaKaty = new ContaCorrente();
//contaDaKaty.titular = "Katy Victoria";
//contaDaKaty.numeroAgencia = 10;
//contaDaKaty.conta = "1010-x";
//contaDaKaty.saldo = 400;


//Console.WriteLine("Saldo da conta da Katy = " + contaDaKaty.saldo);

//contaDoLeonardo.Transferir(50, contaDaKaty);
//Console.WriteLine("Saldo do Leonardo = "+ contaDoLeonardo.saldo);
//Console.WriteLine("Saldo do Katy = "+ contaDaKaty.saldo);

//ContaCorrente contaDoJoao = new ContaCorrente();
//contaDoJoao.titular = "Joao Silva";
//Console.WriteLine(contaDoJoao.titular);
//Console.WriteLine(contaDoJoao.saldo);
//Console.WriteLine(contaDoJoao.numeroAgencia);
//Console.WriteLine(contaDoJoao.conta);

//Cliente cliente = new Cliente();
//cliente.nome = "Leonardo Saraiva";
//cliente.Cpf = "42992194816";
//cliente.profissao = "Desenvolvedor";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-x";
//conta.numeroAgencia = 09;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.Cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("Nº Conta = " + conta.conta);
//Console.WriteLine("Nº Agência = " + conta.numeroAgencia);
//Console.WriteLine("Saldo = " + conta.saldo);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "Marco Amaral";
//conta2.titular.profissao = "Ferramenteiro";
//conta2.titular.Cpf = "27401668803";
//conta2.conta = "1010-x";
//conta2.numeroAgencia = 11;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.NumeroAgencia = 18;
//conta3.Conta = "1011-h";
//conta3.SetSaldo(200);

//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.NumeroAgencia);
//Console.WriteLine(conta3.Conta);

ContaCorrente conta4 = new ContaCorrente(18, "1010-x");
conta4.SetSaldo(500);
conta4.Titular = new Cliente();

Console.WriteLine(conta4.GetSaldo());
Console.WriteLine(conta4.NumeroAgencia);


//ContaCorrente conta = new ContaCorrente();
//Console.WriteLine($"Titular da conta: {contaDoLeonardo.titular}");
//Console.WriteLine($"Número da conta: {contaDoLeonardo.conta}");
//Console.WriteLine($"Agência: {contaDoLeonardo.numeroAgencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDoLeonardo.saldo)}");

//Console.ReadKey();