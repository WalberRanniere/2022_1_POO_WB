using System;

class Program {
  public static void Main() {
    string[] v = Console.ReadLine().Split();
    double a = double.Parse(v[0]);
    double b = double.Parse(v[1]);
    double c = double.Parse(v[2]);

    double pi = 3.14159;

    double areatri = a*c/2;
    double areacir = pi*(c*c);
    double areatra = (a+b)*c/2;
    double areaquadra = b*b;
    double arearetan = a*b;

    Console.WriteLine($"TRIANGULO: {areatri:0.000}");
    Console.WriteLine($"CIRCULO: {areacir:0.000}");
    Console.WriteLine($"TRAPEZIO: {areatra:0.000}");
    Console.WriteLine($"QUADRADO: {areaquadra:0.000}");
    Console.WriteLine($"RETANGULO: {arearetan:0.000}");
    
    
  }
}