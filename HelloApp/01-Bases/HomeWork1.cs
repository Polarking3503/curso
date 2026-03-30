partial class Program
{
    static void SaleReport()
    {
        string producto = "Laptop";
        int quantitySold = 3;
        double unitPrice = 750.99;
        double totalAmount = quantitySold * unitPrice;

        Console.WriteLine($"Producto: {producto}");
        Console.WriteLine($"Cantidad vendida: {quantitySold}");
        Console.WriteLine($"Precio unitario: {unitPrice:C}");
        Console.WriteLine($"Monto total: {totalAmount:C}");
    }
}