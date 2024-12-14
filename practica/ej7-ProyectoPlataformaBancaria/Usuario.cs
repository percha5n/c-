using System;
using System.Collections.Generic;
using System.Linq;

namespace DatosPersonas.Modelos
{
    public class DatosPersonales
{
    public string Nombre {get;set;}
    public string Apellido {get;set;}
    public string Direccion {get;set;}
    public string Telefono {get;set;}
    public string Correo {get;set;}
    public int Edad {get;set;}

    public DatosPersonales(string nombre, string apellido, string direccion, string telefono, string correo, int edad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Direccion = direccion;
        Telefono = telefono;
        Correo = correo;
        Edad = edad;
        
    }

    public DatosPersonales()
    {
        Nombre = "";
        Apellido = "";
        Direccion = "";
        Telefono = "";
        Correo = "";
        Edad = 0;

    }
}

public class DatosDeTransaccion
{
    public int Ingresos {get;set;}
    public int Gastos {get;set;}
    public int MontoEspecifico {get;set;}
    public string Fecha {get;set;}
    public string Categoria {get;set;}
    public string Descripcion {get;set;}

    public DatosDeTransaccion(int ingresos, int gastos, int montoEspecifico, string fecha, string categoria, string descripcion)
    {
        Ingresos = ingresos;
        Gastos = gastos;
        MontoEspecifico = montoEspecifico;
        Fecha = fecha;
        Categoria = categoria;
        Descripcion = descripcion;
    }

    public DatosDeTransaccion()
    {
        Ingresos = 0;
        Gastos = 0;
        MontoEspecifico = 0;
        Fecha = "";
        Categoria = "";
        Descripcion = "";
    }
}
}


