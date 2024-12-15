using System;
using System.Collections.Generic;
using System.Linq;

namespace DatosPersonas.Modelos
{
    public class DatosPersonales
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Dni{get;set;}

        public DatosPersonales(string nombre, string apellido, string direccion, string telefono, string correo, int edad, string nacionalidad, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
            Edad = edad;
            Nacionalidad = nacionalidad;
            Dni = dni;
        }

        public DatosPersonales()
        {
            Nombre = "";
            Apellido = "";
            Direccion = "";
            Telefono = "";
            Correo = "";
            Edad = 0;
            Nacionalidad = "";
            Dni = "";
        }
    }

    public class DatosDeTransaccion
    {
        public int Ingresos { get; set; }
        public int Gastos { get; set; }
        public float MontoEspecifico { get; set; }
        public string Fecha { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string IdTransaccion { get; set; }
        public string CuentaOrigen { get; set; }
        public string CuentaDestino { get; set; }
        public string MetodoDePago { get; set; }
        public string Estado { get; set; }

        public DatosDeTransaccion(int ingresos, int gastos, float montoEspecifico, string fecha, string categoria, string descripcion, string idTransaccion,
            string cuentaOrigen, string cuentaDestino, string metodoDePago, string estado)
        {
            Ingresos = ingresos;
            Gastos = gastos;
            MontoEspecifico = montoEspecifico;
            Fecha = fecha;
            Categoria = categoria;
            Descripcion = descripcion;
            IdTransaccion = idTransaccion; 
            CuentaOrigen = cuentaOrigen;
            CuentaDestino = cuentaDestino;
            MetodoDePago = metodoDePago;
            Estado = estado;
        }

        public DatosDeTransaccion()
        {
            Ingresos = 0;
            Gastos = 0;
            MontoEspecifico = 0;
            Fecha = "";
            Categoria = "";
            Descripcion = "";
            IdTransaccion = "";
            CuentaOrigen = "";
            CuentaDestino = "";
            MetodoDePago = "";
            Estado = "";
        }
    }
}