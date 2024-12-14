using System;
 // 2 formas de usar los getter y setters
public class Persona
{
    private string _nombre;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    // Constructor
    public Persona(string nombre)
    {
        _nombre = nombre;
    }
}

public class Persona2
{
    public string persona2 { get; set; }
    public int num { get; set; }

    // Constructor
    public Persona2(string persona2)
    {
        this.persona2 = persona2;
        this.num = 0; 
    }
}

class Programa
{
    static void Main()
    {
        // Instanciando las clases
        Persona persona = new Persona("Juan");
        Persona2 persona2 = new Persona2("Juan2");
        int num = 100;

        // Imprimiendo los valores
        Console.WriteLine(persona.Nombre + " " + persona2.persona2 + " " + num);
    }
}
