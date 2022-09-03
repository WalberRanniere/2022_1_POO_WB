using System;

class Program {
  public static void Main() {
    Aluno a = new Aluno("Pedro", DateTime.Parse("01/01/1992"));
    Aluno b = new Aluno("Maria", DateTime.Parse("01/01/1993"));
    Aluno c = new Aluno("Paulo", DateTime.Parse("01/01/1991"));
    Aluno[] v = {a, b, c};

    foreach (Aluno i in v) Console.WriteLine(i);
  }
}

class Aluno {
  private string nome;
  private DateTime nasc;
  public Aluno(string n, DateTime d) {  
    this.nome = n;
    this.nasc = d;
  }
  public override string ToString() {
    return $"{nome} {nasc:dd/MM/yyyy}";
  }
}