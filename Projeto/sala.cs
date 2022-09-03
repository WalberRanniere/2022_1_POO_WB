using System;

class Sala {
  private int nro_sala;
  private int capacidade;
  public Sala(int nro_sala, int quantidade) {
    this.nro_sala = nro_sala;
    this.quantidade = quantidade;
  }
  public void SetNum(int nro_sala) {
    this.nro_sala = nro_sala; 
  }
  public void SetQuantidade(int quantidade) {
    this.quantidade = quantidade; 
  }
  public int GetNum() {
    return nro_sala;
  }
  public int GetQuantidade() {
    return quantidade;
  }
  public override string ToString() {
    return $"Sala {nro_sala} - {quantidade} poltronas";
  }
}
