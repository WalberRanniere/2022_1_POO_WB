using System;

public class Program {
  public static void Main() {
    string[] v = Console.ReadLine().Split();
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]);
    int c = int.Parse(v[2]);

    int maior = a;
    if (b > maior) maior = b;
    if (c > maior) maior = c;

    Console.WriteLine("{0} eh o maior", maior);
  }
}