    // - Mostrar el inventario actualizado después de cada compra. 
    // - Crear un menu con las opciones de 1. Comprar producto y 2. Salir.
partial class Program
{
    static void InventoryManager()
    {
        string[] products = ["Monitor", "Mouse", "Teclado"];
        int[] stock = [10, 25, 40];
        double[] prices = [250.50, 20.50, 45.00];

        string option;
        do
        {
            Console.WriteLine("--- MENÚ DE OPCIONES ---");
            Console.WriteLine("1. Comprar producto");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");

            option = Console.ReadLine()!;

            switch (option)
            {
                case "1":
                    Console.WriteLine("Inventario de Productos");
                    Console.WriteLine("-----------------------");

                    for (int i = 0; i < products.Length; i++)
                    {
                        Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]:C}");
                    }

                    Console.WriteLine("\nIngrese el producto que desea comprar: ");
                    string? searchProduct = Console.ReadLine();

                    Console.WriteLine("\nIngrese la cantidad que desea comprar: ");
                    int quantity = int.Parse(Console.ReadLine()!);

                    for (int i = 0; i < products.Length; i++)
                    {
                        if (products[i].Equals(searchProduct, StringComparison.OrdinalIgnoreCase))
                        {
                            if (quantity <= stock[i])
                            {
                                double total = quantity * prices[i];
                                Console.WriteLine($"Compra exitosa!. Total a pagar: {total:C}");

                                stock[i] -= quantity;
                                Console.WriteLine($"Stock restante para el producto {products[i]} es de: {stock[i]}");
                            }
                            else
                            {
                                Console.WriteLine("No hay suficiente stock disponible");
                            }
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("Gracias por su visita.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (option != "2");
    }
}