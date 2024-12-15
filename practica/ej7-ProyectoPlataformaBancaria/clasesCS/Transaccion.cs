using System;
using System.Collections.Generic;
using System.Linq;
using DatosPersonas.Modelos;

namespace FuncionDeTransacciones.Modelos{
    public class HacerTransaccionFinanciera{
        private List<DatosPersonales> usuarios;
        private List<DatosDeTransaccion> transacciones;

        public HacerTransaccionFinanciera(){
            usuarios = new List<DatosPersonales>();
            transacciones = new List<DatosDeTransaccion>();

            //ej de usuarios
            usuarios.Add(new DatosPersonales("Juan", "Perez", "Calle Falsa 123", "123456789", "juan@example.com", 30, "Arentina", "43556867"));
            usuarios.Add(new DatosPersonales("Ana", "Gomez", "Avenida Siempre Viva 742", "987654321", "ana@example.com", 25, "Argentino", "12345678"));
        }

        public void HacerTransaccion(int idUsuario, float monto, string tipoTrans, string fechaTrans, string categoria, string descripcion){
            if (monto <= 0){
                Console.WriteLine("El monto debe ser positivo.");
                return;
            }

            if (tipoTrans != "deposito" && tipoTrans != "retiro"){
                Console.WriteLine("Tipo de transacción no válido. Debe ser 'deposito' o 'retiro'.");
                return;
            }

            DatosPersonales usuario = BuscarUsuario(idUsuario);
            if (usuario != null){
                // crear una nueva transacción
                DatosDeTransaccion transaccion = new DatosDeTransaccion{
                    MontoEspecifico = monto,
                    Fecha = fechaTrans,
                    Categoria = categoria,
                    Descripcion = descripcion,
                    IdTransaccion = Guid.NewGuid().ToString(), // Generar un ID único para la transacción
                    Estado = "Completada" // Estado inicial de la transacción
                };

                // agregar la transacción a la lista
                transacciones.Add(transaccion);
                Console.WriteLine("Transaccion realizada con exito.");
            }else{
                Console.WriteLine("No se encontro el usuario.");
            }
        }

        private DatosPersonales BuscarUsuario(int idUsuario){
            if (idUsuario >= 0 && idUsuario < usuarios.Count){
                return usuarios[idUsuario];
            }
            return null;
        }

        public void BuscarTransaccionPorFecha(){
        Console.WriteLine("Ingrese una fecha a buscar (formato: YYYY-MM-DD):");
        string fechaBuscada = Console.ReadLine();
        var transaccionesEncontradas = transacciones.Where(t => t.Fecha == fechaBuscada).ToList();
            if (transaccionesEncontradas.Count > 0){
                Console.WriteLine("Transacciones encontradas en la fecha ingresada:");
                    foreach (var transaccion in transaccionesEncontradas){
                        Console.WriteLine($"ID: {transaccion.IdTransaccion}, Monto: {transaccion.MontoEspecifico}, Fecha: {transaccion.Fecha}, " +
                              $"Categoria: {transaccion.Categoria}, Descripcion: {transaccion.Descripcion}, Estado: {transaccion.Estado}");
                    }
            }else{
                Console.WriteLine("No se encontraron transacciones en la fecha ingresada.");
            }
        }

        public void BuscarPorCategoria(){
            Console.WriteLine("Ingrese una categoria a buscar:");
            string categoriaBuscada = Console.ReadLine();
            var transaccionesEncontradas = transacciones.Where(t => t.Categoria == categoriaBuscada).ToList();
            if (transaccionesEncontradas.Count > 0){
                Console.WriteLine("Transacciones encontradas en la categoria ingresada:");
                    foreach (var transaccion in transaccionesEncontradas){
                        Console.WriteLine($"ID: {transaccion.IdTransaccion}, Monto: {transaccion.MontoEspecifico}, Fecha: {transaccion.Fecha}, " +
                              $"Categoria: {transaccion.Categoria}, Descripcion: {transaccion.Descripcion}, Estado: {transaccion.Estado}");
                    }
            }else{
                Console.WriteLine("No se encontraron transacciones en la categoria ingresada.");
            }
        }

        public void BuscarPorMonto(){
            Console.WriteLine("Ingrese un monto a buscar:");
            float montoBuscado;
            if(!float.TryParse(Console.ReadLine(), out montoBuscado)){
                Console.WriteLine("Ingrese un monto valido.");
                return;
            }
            var montoEncontrado = transacciones.Where(t => t.MontoEspecifico == montoBuscado).ToList();
                    /*el .Count es una forma de saber la cantidad de elementos que tiene una
                    collecion */
                if(montoEncontrado.Count > 0){
                    Console.WriteLine("Transacciones encontradas en el monto ingresado:");
                        foreach (var transaccion in montoEncontrado){
                            Console.WriteLine($"ID: {transaccion.IdTransaccion}, Monto: {transaccion.MontoEspecifico}, Fecha: {transaccion.Fecha}, " +
                              $"Categoria: {transaccion.Categoria}, Descripcion: {transaccion.Descripcion}, Estado: {transaccion.Estado}");
                        }
                }else{
                    Console.WriteLine("No se encontraron transacciones en el monto ingresado.");
                }
        }
    
        public void MostrarTransacciones(){
        Console.WriteLine("Historial de Transacciones:");
            foreach (var transaccion in transacciones){
                Console.WriteLine($"ID: {transaccion.IdTransaccion}, Monto: {transaccion.MontoEspecifico}, Fecha: {transaccion.Fecha}, " +
                              $"Categoria: {transaccion.Categoria}, Descripcion: {transaccion.Descripcion}, Estado: {transaccion.Estado}");
            }
        }

        public void ImprimirUsuarios(){
        Console.WriteLine("Lista de Usuarios:");
            foreach (var usuario in usuarios){
                Console.WriteLine($"Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, Direccion: {usuario.Direccion}, " +
                                $"Telefono: {usuario.Telefono}, Correo: {usuario.Correo}, Edad: {usuario.Edad}," + 
                                $"Nacionalidad: {usuario.Nacionalidad}, DNI: {usuario.Dni}");
            }
        }
    }

}
