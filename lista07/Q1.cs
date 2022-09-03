using System;

class Program {
  public static void Main() {
    Retangulo r = new Retangulo();
    r.Altura = 20;
    r.Base = 15;
    //double area = r.Area;
    //double diag = r.Diagonal;
    Console.WriteLine(r);
    Console.WriteLine($"Área = {r.Area}m²"); 
    Console.WriteLine($"Diagonal = {r.Diagonal}m"); 
    
  }
}
public class Retangulo {
  private double b, h;
  public double Base {
    set {if (value > 0) b = value;}
    get {return b;}
  }
  public double Altura {
    set {if (value > 0) h = value;}
    get {return h;}
    
  }
  public double Area {
    get { return b * h;}   
  }
  public double Diagonal {
    get { return Math.Sqrt(h*h+b*b);}   
  }
  public override string ToString() {
        return $"Base = {b}, Altura = {h}";
  }
}