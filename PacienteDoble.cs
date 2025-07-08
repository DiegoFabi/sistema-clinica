using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class PacienteDoble
    {
       
        public string DNI { get; }
        public string Nombres { get; }
        public string Apellidos { get; }
        public string Direccion { get; }
        public string FechaCita { get; }
        public int NumerodeCelular { get; }
        public string Sintomas { get; }
        public string Especialidad { get; }

        public PacienteDoble(string dNI, string nombres, string apellidos, string direccion, string fechaCita, int numerodeCelular, string sintomas, string especialidad)
        {
            DNI = dNI;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            FechaCita = fechaCita;
            NumerodeCelular = numerodeCelular;
            Sintomas = sintomas;
            Especialidad = especialidad;
        }
    }
}
