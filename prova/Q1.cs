using System;

class MainClass {
  public static void Main(){
    Energia x = new Energia();
    x.SetMes(8);
    x.SetAno(2001);
    x.SetValor(34.5);
    Console.WriteLine(x.ToString());
  }
class Energia {
  private int mes, ano;
  private double valor;
  public void SetMes(int m) {
    if(0 < m && m <= 12) mes = m;
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