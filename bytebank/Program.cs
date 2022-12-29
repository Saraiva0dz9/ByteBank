using bytebank;

ContaCorrente contaDoLeonardo = new ContaCorrente();
contaDoLeonardo.titular = "Leonardo Saraiva";
contaDoLeonardo.numeroAgencia = 09;
contaDoLeonardo.conta = "1010-x";
contaDoLeonardo.saldo = 100;

Console.WriteLine("Saldo da conta do Leonardo = " +contaDoLeonardo.saldo);