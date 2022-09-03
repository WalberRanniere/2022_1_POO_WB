using System;

class Program {
  public static void Main() {
    int[] v  = { 2, 4, 6, 8, 1, 3, 5, 7};
    Array.Sort(v);
    foreach(int i in v) Console.WriteLine(i);

    string[] w = {"C#", "Java", "Python", "Basic"};
    Array.Sort(w);
    foreach(string i in w) Console.WriteLine(i);

    DateTime[] x = {
      DateTime.Parse("2020-11-10"),
      DateTime.Parse("2019-11-10"),
      DateTime.Parse("2018-11-10")
      
    };
    Array.Sort(x);
    foreach(DateTime i in x) Console.WriteLine(i);

    IComparable a = 10;
    IComparable b = 20;
    Console.WriteLine(a.CompareTo(b));
  }
}