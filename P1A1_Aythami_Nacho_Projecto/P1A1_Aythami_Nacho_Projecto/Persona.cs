using System;
using System.Collections.Generic;
using System.Text;

namespace P1A1_Aythami_Nacho_Projecto
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
        }

        public void SetNombre(string nuevoNombre)
        {
            Nombre = nuevoNombre;
        }

        public string GetNombre()
        {
            return Nombre;
        }
        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }
    }
}
