using System;

public class Filme {
  private int id;
  private string titulo;
  private string duracao;
  public Filme (int id, string titulo, string duracao) {
    this.id = id;
    this.titulo = titulo;
    this.duracao = duracao;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetTitulo(string titulo) {
    this.titulo = titulo;
  }
  public void SetDuracao(string duracao) {
    this.duracao = duracao;
  }
  public int GetId() {
    return id;
  }
  public string GetTitulo() {
    return titulo;
  }
  public string GetDuracao() {
    return duracao;
  }
}
