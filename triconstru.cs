using System;


class Program {
  public static void Main() {
    double bx = 20;
    double hx = 10;
    string cx = "Azul";

    Triangulo t = new Triangulo(bx, hx, cx);

    Console.WriteLine(t);
  }
}

public class Triangulo {
  private double b, h;
  private string cor;
  public Triangulo(double b, double h, string cor) {
    this.b = b;
    this.h = h;
    this.cor = cor;
  }
}