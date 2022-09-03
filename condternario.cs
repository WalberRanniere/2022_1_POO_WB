using System;

class Program {
  public static void Main(){
    Console.WriteLine("Escreva um número inteiro:");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine(x%2 == 0 ? "Par" : "Impar");
  }
}