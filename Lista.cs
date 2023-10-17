//Exemplo onde é imprimido os candidatos logo apos adicionado mais um candidato a lista

static void Main(string[] args)
{
  Console.WriteLine("Candidatos!!");

  var nomes = new List<String> { "Roberto", "Francisco" };
  foreach (var nome in nomes)
  {
    Console.WriteLine($"Bem vindo {nome}!");
  }

  Console.WriteLine("---------------------------");

  nomes.Add("Alexandre");
  Console.WriteLine("Lista com novos candidatos");

  foreach (var nome in nomes)
  {
    Console.WriteLine($"Bem vindo {nome}!");
  }

  Console.ReadLine();

}
