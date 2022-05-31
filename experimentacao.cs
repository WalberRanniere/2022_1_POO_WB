using System;

class Program {
  public static void Main() {
    int x = 15;
    while (x <= 10) {
      Console.WriteLine(x);
      x++;
    }

    Console.WriteLine("for");
    for (x = 1; x <= 10; x++) {
      Console.WriteLine(x);
    }

    
    Console.WriteLine("do while");
    x = 15;

    do {
      Console.WriteLine(x);
      x++;
    } while (x <= 10);

    string s = "Tecnologia";
    foreach (char c in s) {
      Console.WriteLine(c);
    }
  }
}