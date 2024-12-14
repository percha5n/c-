/*Diseña un programa en C# que simule un sistema de ventas. El programa debe permitir realizar las siguientes tareas:

Registrar productos: El sistema debe permitir registrar productos en el inventario con el nombre, precio y cantidad disponible.
Mostrar inventario: Debe poder mostrar una lista de todos los productos registrados en el inventario con sus detalles (nombre, precio y cantidad disponible).
Realizar una venta: El sistema debe permitir realizar una venta. Al hacer una venta, debe preguntar qué producto se desea comprar, la cantidad y realizar el cálculo del total a pagar. Si no hay suficiente stock, debe mostrar un mensaje de error.
Actualizar inventario: Después de una venta exitosa, el sistema debe actualizar la cantidad disponible del producto en el inventario.
Calcular el total de la venta: Después de una venta, se debe mostrar el total de la compra y el saldo disponible.
Opción para salir: El sistema debe permitir salir de manera segura.*/


using System;
using System.Collections.Generic;
using System.Linq;

public class Producto
{
    public string Nombre { get; set; }
    public float Precio { get; set; }
    public int CantDisponible { get; set; }
  
    public Producto()
    {
        Nombre = "sin nombre";
        Precio = 0;
        CantDisponible = 0;
    }

    public Producto(string nombre, float precio, int cantDisponible)
    {
        Nombre = nombre;
        Precio = precio;
        CantDisponible = cantDisponible;
    }
  
    public override string ToString()
    {
        return $"Producto: {Nombre}, Precio ${Precio}, Disponible: {CantDisponible}";
    }
}

public class SistemaDeVentas
{
    private List<Producto> Inventario { get; set; }

    public SistemaDeVentas()
    {
        Inventario = new List<Producto>
        {
            new Producto("producto 1", 10.50f, 44),
            new Producto("producto 2", 550.66f, 57),
            new Producto("producto 3", 15500.70f, 80),
            new Producto("producto 4", 50800.44f, 16),
            new Producto("producto 5", 70000f, 67)
        };
    }

    public void MostrarInventarioActual()
    {
        Console.WriteLine("--- Inventario Actual ---");
        Console.WriteLine("------------------------");

        foreach(var producto in Inventario)
        {
            Console.WriteLine(producto);
        }
    }
  
    public void AgregarProducto()
    {
        Console.WriteLine("Ingrese el nombre del producto:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el precio:");
        float precio = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad disponible:");
        int cantDisponible = int.Parse(Console.ReadLine());

        Inventario.Add(new Producto(nombre, precio, cantDisponible));
        Console.WriteLine($"Producto {nombre} fue agregado con éxito");
    }

    public Producto BuscarProducto(string nombre)
    {
        return Inventario.FirstOrDefault(p => p.Nombre.ToLower() == nombre.ToLower());
    }

    public void EliminarProducto()
    {
        Console.WriteLine("Ingrese el nombre del producto a eliminar:");
        string nombre = Console.ReadLine();
        var producto = BuscarProducto(nombre);
        if(producto != null)
        {
            Inventario.Remove(producto);
            Console.WriteLine($"Producto {nombre} fue eliminado con éxito");
        }
        else
        {
            Console.WriteLine($"No se encontró el producto {nombre}");
        }
    }

    public void ModificarPrecio()
    {
        Console.WriteLine("Ingrese el nombre del producto:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el nuevo precio:");
        float nuevoPrecio = float.Parse(Console.ReadLine());

        var producto = BuscarProducto(nombre);
        if(producto != null)
        {
            producto.Precio = nuevoPrecio;
            Console.WriteLine($"El precio del producto {nombre} fue modificado con éxito");
        }
        else
        {
            Console.WriteLine($"No se encontró el producto {nombre}");
        }
    }

    public void VenderUnProducto()
    {
        Console.WriteLine("Ingrese el nombre del producto que desea vender:");
        string nombre = Console.ReadLine();
        var producto = BuscarProducto(nombre);
        if(producto != null)
        {
            if(producto.CantDisponible > 0)
            {
                producto.CantDisponible--;
                Console.WriteLine($"Se vendio un producto {nombre} con exito");
                Console.WriteLine($"Precio total: ${producto.Precio}");
            }
            else
            {
                Console.WriteLine($"No hay productos {nombre} disponibles");
            }
        }
        else
        {
            Console.WriteLine($"Producto {nombre} no encontrado");
        }
    }

    public void VenderVariosProductos()
    {
        Console.WriteLine("Ingrese el nombre del producto que desea vender:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad de productos que desea vender:");
        int cantidad = int.Parse(Console.ReadLine());
        
        var producto = BuscarProducto(nombre);
        if(producto != null)
        {
            if(producto.CantDisponible >= cantidad)
            {
                producto.CantDisponible -= cantidad;
                float totalVenta = producto.Precio * cantidad;
                Console.WriteLine($"Se vendieron {cantidad} productos {nombre} con éxito");
                Console.WriteLine($"Precio total: ${totalVenta}");
            }
            else
            {
                Console.WriteLine($"No hay suficientes productos {nombre} disponibles");
            }
        }
        else
        {
            Console.WriteLine($"Producto {nombre} no encontrado");
        }
    }

    public void ReponerStock()
    {
        Console.WriteLine("Ingrese el nombre del producto que desea reponer:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad de productos que desea reponer:");
        int cantidad = int.Parse(Console.ReadLine());
        
        var producto = BuscarProducto(nombre);
        if(producto != null)
        {
            producto.CantDisponible += cantidad;
            Console.WriteLine($"Se repuso el stock de {nombre} con éxito");
        }
        else
        {
            Console.WriteLine($"No se encontró el producto {nombre}");
        }
    }

    public void MenuPrincipal()
    {
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\nMenú Principal");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Modificar precio");
            Console.WriteLine("4. Mostrar inventario");
            Console.WriteLine("5. Vender un producto");
            Console.WriteLine("6. Vender varios productos");
            Console.WriteLine("7. Reponer stock");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Ingrese la opción que desea realizar:");
            
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Intente nuevamente.");
                continue;
            }

            switch(opcion)
            {
                case 1:
                    AgregarProducto();
                    break;
                case 2:
                    EliminarProducto();
                    break;
                case 3:
                    ModificarPrecio();
                    break;
                case 4:
                    MostrarInventarioActual();
                    break;
                case 5:
                    VenderUnProducto();
                    break;
                case 6:
                    VenderVariosProductos();
                    break;
                case 7:
                    ReponerStock();
                    break;
                case 0:
                    salir = true;
                    Console.WriteLine("Gracias por utilizar el sistema");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}

public class ModuloPrincipalSistemaDeVentas
{
    static void Main(string[] args)
    {
        SistemaDeVentas sistema = new SistemaDeVentas();
        sistema.MenuPrincipal();
    }
}