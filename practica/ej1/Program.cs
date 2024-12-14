using System;

public class Bucle{
  public string nombre {get; set;}
  public string apellido {get; set; }
  public int num1 { get; set; }
  public float num2 { get; set; }

  static void Main(){
  
    Bucle persona = new Bucle();

    persona.nombre = "juan";
    persona.apellido = "pretti";
    persona.num1 = 100;
    persona.num2 = 13.2f;

    for(int i=0; i<=10; i++){
      Console.WriteLine(persona.nombre + " " + persona.apellido + " " + persona.num1 + " " + persona.num2);
    }
  }
}
