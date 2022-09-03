using System;

class MainClass {
  public static void Main() {
    double x = Area.AreaTri(10, 20);
    double y = Area.AreaTri(5, 8);
    Console.WriteLine(x);
    Console.WriteLine(y);
    
  }
  //private static double AreaTri (double b, double h) {
    //double area = b * h /2;
    //return area;
  //}
}

class Area {
  public static double AreaTri (double b, double h) {
    double area = b * h /2;
    return area;
  }
}