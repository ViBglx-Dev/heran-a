using exercicio___3._1;

/*  Funcionario 1 */
//instanciando a classe funcionario
funcionario fun1 = new funcionario { Nome = "rafael", Idade = 30 };

//chamando o metodo envelhecer
fun1.envelhecer(10); //somar a idade que vc passou para variavel fun1 mais de 10

Console.WriteLine($"nome: {fun1.Nome}, idade: {fun1.Idade}");

/* Funcionario 2 */
funcionario fun2 = new funcionario { Nome= "Thomas Correa", Idade = 17 };

fun2.envelhecer(10);

Console.WriteLine($"nome: {fun2.Nome}, idade: {fun2.Idade}");

/* Funcionario 3 */
funcionario fun3 = new funcionario { Nome = "Vitoria Bougleux", Idade = 26 };

fun3.AguaDaVida(10);

Console.WriteLine($"nome: {fun3.Nome}, idade: {fun3.Idade}");




Console.ReadKey();