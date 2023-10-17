//Exemplo de pilha onde é adicionado candidatos depois retiraados da pilha 
static void Main(string[] args)
{
  Console.WriteLine("Candidatos!!");
  Stack<String> nomes = new Stack<String>();

  nomes.Push("Alexandre");
  nomes.Push("Thalita");
  nomes.Push("Breno");

  foreach (String nome in nomes)
  {
    Console.WriteLine($"Bem vindo {nome}!");
  }

  nomes.Pop();

  Console.WriteLine("-------------------------");

  Console.WriteLine("Lista com canditados desclassificados");

  foreach (String nome in nomes)
  {
    Console.WriteLine($"Bem vindo {nome}!");
  }

  Console.ReadLine();

}
