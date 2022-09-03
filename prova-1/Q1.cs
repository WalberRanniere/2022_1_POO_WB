using System;

class Program {
  public static void Main() {
    Medicamento p = new Medicamento ("Paracetamol");
    Lote b = new Lote ("B1", DateTime.Parse("01/01/1992"), 10);
    Lote c = new Lote ("C1", DateTime.Parse("01/04/1992"), 15);
    Lote d = new Lote ("D1", DateTime.Parse("01/05/1992"), 25);  

    p.Inserir(b);
    p.Inserir(c);
    p.Inserir(d);  

    Array.Sort(p, new LoteComp());

    foreach(Lote x in p)
      Console.WriteLine(x);
    
  }
}

class LoteComp : IComparer {
  public int Compare(object x, object y) {
    Lote a = (Lote)x;
    Lote b = (Lote)y;
    return a.GetVencimento().CompareTo(b.GetVencimento());
  }
}

class Lote : IComparable {
  private string numero;
  private DateTime vencimento;
  private int estoque;
  public Lote(string n, DateTime v, int e) {
    this.numero = n;
    this.vencimento = v;
    if (e > 0) this.estoque = e;
  }
  public int CompareTo(object obj) {
    lote x = (Lote) obj;
    return this.vencimento.CompareTo(x.vencimento);
  }
  public DateTime GetVencimento() {
    return vencimento;
  }
  public override string ToString() {
    return $"{numero} - {vencimento} - {estoque}";
  }
}

class Medicamento  {
  private Lote[] lote;
  private string nome;
  private int qtd;
  public Medicamento(string n) {
    this.nome = n;
    lote = new Lote[8];
  }
  public void Inserir (Lote lot) {
    if (qtd < 8) {
      lote[qtd] = lot;
      qtd++;
      }
    }
  public Lote[] Listar() {
    Lote[] r = new Lote[qtd];
    Array.Copy(lote, r, qtd);
    return r;
  }
  public Lote[] Pesquisar(int m, int a) {
    return r;
  }
}