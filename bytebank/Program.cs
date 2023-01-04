using bytebank;

ContaCorrente contaDoLeonardo = new ContaCorrente();
contaDoLeonardo.titular = "Leonardo Saraiva";
contaDoLeonardo.numeroAgencia = 09;
contaDoLeonardo.conta = "1010-x";
contaDoLeonardo.saldo = 100;
Console.WriteLine("Saldo da conta do Leonardo = " + contaDoLeonardo.saldo);

ContaCorrente contaDoLeonardo2 = new ContaCorrente();
contaDoLeonardo2.titular = "Leonardo Saraiva";
contaDoLeonardo2.numeroAgencia = 09;
contaDoLeonardo2.conta = "1010-x";
contaDoLeonardo2.saldo = 100;
Console.WriteLine("Saldo da conta do Leonardo = " + contaDoLeonardo2.saldo);

contaDoLeonardo = contaDoLeonardo2;

Console.WriteLine(contaDoLeonardo == contaDoLeonardo2);    


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


//ContaCorrente conta = new ContaCorrente();
//Console.WriteLine($"Titular da conta: {contaDoLeonardo.titular}");
//Console.WriteLine($"Número da conta: {contaDoLeonardo.conta}");
//Console.WriteLine($"Agência: {contaDoLeonardo.numeroAgencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDoLeonardo.saldo)}");

//Console.ReadKey();