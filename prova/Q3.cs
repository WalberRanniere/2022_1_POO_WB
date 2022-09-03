using System;

class MainClass {
  public static void Main() {
    Loteria x = new Loteria();
    x.SetN1(4);
    x.SetN2(6);
    x.SetN3(8);
    x.SetN4(10);
    x.SetN5(12);
    x.SetN6(14);
    Console.WriteLine(x.ToString());
  }
class Loteria{
  private int n1, n2, n3, n4, n5, n6;
  public void SetN1(int n1){
    if(n1 > 0 && n1 <= 60) this.n1 = n1;
    
  }
  public void SetN2(int n2){
    if(n1 > 0 && n2 <= 60 && n2 != n1) this.n2 = n2;
    
  }
  public void SetN3(int n3){
    if(n3 > 0 && n3 <= 60 && n3 != n2 && n3 != n1) this.n3 = n3;
    
  }
  public void SetN4(int n4){
    if(n4 > 0 && n4 <= 60 && n4 != n3 && n4 != n2 && n4 != n1) this.n4 = n4;
    
  }public void SetN5(int n5){
    if(n5 > 0 && n5 <= 60 && n5 != n4 && n5 != n3 && n5 != n2 && n5 != n1) this.n5 = n5;
    
  }public void SetN6(int n6){
    if(n6 > 0 && n6 <= 60 && n6 != n5 && n6 != n4 && n6 != n3 && n6 != n2 && n6 != n1) this.n6 = n6;
    
  }
  public int GetN1() {
    return n1;
  }
  public int GetN2() {
    return n2;
  }
  public int GetN3() {
    return n3;
  }
  public int GetN4() {
    return n4;
  }
  public int GetN5() {
    return n5;
  }
  public int GetN6() {
    return n6;
  }
  public override string ToString() {
    return $"Esses são sue números da mega sena: {n1} {n2} {n3} {n4} {n5} {n6}";
  }
}
}