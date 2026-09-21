using System;
using System.Collections.Generic;
using System.Text;

namespace P1A1_Aythami_Nacho_Projecto
{
    internal class main
    {
        static void Main(string[] args)
        {
            Persona persona2 = new Persona("Luis", 16);
            if (persona2.EsMayorDeEdad())
                Console.WriteLine(persona2.Nombre + " es mayor de edad.");
            else
                Console.WriteLine(persona2.Nombre + " es menor de edad.");
            Persona persona1 = new Persona("Ana", 25);
            persona1.SetNombre("Ana María");
            Console.WriteLine("Nombre actualizado: " + persona1.GetNombre());
        }
    }
}
