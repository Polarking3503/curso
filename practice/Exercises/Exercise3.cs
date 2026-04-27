// 🛠️ El Reto: "El Gestor de Refacciones Wolfrec"
// Objetivo: Crear un pequeño programa de consola que gestione las piezas que usas para reparar compus (como SSDs, RAMs, etc.).
// 📋 Instrucciones:
// Crea la Clase Refaccion:
// Debe tener tres propiedades: Nombre (texto), Precio (decimal) y CantidadEnStock (número entero).
// Crea un Método llamado Vender:
// Este método debe recibir un número (cuántas piezas vas a vender).
// Lógica: Si hay suficientes piezas, réstalas del stock y manda un mensaje: "Venta exitosa de [Nombre]".
// Lógica Pro: Si NO hay suficientes, manda un mensaje: "Error: No hay stock suficiente para [Nombre]".
// En el Método Main:
// Crea (instancia con new) al menos dos objetos de tipo Refaccion.
// Ejemplo: Un "SSD 500GB" y una "Memoria RAM 8GB".
// Ponles precios y cantidades iniciales.
// Llama al método Vender para cada uno (intenta vender más de lo que tienes en uno para probar tu lógica).

partial class Program
{
    static void Sales()
    {
        List<Refaccion> vender = [
            new Refaccion("Bocinas MacBook", 1500, 3),
            new Refaccion("Disco Duro", 900, 10),
            new Refaccion("Memoria Ram 8GB", 800, 4),
            new Refaccion("TrackPad", 1300, 4),
            new Refaccion("Teclado", 400, 4)
        ];

        Console.WriteLine("--- Stock Inicial ---");
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var refaccion in vender)
        {
            Console.WriteLine($"Producto: {refaccion.Nombre}, Precio: {refaccion.Precio}, Stock: {refaccion.CantidadEnStock}");
        }
        ResetColor();
        Console.WriteLine("\n--- Ventas ---");
        vender[0].Vender(2);
        vender[0].Vender(5);
        vender[1].Vender(4);
        vender[2].Vender(10);
    }
}

class Refaccion
{
    public string? Nombre { get; set; }
    public double Precio { get; set; }
    public int CantidadEnStock { get; set; }

    public Refaccion(string nombre, double precio, int cantidadEnStock)
    {
        Nombre = nombre;
        Precio = precio;
        CantidadEnStock = cantidadEnStock;
    }

    public void Vender(int cantidad)
    {
        if (cantidad <= CantidadEnStock)
        {
            CantidadEnStock -= cantidad;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Venta exitosa de {Nombre}. Stock restante: {CantidadEnStock}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"No hay stock suficiente para {Nombre}. Stock actual: {CantidadEnStock}");
        }
    }
}