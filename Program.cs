using Heranca;

Gerente gerente = new Gerente();
//Console.WriteLine(gerente.Nome);

gerente.Nome = "Carlos";
gerente.Codigo = 123;


gerente.Trabalhar();
gerente.GerenciarEquipe();


Funcionario f = new Gerente(); // Cria um objeto do tipo gerente e permita que a variavel f, declarada como Funcionario, referencie esse objeto

Gerente gerente2 = new Gerente
{ 
  Nome = "Kessia"
};

gerente2.DefinirSalario(2000.0m);
gerente2.ExibirSalario();


