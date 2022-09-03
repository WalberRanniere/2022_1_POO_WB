using System;
using System.Collections.Generic;

class Sistema {
  private static Sala[] salas = new Sala[10];
  private static int nSala;
  private static List<Filmes> filmes = new List<Filme>();
  public static void SalaInserir(Sala obj) {
    if (nSala == salas.Length)
      Array.Resize(ref salas, 2 * salas.Length);
    salas[nSala] = obj;
    nSala++;
  }
  public static Sala[] SalaListar() {
    Sala[] aux = new Sala[nSala];
    Array.Copy(salas, aux, nSala);
    return aux;
  }
  public static void Sala SalaListar(int id) {
    foreach(Sala obj in salas)
      if (obj != null && obj.GetNum() == id) return obj;
    return null;
  }
  public static void SalaAtualizar (Sala obj) {
    Sala aux = SalaListar(obj.GetNum());
    if (aux != null)
      aux.SetNum(obj.GetNum());
      aux.SetQuantidade(obj.GetQuantidade());
  } 
  public static void SalaExcluir(Sala obj) {
    int aux = SalaIndice(obj.GetNum());
    if (aux != -1) {
      for (int i = aux; 1 < nSala -1; i++)
        salas[1] = salas[i + 1];
      nSala--;
    }
  }
  private static int SalaIndice(int id) {
    for (int i = 0; i < nSala; i++) {
      Sala obj = salas[i];
      if (obj.GetNum() == id) return i;
    }
    return -1;
  }
  private static void FilmeInserir(Filme obj) {
    filmes.Add(obj);
  }
  public static List<Filme> FilmeListar() {
    return filmes;
  }
  public static Filme FilmeListar(int id) {
    foreach(Filme obj in filmes)
      if (obj.GetId() == id) return obj;
    return null;
  }
  public static void FilmeAtualizar(Filme obj) {
    Filme aux = FilmeListar(obj.GetId());
    if (aux != null) {
      aux.SetTitulo(obj.GetTitulo());
      aux.SetDuracao(obj.GetDuracao());
    }
  }
  public static void FilmeExcluir(Filme obj) {
    Filme aux = FilmeListar(obj.GetId());
    if (aux != null) filmes.Remove(aux);
  }
}