using System.Collections.Generic; //Proporciona clases y interfaces para colecciones genéricas. Esto incluye listas, diccionarios, colas, pilas, etc
using System.IO; //incluye clases para trabajar con el sistema de archivos y flujos de datos.
using System.Text.Json; //Proporciona herramientas para trabajar con datos en formato JSON, incluyendo serialización y deserializaciones
using System.Linq; //Permite realizar consultas a colecciones en memoria (como listas, arreglos, etc.) utilizando LINQ
using Espacio1.Models;

public class GastosService{
    private readonly string _rutaDelArchivo = "../Data/gastos.json";

    //metodo que obtiene la lista de gastos
    public List<Gasto> ObtenerGastos(){
        if (!File.Exists(_rutaDelArchivo)){
            return new List<Gasto>();
        }
        var json = File.ReadAllText(_rutaDelArchivo);
        var gastos = JsonSerializer.Deserialize<List<Gasto>>(json) ?? new List<Gasto>();
        return gastos;
    }

    //un metodo para agregar un nuevo gasto
    public void AgregarGastos(GastosService gasto){
        var gastos = ObtenerGastos();
        gasto.Id = gastos.Count > 0 ? gastos.Last().Id + 1 : 1; //se agrega un nuevo id
        gastos.Add(gasto);
        File.WriteAllText(_rutaDelArchivo, JsonSerializer.Serialize(gastos)); //se serializa la lista de gastos y la guarda en el archivo
    }
}