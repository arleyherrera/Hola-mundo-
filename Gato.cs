class Gato : Animal
{
    public string Color { get; set; }

    public Gato(string nombre, int edad, string color)
        : base(nombre, edad)
    {
        Color = color;
    }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} dice: Miau Miau!");
    }
}
