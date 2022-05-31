using System;

public class Program {
  public static void Main() {

    Aluno a1 = new Aluno();
    a1.nome = "Walber";
    a1.matricula = "20211014040077";
    a1.idade = 20;

    Console.WriteLine(a1.nome);
    
    
    
  }
}

class Aluno {
  public string nome;
  public string matricula;
  public int idade;
  
  
}