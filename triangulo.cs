using System;

class MainClass {
  public static void Main() {
    Triangulo x = new Triangulo();
    x.b = 10;
    x.h = 20;
    Console.WriteLine(x.CalcArea());
    
  }
  //private static double AreaTri (double b, double h) {
    //double area = b * h /2;
    //return area;
  //}
}
class Triangulo {
  public double b, h;
  public double CalcArea () {
    double area = b * h /2;
    return area;
  }
}
