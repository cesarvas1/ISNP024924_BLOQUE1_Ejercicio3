using System;

class Program
{
    static void Main()
    {
        int numero;
        int suma = 0;

        do
        {
            Console.Write("Ingrese un número positivo (0 o negativo para salir): ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                suma += numero;
            }

        } while (numero > 0);

        Console.WriteLine("La suma total es: " + suma);
        Console.WriteLine("Programa terminado.");
    }
}