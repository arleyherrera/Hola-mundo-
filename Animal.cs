class Animal
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Animal(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public virtual void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace un sonido");
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Animal: {Nombre}, Edad: {Edad} años");
    }
}
