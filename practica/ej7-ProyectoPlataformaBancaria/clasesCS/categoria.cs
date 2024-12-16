using System;
using System.Collections.Generic;
using System.Linq;
using DatosPersonas.Modelos;
using FuncionDeTransacciones.Modelos;

namespace PresupuestoDeCategorias.modelos{
    public class GestorDePresupuestos{
        private List<PresupuestoMensual> presupuesto;
            public GestorDePresupuestos(){
                presupuesto = new List<PresupuestoMensual>();
            }
        
            public void AgregarPresupuesto(string categoria, decimal limite){
                presupuesto.Add(new PresupuestoMensual(categoria, limite));
            }
            public void AgregarGastos(string categoria, decimal monto){
                var pres = presupuesto.FirstOrDefault(p => p.Categoria == categoria);
                if (pres != null){
                    pres.AgregarGasto(monto);
                        if(pres.EstaCercaDelLimite()){
                            Console.WriteLine($"El presupuesto de {categoria} está cerca del limite");
                        }else if (pres.ExeceElLimite()){
                            Console.WriteLine($"Se excedio el limite de la categoria: {categoria}");
                        }else{
                            Console.WriteLine("Categoria no encontrada");
                        }
                }
            }
    }
}
