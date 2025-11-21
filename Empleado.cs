class Empleado
{
  
    public string Nombre { get; set; }
    public string Cargo { get; set; }
    public double Sueldo { get; set; }
    
   
    public Empleado(string nombre, string cargo, double sueldo)
    {
        Nombre = nombre;
        Cargo = cargo;
        Sueldo = sueldo;
    }
    
    
    public void CalcularBono(double porcentaje)
    {
        double bono = Sueldo * (porcentaje / 100);
        double sueldoTotal = Sueldo + bono;
        
        Console.WriteLine("Empleado: " + Nombre);
        Console.WriteLine("Sueldo base: S/." + Sueldo);
        Console.WriteLine("Bono (" + porcentaje + "%): S/." + bono);
        Console.WriteLine("Sueldo total: S/." + sueldoTotal);
    }
    

    public virtual void MostrarInfo()
    {
        Console.WriteLine("Empleado: " + Nombre + ", Cargo: " + Cargo + ", Sueldo: $" + Sueldo);
    }
}