using System;

class Program {
  public static void Main() {
    int x = 1;
    while (x <= 10) {
      Console.WriteLine(x);
      x++;
    }
    Console.WriteLine("---------");
    for (x = 1; x <= 10; x++) {
      Console.WriteLine(x);
    }
    Console.WriteLine("---------");
    x = 1;
    do {
      Console.WriteLine(x);
      x++;
    } while(x <= 10);
  }
}