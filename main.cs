using System;

class MainClass {
  public static void Main (string[] args) {
    int num1, num2, num3;
    Console.WriteLine ("Informe 3 números: ");


    num1 = int.Parse (Console.ReadLine());
    num2 = int.Parse (Console.ReadLine());
    num3 = int.Parse (Console.ReadLine());

    if (num1 > num2 && num1 < num3){
      Console.WriteLine ("Intermediária: " + num1);
    }

    if (num2 > num1 && num2 < num3){
      Console.WriteLine("Intermediário: " + num2);
    }

    if (num3 > num1 && num3 <num2){
      Console.WriteLine ("Intermediário: " + num3);
    }
  }
}