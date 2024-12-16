using System;
using System.Collections.Generic;
using System.Linq;
using DatosPersonas.Modelos;
using FuncionDeTransacciones.Modelos;
using PresupuestoDeCategorias.modelos;
class Program{
    static void Main(string[] args){
        HacerTransaccionFinanciera gestorTransacciones = new HacerTransaccionFinanciera();
        GestorDePresupuestos gestorPresupuestos = new GestorDePresupuestos();

        int opcion;
        do
        {
            Console.WriteLine("----- Menu -----");
            Console.WriteLine("1. Imprimir Usuarios");
            Console.WriteLine("2. Hacer Transacción");
            Console.WriteLine("3. Mostrar Transacciones");
            Console.WriteLine("4. Buscar Transacción por Fecha");
            Console.WriteLine("5. Buscar por Categoría");
            Console.WriteLine("6. Buscar por Monto");
            Console.WriteLine("7. Agregar presupuesto");
            Console.WriteLine("8. Agregar Monto");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");            
            if (int.TryParse(Console.ReadLine(), out opcion)){
                switch (opcion){
                    case 1:
                        gestorTransacciones.ImprimirUsuarios();
                        break;
                    case 2:
                        Console.Write("Ingrese el ID del usuario: ");
                        int userId = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el monto: ");
                        float monto = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el tipo de transacción (deposito/retiro): ");
                        string tipo = Console.ReadLine();
                        Console.Write("Ingrese la fecha (YYYY-MM-DD): ");
                        string fecha = Console.ReadLine();
                        Console.Write("Ingrese la categoría: ");
                        string categoria = Console.ReadLine();
                        Console.Write("Ingrese la descripción: ");
                        string descripcion = Console.ReadLine();

                        gestorTransacciones.HacerTransaccion(userId, monto, tipo, fecha, categoria, descripcion);
                        break;
                    case 3:
                        gestorTransacciones.MostrarTransacciones();
                        break;
                    case 4:
                        gestorTransacciones.BuscarTransaccionPorFecha();
                        break;
                    case 5:
                        gestorTransacciones.BuscarPorCategoria();
                        break;
                    case 6:
                        gestorTransacciones.BuscarPorMonto();
                        break;
                    case 7:
                        //agregar funcion
                    break;
                    case 8:
                        //agregar funcion 
                    break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no valida. Intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }

            Console.WriteLine();
        } while (opcion != 0);
    }
}