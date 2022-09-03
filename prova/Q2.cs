using System;

class MainClass {
  
  public static void Main(){
    int maior = 0;
    Energia x = new Energia();
    x.SetMes(int.Parse(Console.ReadLine()));
    x.SetAno(int.Parse(Console.ReadLine()));
    x.SetValor(double.Parse(Console.ReadLine()));
    
    Energia y = new Energia();
    y.SetMes(int.Parse(Console.ReadLine()));
    y.SetAno(int.Parse(Console.ReadLine()));
    y.SetValor(double.Parse(Console.ReadLine()));

    Energia z = new Energia();
    z.SetMes(int.Parse(Console.ReadLine()));
    z.SetAno(int.Parse(Console.ReadLine()));
    z.SetValor(double.Parse(Console.ReadLine()));

    Energia w = new Energia();
    w.SetMes(int.Parse(Console.ReadLine()));
    w.SetAno(int.Parse(Console.ReadLine()));
    w.SetValor(double.Parse(Console.ReadLine()));

    Energia v = new Energia();
    v.SetMes(int.Parse(Console.ReadLine()));
    v.SetAno(int.Parse(Console.ReadLine()));
    v.SetValor(double.Parse(Console.ReadLine()));

    Energia u = new Energia();
    u.SetMes(int.Parse(Console.ReadLine()));
    u.SetAno(int.Parse(Console.ReadLine()));
    u.SetValor(double.Parse(Console.ReadLine()));

    Energia t = new Energia();
    t.SetMes(int.Parse(Console.ReadLine()));
    t.SetAno(int.Parse(Console.ReadLine()));
    t.SetValor(double.Parse(Console.ReadLine()));   

    Energia r = new Energia();
    r.SetMes(int.Parse(Console.ReadLine()));
    r.SetAno(int.Parse(Console.ReadLine()));
    r.SetValor(double.Parse(Console.ReadLine()));

    Energia s = new Energia();
    s.SetMes(int.Parse(Console.ReadLine()));
    s.SetAno(int.Parse(Console.ReadLine()));
    s.SetValor(double.Parse(Console.ReadLine()));

    Energia q = new Energia();
    q.SetMes(int.Parse(Console.ReadLine()));
    q.SetAno(int.Parse(Console.ReadLine()));
    q.SetValor(double.Parse(Console.ReadLine()));

    Energia p = new Energia();
    p.SetMes(int.Parse(Console.ReadLine()));
    p.SetAno(int.Parse(Console.ReadLine()));
    p.SetValor(double.Parse(Console.ReadLine()));

    Energia o = new Energia();
    o.SetMes(int.Parse(Console.ReadLine()));
    o.SetAno(int.Parse(Console.ReadLine()));
    o.SetValor(double.Parse(Console.ReadLine()));

    

    
  }
class Energia {
  
  private int mes, ano;
  private double valor;
  public void SetMes(int m) {
    if(m <= m && m <= 12) mes = m;
  }
  public void SetAno(int a) {
    if(1 <= a) ano = a;
  }
  public void SetValor(double v) {
    if(0 < v) valor = v;
  }
  public int GetMes() {
    return mes;
  }
  public int GetAno() {
    return ano;
  }
  public double GetValor() {
    return valor;
  }
  public override string ToString() {
    return $"Mes = {mes}, Ano = {ano}, Valor = R${valor:0.00}";
  }   
  }
  
}