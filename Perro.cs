class Perro : Animal
{
    public string Raza { get; set; }

    public Perro(string nombre, int edad, string raza)
        : base(nombre, edad)
    {
        Raza = raza;
    }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} dice: Guau Guau!");
    }
}
