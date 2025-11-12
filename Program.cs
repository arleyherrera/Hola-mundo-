using System;

namespace MiPrimerPrograma
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Como te llamas");
            string nombre = Console.ReadLine();
            
            while (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("Escribe tu nombre:");
                nombre = Console.ReadLine();
            }
            
            DateTime hoy = DateTime.Now;
            
            Console.WriteLine("Hola " + nombre + ", bienvenido a C#");
            Console.WriteLine("Hoy es " + hoy.ToString("dd/MM/yyyy"));
            
            Console.WriteLine("\nIngresa el primer numero");
            int num1 = LeerNumero();
            
            Console.WriteLine("Ingresa el segundo numero");
            int num2 = LeerNumero();
            
            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicacion = num1 * num2;
            
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es: " + resta);
            Console.WriteLine("La multiplicacion es: " + multiplicacion);
            
            if (num2 != 0)
            {
                double division = (double)num1 / num2;
                Console.WriteLine("La division es: " + division);
            }
            
            if (num1 > num2)
            {
                Console.WriteLine("El primer numero es mayor");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("El segundo numero es mayor");
            }
            else
            {
                Console.WriteLine("Los numeros son iguales");
            }
            
            Console.ReadKey();
        }
        
        static int LeerNumero()
        {
            int numero;
            string entrada = Console.ReadLine();
            
            while (!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Eso no es un numero, intenta otra vez");
                entrada = Console.ReadLine();
            }
            
            return numero;
        }
    }
}