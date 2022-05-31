using System;

class Program {
  public static void Main() {
    int x = MenorValor(10,3,4);
    Console.WriteLine(x);
    Console.WriteLine(MenorValor(1,3,4));
    Console.WriteLine(MenorValor(1,4));
    int[] w = {5, 8, 9, 3, 2, 5};
    Console.WriteLine(MenorValor(w));
    
  }
  public static int MenorValor(int[] v) {
    int menor = v[0];
    foreach(int i in v)
      if (i < menor) menor = i;
    return menor;
    
    
  }
    public static int MenorValor(int a, int b) {
    int menor = a;
    if (b < menor) menor = b;
    return menor;
    
    
  }

  public static int MenorValor(int a, int b, int c) {
    int menor = a;
    if (b < menor) menor = b;
    if (c < menor) menor = c;
    return menor;
    
    
  }
}