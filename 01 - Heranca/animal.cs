namespace _01_Heranca
{

    //a classe animal é uma classe ABSTRATA que servirá de modelo para os outros animais//
    public abstract class animal
    {
        public string Nome { get; set; }
        public int Idade { get; set;}
        public string  alimentacao { get; set;}

        //metodo abstrato - não possue implementação aqui, mais as classes que herdarem vao precisar implementar//
        public abstract void Emitirsom();

    }

    //a calsse cachorro herda da classe animal, isso significa que o cachorro terá todos os atributos e comportamentos definidos em animal, mais vc pode colocar caracteristicas novas //
    public class cachorro : animal
    {
        public string raca { get; set;}
        public bool buscarobj { get; set;}

        public override void Emitirsom()
        {
            Console.WriteLine("AU! AU!");
        }
    }
}
