using System;

class Program {
  public static void Main() {
    
  }
}

public class Paciente {
  private string nome, cpf, telefone;
  private DateTime nascimento;

  public string Nome {
    set => nome;
    get => nome;
  }
  public string Cpf {
    set => cpf;
    get => cpf;
  }
  public string Telefone {
    set => telefone;
    get => telefone;
  }
  public DateTime Nascimento {
    
  }
  public override ToString() {
    return $"Nome = {nome}, CPF = {cpf}, Telefone = {teefone}, Nascimento = {nascimento}";
    
  }
}