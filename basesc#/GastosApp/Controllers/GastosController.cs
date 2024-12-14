using Microsoft.AspNetCore.Mvc;
using Espacio1.Models;

public class GastosController : Controller
{
    private readonly GastosService _gastosServicio;

    // Constructor
    public GastosController(){
        _gastosServicio = new GastosService(); 
    }

    [HttpGet]
    public IActionResult Create(){
        return View(new Gasto()); 
    }

    [HttpPost]
    public IActionResult Create(Gasto gasto)
    {
        if (ModelState.IsValid) 
        {
            _gastosServicio.AgregarGastos(gasto);
            return RedirectToAction("Index");
        }
        return View(gasto); 
    }
}