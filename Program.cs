using System;

namespace MiPrimerPrograma
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Como te llamas");
            string nombre = Console.ReadLine();
            
            DateTime hoy = DateTime.Now;
            
            Console.WriteLine("Hola " + nombre + ", bienvenido a C#");
            Console.WriteLine("Hoy es " + hoy.ToString("dd/MM/yyyy"));
            
            Console.WriteLine("\nIngresa el primer numero");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresa el segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            
            int suma = num1 + num2;
            
            Console.WriteLine("La suma es: " + suma);
            
            Console.ReadKey();
        }
    }
}