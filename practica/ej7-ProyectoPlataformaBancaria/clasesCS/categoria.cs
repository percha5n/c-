using System;
using System.Collections.Generic;
using System.Linq;
using DatosPersonas.Modelos;
using FuncionDeTransacciones.Modelos;

namespace PresupuestoDeCategorias{
    public class PresupuestoDeCategorias{
        private List<DatosPersonales> usuarios;
        private List<DatosDeTransaccion> transacciones;
            public void DefinirPresupuesto(){
                Console.WriteLine("ingrese el monto que desea definir como presupuesto");
            }
    }
}
