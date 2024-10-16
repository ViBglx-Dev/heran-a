namespace exercicio___2._1
{
    public abstract class ContaG
    {

        public string Banco { get; set; }
        public string Agencia { get; set; }
        public int Conta { get; set; }
        public decimal Saldo { get; set; }


        public abstract void Deposito();

        public abstract void Sacar();

    }

    public class ContaCorrente : ContaG
    {
        public double Limite { get; set; }
        public override void Deposito()
        {

            Console.WriteLine("Voce depositou 1.000,00");
        }

        public override void Sacar()
        {
            Console.WriteLine("Você sacou R$10.000,00");
        }
    }

}
