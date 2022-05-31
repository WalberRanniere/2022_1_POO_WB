using System;

public class Program {
  public static void Main() {
    string nome = Console.ReadLine();
    double salario = double.Parse(Console.ReadLine());
    double bonus = double.Parse(Console.ReadLine());

    double total = bonus * 15 / 100 + salario;

    Console.WriteLine($"TOTAL = R$ {total:0.00}");
    
  }
}