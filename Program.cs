using System;

namespace MiPrimerPrograma
{
    class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE GESTIÓN ===\n");
        
       
        Console.WriteLine("--- CLIENTES ---");
        Cliente cliente1 = new Cliente("Juan Pérez", "juan@email.com", "999888777");
        Cliente cliente2 = new Cliente("María López", "maria@email.com", "888777666");
        
        cliente1.MostrarInfo();
        cliente2.MostrarInfo();
        Console.WriteLine();
        
     
        Console.WriteLine("--- EMPLEADOS ---");
        Empleado empleado1 = new Empleado("Carlos Ruiz", "Gerente", 3500.00);
        Empleado empleado2 = new Empleado("Ana Torres", "Desarrolladora", 2800.00);
        
        empleado1.MostrarInfo();
        empleado2.MostrarInfo();
        Console.WriteLine();
        
   
        Console.WriteLine("--- CÁLCULO DE BONOS ---");
        empleado1.CalcularBono(15);
        Console.WriteLine();
        empleado2.CalcularBono(10);
        Console.WriteLine();

        Console.WriteLine("--- LISTA DE PRODUCTOS ---");
        
 
        List<Producto> productos = new List<Producto>();
        
    
        productos.Add(new Producto("Laptop", 1500.50m, 10));
        productos.Add(new Producto("Mouse", 25.99m, 50));
        productos.Add(new Producto("Teclado", 89.99m, 25));
        productos.Add(new Producto("Monitor", 350.00m, 8));
        productos.Add(new Producto("Audífonos", 45.00m, 30));
        
      
        Console.WriteLine("Inventario completo:");
        foreach (Producto producto in productos)
        {
            producto.MostrarInfo();
        }
        Console.WriteLine();
        
     
        Console.WriteLine("--- ACTUALIZACIÓN DE STOCK ---");
        
      
        productos[0].ActualizarStock(5);
        
    
        productos[1].ActualizarStock(-10);
        
        Console.WriteLine();
        
       
        Console.WriteLine("Inventario después de actualizar:");
        foreach (Producto producto in productos)
        {
            producto.MostrarInfo();
        }
    }
}
    


}