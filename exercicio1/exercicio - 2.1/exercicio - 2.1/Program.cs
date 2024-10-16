using exercicio___2._1;

ContaCorrente contaC = new ContaCorrente
{
    Limite = 90000,
    Banco = "Sicob",
    Agencia = "93827347",
    Conta = 51509009,
    Saldo = 290000,
};

Console.WriteLine("O limite da sua conta é" + contaC.Limite);
Console.WriteLine("O banco da conta" + contaC.Banco);
Console.WriteLine("è agenciado por" + contaC.Agencia);
Console.WriteLine("conta" + contaC.Conta);
Console.WriteLine("o saldo na conta" + contaC.Saldo);