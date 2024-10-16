namespace exercicio___3._1
{
    public class pessoa
    {
        public string Nome { get; set; }

         public int Idade { get; set; }

        public void envelhecer(int anos)
        {
            Idade += anos;
        }

        public void AguaDaVida(int anos)
        {
            Idade -= anos;
        }
    }

    public class funcionario : pessoa
    {

    }

}
