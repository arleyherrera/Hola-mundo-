class Producto
{
    
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    

    public Producto(string nombre, decimal precio, int stock)
    {
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }
    
 
    public void MostrarInfo()
    {
        Console.WriteLine("Producto: " + Nombre + ", Precio: S/." + Precio + ", Stock: " + Stock);
    }
    

    public void ActualizarStock(int cantidad)
    {
        Stock = Stock + cantidad;
        
        if (cantidad > 0)
        {
            Console.WriteLine("Se agregaron " + cantidad + " unidades. Nuevo stock: " + Stock);
        }
        else
        {
            Console.WriteLine("Se retiraron " + Math.Abs(cantidad) + " unidades. Nuevo stock: " + Stock);
        }
    }
}