using System;

class Program {
  public static void Main() {
    int f = 1;
    Console.WriteLine("Digite um número:");
    int n = int.Parse(Console.ReadLine());
    for(int i = 1; i <= n; i++)
      f = f*i;
    Console.WriteLine($"Fatorial = {f}");
  }
}