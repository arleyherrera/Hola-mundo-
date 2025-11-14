using System;


class Funciones
{
    
    public int cuadrado(int numero)
    {
        return numero * numero;
    }

    
    public void Intercambio(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    
    public int sumar(int x, int y)
    {
        return x + y;
    }

 
    public void mostrarResultado(int resultado)
    {
        Console.WriteLine("Suma = " + resultado);
    }


    public int mayor(int num1, int num2)
      {
    return (num1 > num2) ? num1 : num2;
     }


    public double aumentoDiezPorciento(double numero)
    {
        return numero * 1.10;
    }

}