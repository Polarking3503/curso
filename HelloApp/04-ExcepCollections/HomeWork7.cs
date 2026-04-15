partial class Program
{
    static void SalesAnalysis()
    {
        List<Sale> sales = [
            new Sale("Laptop", "Electrónica", 1500),
            new Sale("Teléfono", "Electrónica", 900),
            new Sale("Silla", "Muebles", 1200),
            new Sale("Escritorio", "Muebles", 800),
            new Sale("Tablet", "Electrónica", 1300),
            new Sale("Lámpara", "Iluminación", 400)
        ];

        try
        {
            // 1. Filtrar y mostrar las ventas con monto superior a 1000.
            var highSales = sales.Where(sale => sale.Amount > 1000);
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Ventas con monto superior a 1000:");
            ResetColor();
            foreach (var sale in highSales)
            {
                WriteLine($"Producto: {sale.Product}, Categoría: {sale.Category}, Monto: {sale.Amount:C}");
            }

            var salesByCategory = sales.GroupBy(sale => sale.Category)
                                       .Select(group => new { Category = group.Key, Total = group.Sum(sale => sale.Amount) });
            
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("\nTotal de ventas por categoría:");
            ResetColor();
            foreach (var category in salesByCategory)
            {
                WriteLine($"Categoría: {category.Category}, Total de Ventas: {category.Total:C}");
            }

        }
        catch (Exception e)
        {
            WriteLine($"Error al procesar las ventas: {e.Message}");
        }
    }
}

class Sale
{
    public string? Product { get; set; }
    public string? Category { get; set; }
    public double Amount { get; set; }

    public Sale(string product, string category, double amount)
    {
        Product = product;
        Category = category;
        Amount = amount;
    }
}