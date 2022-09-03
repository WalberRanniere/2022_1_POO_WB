using System;

class Sessao {
  private int id;
  private DateTime dt_sessao; 
  private string horario_sessao;
  private float valor_ingresso;
  private float meio_ingresso;
  private bool encerrado;
  private int idsala;
  private int idfilme;
  public Sessao (int id, DateTime dt_sessao, string horario_sessao, 
                float valo_ingresso, float meio_ingresso, bool encerrado, int idsala, int idfilme) {
    this.id = id;
    this.dt_sessao = dt_sessao;
    this.valor_ingresso = valor_ingresso;
    this.meio_ingresso = valor_ingresso / 2;
    this.encerrado = encerrado;
    this.idsala = idsala;
    this.idfilme = idfilme;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetData(DateTime dt_sessao) {
    this.dt_sessao = dt_sessao;
  }
  public void SetHora(string horario_sessao) {
    this.horario_sessao = horario_sessao;
  }
  public void SetValor(float valor_ingresso) {
    this.valor_ingresso = valor_ingresso;
  }
  public void SetMeia(float meio_ingresso) {
    this.meio_ingresso = valor_ingresso / 2;
  }
  public void SetTerm(bool encerrado) {
    this.encerrado = valor_encerrado;
  }
  public void SetIdsala (int idsala) {
    this.idsala = idsala;
  }
  public void SetIdfilme (int idfilme) {
    thirs.idfilme = idfilme;
  }
  public int GetId() {
    return id;
  }
  public DateTime GetData() {
    return dt_sessao;
  }
  public string GetHora() {
    return horario_sessao
  }
  public float GetValor() {
    return valor_ingresso;
  }
  public float GetMeia() {
    return meio_ingresso;
  }
  public bool GetTerm() {
    return encerrado;
  }
  public int GetIdsala() {
    return idsala;
  } 
  public int GetIdfilme() {
    return idfilme;
  }
  public override string ToString() {
    return $"{id} - {idfilme} - {idsala} - {dt_sessao} | {horario_sessao} - {valor_ingresso";
  }
}


