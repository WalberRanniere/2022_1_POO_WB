using System;

class MainClass {
  public static void Main() {
    Triangulo x = new Triangulo();
    Triangulo y = new Triangulo();
    y.SetBase(5);
    y.SetAltura(8);
    x.SetBase(10);
    x.SetAltura(20);
    Console.WriteLine(x.CalcArea());
    Console.WriteLine(y.CalcArea()); 
    
  }
  //private static double AreaTri (double b, double h) {
    //double area = b * h /2;
    //return area;
  //}
}
class Triangulo {
  private double b, h;
  public void SetBase(double v) {
    if(v > 0) b = v;
  }  
  public void SetAltura(double g) {
    if(g > 0) b = g;
  }
  public double GetBase() {
    return b;
  }
  public double GetBase() {
    return h;
  }
  public double CalcArea () {
    double area = b * h /2;
    return area;
  }
}
