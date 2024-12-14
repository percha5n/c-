/*15. simular un cajero automático
escribe un programa que simule un cajero automático. el programa debe:

pedir al usuario su saldo inicial.
permitirle retirar dinero (siempre que tenga suficiente saldo).
mostrar el saldo después de cada transacción.
requisitos:

el usuario no debe poder retirar más dinero del que tiene en su saldo.
si el saldo es insuficiente, el programa debe mostrar un mensaje de error*/

using System;

public class CajeroAutomatico{
  public float saldo { get; set; }
  //metodo de para obtener el saldo inicial
  public void Saldoinicial(){
    Console.WriteLine("ingresar tu saldo actual");
    saldo = float.Parse(Console.ReadLine());
    Console.WriteLine("su saldo es: {0}"+ saldo);
  }

  //metodo para retirar el saldo
  public void Retirarsaldo(){
    Console.WriteLine("ingrese la cantidad de saldo a retirar: ");
    float retirarsaldo = float.Parse(Console.ReadLine());
    if (retirarsaldo <= saldo){
      saldo -= retirarsaldo;
      Console.WriteLine("retiraste: " + retirarsaldo);
      Console.WriteLine("el saldo restante es: " + saldo);
    }else{
      Console.WriteLine("error, no hay suficiente dinero");
    }
  }

  //metodo para mostrar el saldo
  public void MostrarSaldo(){
    Console.WriteLine("saldo disponible: "  + saldo);
  }
}

public class Program{
  public static void Main(){
    CajeroAutomatico cajero = new CajeroAutomatico();

    cajero.Saldoinicial();
    cajero.MostrarSaldo();
    cajero.Retirarsaldo();
    cajero.MostrarSaldo();
  }
}
