using System;

public class Program {
  public static void Main(){
    string s = Console.ReadLine().ToUpper();
    while (s != "*") {
      char c = s[0];
      bool ok = true;
      string[] v = s.Split();
      foreach (string palavra in v) {
        if(palavra[0] != c) ok = false;
      }

      Console.WriteLine(ok ? "Y" : "N");
      s = Console.ReadLine().ToUpper();
    }
  }
}