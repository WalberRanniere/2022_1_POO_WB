using System;

class Program {
  public static void Main() {
    Console.WriteLine("Bem-vindo ao CinemaIF");
    int op = 0;
    do {
      try{
        op = Menu();
        switch(op) {
          case 1 : SalaInserir(); break;
          case 2 : SalaListar(); break;
          case 3 : SalaAtualizar; break;
          case 4 : SalaExcluir(); break;
          case 5 : FilmeInserir(); break;
          case 6 : FilmeListar(); break;
          case 7 : FilmeAtualizar(); break;
          case 8 : FilmeExcluir(); break;
          case 9 : GeneroInserir(); break;
          case 10 : GeneroListar(); break;
          case 11: GeneroAtualizar(); break;
          case 12 : GeneroExcluir(); break;
          case 13 : SessaoInserir(); break;
          case 14 : SessaoListar(); break;
          case 15 : SessaoAtualizar(); break;
          case 16 : SessaoExcluir(); break;  
        } 
      }
      catch (Exception erro) {
        op = -1;
        Console.WriteLine("Erro: " + erro.Message);
      }
    } While (op != 0);
  }
    public static int Menu() {
      Console.WriteLine();
      Console.WriteLine("----- Escolha uma opção! -----");
      Console.WriteLine("01 - Inserir uma Sala");
      Console.WriteLine("02 - Listar as Salas cadastradas");
      Console.WriteLine("03 - Atualizar uma Sala");
      Console.WriteLine("04 - Excluir uma Sala");
      Console.WriteLine("------------------------------");
      Console.WriteLine("05 - Inserir um Filme");
      Console.WriteLine("06 - Listar os Filmes cadastrados");
      Console.WriteLine("07 - Atualizar um Filme");
      Console.WriteLine("08 - Excluir um Filme");
      Console.WriteLine("------------------------------");
      Console.WriteLine("09 - Inserir um Gênero");
      Console.WriteLine("10 - Listar os Gêneros cadastrados");
      Console.WriteLine("11 - Atualizar um Gênero");
      Console.WriteLine("12 - Excluir um Gênero");
      Console.WriteLine("------------------------------");
      Console.WriteLine("13 - Inserir uma Sessão");
      Console.WriteLine("14 - Listar as Sessões cadastradas");
      Console.WriteLine("15 - Atualizar uma Sessão");
      Console.WriteLine("16 - Excluir uma Sessão");
      Console.Write("Opção: ");
      int op = int.Parse(Console.ReadLine());
      Console.WriteLine();
      return op;
    }
    public static void SalaInserir() {
      Console.WriteLine("---- Inserir uma nova Sala ----");
      Console.Write("Informe o número da Sala: ");
      int nro_sala = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe a sua quantidade: ");
      int quantidade = int.Parse(Console.ReadLine());
      Sala obj = new Sala(nro_sala, quantidade);
      Sistema.SalaInserir(obj);
      Console.WriteLine("---- Operação realizada com sucesso ----");
    }
    public static void SalaListar() {
      Console.WriteLine("---- Listar as salas cadastradas ----");
      foreach(Sala obj in Sistema.SalaListar())
        Console.WriteLine(obj);
      Console.WriteLine("------------------");
    }
    public static void SalaAtualizar() {
      Console.WriteLine("---- Atualizar uma sala ----");
      Console.Write("Informe o número da sala para ser atualizada: ");
      int nro_sala = int.Parse(Console.ReadLine());
      Console.Write("Informe a nova quantidade da sala: ";
      int quantidade = int.Parse(Console.ReadLine());
      Sala obj = new Sala(nro_sala, quantidade);
      Sistema.SalaAtualizar(obj);
      Console.WriteLine("---- Operação realizada com sucesso ----");
    }
    public static void SalaExcluir() {
      Console.WriteLine("---- Excluir uma sala ----");
      Console.Write("Informe o número da sala a ser excluída: ");
      int nro_sala = int.Parse(Console.ReadLine());
      int quantidade = 1;
      Sala obj =new Sala(nro_sala, quantidade);
      Sistema.SalaExcluir(obj);
      Console.WriteLine("---- Operação realizada com sucesso ----");
    }
    public static void FilmeInserir() {
      Console.WriteLine("---- Inserir uma novo Filme ----");
      Console.Write("Informe o id do Filme: ");
      int nro_sala = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe a seu Titulo: ");
      string titulo = Console.ReadLine();
      Console.Write("Informe a sua duração: ");
      string duracao = Console.ReadLine();
      Filme obj = new Sala(id, titulo, duracao);
      Sistema.FilmeInserir(obj);
      Console.WriteLine("---- Operação realizada com sucesso ----");
    }
    public static void FilmeListar() {
      Console.WriteLine("---- Listar os filmes cadastrados ----");
      foreach(Filme obj in Sistema.FilmeListar())
        Console.WriteLine(obj);
      Console.WriteLine("---------------------------");
    } 
    public static void FilmeAtualizar() {
      Console.WriteLine("---- Atualizar um filme ----");
      Console.Write("Informe o id do filme a ser atualizado: ");
      int id = int.Parse(Console.ReadLine());
      Console.Write("Informe o titulo do filme: ");
      string titulo = Console.ReadLine();
      Console.Write("Informe a duracao do filme: ");
      string duracao = Console.ReadLine();
      Filme obj = new Filme(id, titulo, duracao);
      sistema.FilmeAtualizar(obj);
      Console.WriteLine("---- Operação realizada com sucesso ----");
    }
    public static void FilmeExcluir() {
    Console.WriteLine("---- Excluir um filme ----");
      Console.WriteLine("Informe o id do filme a ser excluido: ");
      int id = int.Parse(Console.ReadLine());
      Filme obj = new Filme(id);
      Sistema.FilmeExcluir(obj);
      Console.WriteLine("---- Operação realizada com suxesso ----");
    }
    public static void GeneroInserir() {
      
    }
    public static void GeneroListar() {
      
    }
    public static void GeneroAtualizar() {
      
    }
    public static void GeneroExcluir() {
      
    }
    public static void SessaoInserir() {
      
    }
    public static void SessaoListar() {
      
    }
    public static void SessaoAtualizar() {
      
    }
    public static void SessaoExcluir() {
      
    }
}