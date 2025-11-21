class Gerente:Empleado
{
    
    public double Bono { get; set; }

    
    public Gerente(string nombre, double sueldo, double bono)
        : base(nombre, "Gerente", sueldo)
    {
        Bono = bono;

        List<Empleado> equipo = new List<Empleado>();
        equipo.Add(new Empleado("Juan", "Desarrollador", 3000));
        equipo.Add(new Gerente("Ana", 3200, 1000));

        foreach (Empleado emp in equipo)
        {
            emp.MostrarInfo();
        }       



    }

    
    public override void MostrarInfo()
    {
        Console.WriteLine($"Gerente: {Nombre}, Sueldo: {Sueldo}, Bono: {Bono}");
    }
}