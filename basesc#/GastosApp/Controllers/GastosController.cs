using Microsoft.AspNetCore.Mvc;
using Espacio1.Models;

public class GastosController : Controller
{
    private readonly GastosService _gastosServicio;

    // Constructor
    public GastosController(){
        _gastosServicio = new GastosService(); // Asegurate de que el nombre del servicio sea correcto
    }
    // Acción para mostrar el formulario de creación
    [HttpGet]
    public IActionResult Create(){
        return View(new Gasto()); // Devuelve una nueva instancia de Gasto para el formulario
    }

    // Acción para manejar el envío del formulario
    [HttpPost]
    public IActionResult Create(Gasto gasto)
    {
        if (ModelState.IsValid) // Verifica si el modelo es válido
        {
            _gastosServicio.AgregarGastos(gasto);
            return RedirectToAction("Index"); // Redirige a la lista de gastos
        }
        return View(gasto); // Si no es válido, vuelve a mostrar el formulario con los datos ingresados
    }
}