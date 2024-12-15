using System;
using System.Collections.Generic;
using System.Linq;
using DatosPersonas.Modelos;
using FuncionDeTransacciones.Modelos;
class Program{
    static void Main(string[] args){
        // crear una instancia de HacerTransaccionFinanciera
        HacerTransaccionFinanciera gestorTransacciones = new HacerTransaccionFinanciera();

        gestorTransacciones.ImprimirUsuarios();

        // hacer algunas transacciones
        gestorTransacciones.HacerTransaccion(0,  100.50f, "deposito", "2023-10-01", "Salario", "Pago mensual de salario");
        gestorTransacciones.HacerTransaccion(1, 50.00f, "retiro", "2023-10-02", "Comida", "Compra de supermercado");

        gestorTransacciones.MostrarTransacciones();

        //gestorTransacciones.BuscarTransaccionPorFecha();
        //gestorTransacciones.BuscarPorCategoria();
        gestorTransacciones.BuscarPorMonto();
    }
}