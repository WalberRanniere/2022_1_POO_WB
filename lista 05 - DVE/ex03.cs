using System;

enum Pagamento {
  EmAberto, PagoParcial, Pago;
}

class Boleto {
  private double valorBoleto, valorPago;
  private Pagamento situacaoPagamento;
  public Boleto(double valor) {
    if (valorPago > 0) {
    valorBoleto = valor;
    valorPago = 0;
    situacaoPagamento = Pagamento.EmAberto;
    }
  }
  public void Pagar(double valorPago) {
    if (valorPago > 0) {
    this.valorPago = valorPago;
    if (valorPago== valorBoleto)
      situacaoPagamento = Pagamento.Pago;
    else
      situacaoPagamento = Pagamento.PagoParcial;
    }
  }
  public Pagamento Situacao() {
    return situacaoPagamento;
  }
  public overrride string ToString() {
    return $"Valor = {valorBoleto:c2}, Pago = {valorPago:c2}, Situação = {situacaoPagamento:c2}";
  }
}

class program {
  public static void Main() {
    Pagamento p = Pagamento.Emaberto;
    Console.WriteLine(p);
    
  }
}