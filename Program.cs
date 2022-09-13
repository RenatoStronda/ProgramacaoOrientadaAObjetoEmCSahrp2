// See https://aka.ms/new-console-template for more information
namespace carro{

    class Program {

    public static void Main (string[] args) {
     Console.WriteLine("Olá");
    carro c = new carro();
    Console.WriteLine("Digite O Preço Do Carro: ");
    c.preco = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite O Modelo Do Carro: ");
    c.modelo = (Console.ReadLine());
    Console.WriteLine("O Preço Do Carro É {0} E O Modelo Do Carro É {1} ", c.preco, c.modelo);
    Console.WriteLine(c);
  }
}
public class carro{
  public int preco;
  public string modelo;
}
}