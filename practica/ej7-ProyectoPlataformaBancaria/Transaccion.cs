using System;
using System.Collections.Generic;
using System.Linq;
using DatosPersonas.Modelos;

public class HacerTransaccionFinanciera
{
    private List<DatosPersonales> usuarios;
    private List<DatosDeTransaccion> transacciones;

    public HacerTransaccionFinanciera()
    {
        usuarios = new List<DatosPersonales>();
        transacciones = new List<DatosDeTransaccion>();

        // Agregar algunos usuarios de ejemplo
        usuarios.Add(new DatosPersonales("Juan", "Pérez", "Calle Falsa 123", "123456789", "juan@example.com", 30));
        usuarios.Add(new DatosPersonales("Ana", "Gómez", "Avenida Siempre Viva 742", "987654321", "ana@example.com", 25));
    }

    public void HacerTransaccion(int idUsuario, float monto, string tipoTrans, string fechaTrans, string categoria, string descripcion)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El monto debe ser positivo.");
            return;
        }

        if (tipoTrans != "deposito" && tipoTrans != "retiro")
        {
            Console.WriteLine("Tipo de transacción no válido. Debe ser 'deposito' o 'retiro'.");
            return;
        }

        DatosPersonales usuario = BuscarUsuario(idUsuario);
        if (usuario != null)
        {
            // crear una nueva transacción
            DatosDeTransaccion transaccion = new DatosDeTransaccion
            {
                MontoEspecifico = monto,
                Fecha = fechaTrans,
                Categoria = categoria,
                Descripcion = descripcion,
                IdTransaccion = Guid.NewGuid().ToString(), // Generar un ID único para la transacción
                Estado = "Completada" // Estado inicial de la transacción
            };

            // agregar la transacción a la lista
            transacciones.Add(transaccion);
            Console.WriteLine("Transacción realizada con éxito.");
        }
        else
        {
            Console.WriteLine("No se encontró el usuario.");
        }
    }

    private DatosPersonales BuscarUsuario(int idUsuario)
    {
        if (idUsuario >= 0 && idUsuario < usuarios.Count)
        {
            return usuarios[idUsuario];
        }
        return null;
    }

    public void MostrarTransacciones()
    {
        Console.WriteLine("Historial de Transacciones:");
        foreach (var transaccion in transacciones)
        {
            Console.WriteLine($"ID: {transaccion.IdTransaccion}, Monto: {transaccion.MontoEspecifico}, Fecha: {transaccion.Fecha}, " +
                              $"Categoría: {transaccion.Categoria}, Descripción: {transaccion.Descripcion}, Estado: {transaccion.Estado}");
        }
    }

    public void ImprimirUsuarios()
    {
        Console.WriteLine("Lista de Usuarios:");
        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, Dirección: {usuario.Direccion}, " +
                              $"Teléfono: {usuario.Telefono}, Correo: {usuario.Correo}, Edad: {usuario.Edad}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // crear una instancia de HacerTransaccionFinanciera
        HacerTransaccionFinanciera gestorTransacciones = new HacerTransaccionFinanciera();

        gestorTransacciones.ImprimirUsuarios();

        // hacer algunas transacciones
        gestorTransacciones.HacerTransaccion(0,  100.50f, "deposito", "2023-10-01", "Salario", "Pago mensual de salario");
        gestorTransacciones.HacerTransaccion(1, 50.00f, "retiro", "2023-10-02", "Comida", "Compra de supermercado");

        gestorTransacciones.MostrarTransacciones();
    }
}