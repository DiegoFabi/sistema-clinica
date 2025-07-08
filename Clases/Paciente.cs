using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Paciente
    {
        public string DNI { get; }
        public bool Prioridad { get; }
        public string Nombres { get; }
        public string Apellidos { get; }
        public string Sintomas { get; }
        public string Especialidad { get; }
        public int Edad { get; }

        public Paciente(string dni, bool prioridad, string nombres, string apellidos, string sintomas, string especialidad, int edad)
        {
            DNI = dni;
            Prioridad = prioridad;
            Nombres = nombres;
            Apellidos = apellidos;
            Sintomas = sintomas;
            Especialidad = especialidad;
            Edad = edad;
        }
    }

}
