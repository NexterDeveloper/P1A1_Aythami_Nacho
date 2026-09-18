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
    }
}
