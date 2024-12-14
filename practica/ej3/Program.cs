/*Números pares e impares
Escribe un programa que imprima si un número dado es par o impar.

Requisitos:

El programa debe solicitar un número al usuario.
Utiliza el operador % para verificar si el número es par o impar.
*/

using System;

public class Program{
  public static void Main(){
    Console.Write("ingresar un numero: ");
    int num = int.Parse(Console.ReadLine());
      if(num % 2 == 0){
        Console.WriteLine("el numero {0} par es", num);
      }else{
        Console.WriteLine("el numero {0} impar es", num);
      }
  }
} 
