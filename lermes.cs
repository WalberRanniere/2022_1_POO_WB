using System;

class Program {
  public static void Main(){
    Console.WriteLine("Escreva o nome de um Mês:");
    string mes = Console.ReadLine();
    switch(mes) {
      case "Janeiro" : Console.WriteLine(1); break;
      case "Fevereiro" : Console.WriteLine(2); break;
      case "Março" : Console.WriteLine(3); break;
      case "Abril" : Console.WriteLine(4); break;
      case "Maio" : Console.WriteLine(5); break;
      case "Junho" : Console.WriteLine(6); break;
      case "Julho" : Console.WriteLine(7); break;
      case "Agosto" : Console.WriteLine(8); break;
      case "Setembro" : Console.WriteLine(9); break;
      case "Outubro" : Console.WriteLine(10); break;
      case "Novembro" : Console.WriteLine(11); break;
      case "Dezembro" : Console.WriteLine(12); break;
      default : Console.WriteLine("Mês Inválido"); break;
      
      
      
    }
  }
}