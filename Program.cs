using System;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main()
        {
           
            Perro perro1 = new Perro("Moztaza", 1, "Labrador");
            Perro perro2 = new Perro("Carlos", 3, "Pastor Alemán");
            Gato gato1 = new Gato("Frida", 1, "Naranja");
            Gato gato2 = new Gato("Blanca", 2, "Blanco");

    
            perro1.MostrarInfo();
            perro1.HacerSonido();
            Console.WriteLine();

            perro2.MostrarInfo();
            perro2.HacerSonido();
            Console.WriteLine();

            gato1.MostrarInfo();
            gato1.HacerSonido();
            Console.WriteLine();

            gato2.MostrarInfo();
            gato2.HacerSonido();
            Console.WriteLine();

            List<Animal> animales = new List<Animal>();
            animales.Add(perro1);
            animales.Add(gato1);
            animales.Add(perro2);
            animales.Add(gato2);

            foreach (Animal animal in animales)
            {
                animal.HacerSonido();
            }
        }
    }
}