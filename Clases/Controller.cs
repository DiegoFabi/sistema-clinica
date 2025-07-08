using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public class Controller
    {
        ListDoble listaPacientes = new ListDoble();   
        //validaciones
        //esto para validar la primera pestaña que es la cola
        public (bool,string) validarCola(string dni, string nombres, string apellidos, 
            string edad, string sintomas, string especialidad) {

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(nombres) || 
                string.IsNullOrEmpty(apellidos) || string.IsNullOrEmpty(edad) || 
                string.IsNullOrEmpty(sintomas) || string.IsNullOrEmpty(especialidad))
            {
                return (false, "Llene todos los campos requeridos"); // Informacion incompleta
            }

            if (dni.Length != 8) {
                return (false, "DNI debe tener exactamente 8 dígitos");
            }
            if(dni.All(char.IsLetter)) {
                return (false, "DNI debe contener solo números");
            }
            if (!nombres.All(char.IsLetter)) { 
                return (false, "Los nombres deben contener solo letras");
            }
            if(!apellidos.All(char.IsLetter)) {
                return (false, "Los apellidos deben contener solo letras");
            }
            if (!edad.All(char.IsDigit))
            {
                return (false, "La edad debe contener solo números.");
            }

            int edadEntero = int.Parse(edad);

            if (edadEntero < 1 || edadEntero > 90)
            {
                return (false, "Edad debe estar entre 1 y 90 años.");
            }

            if (sintomas.Length>80) {
                return (false, "La descripcion de sintomas no pueden superar los 80 caracteres");
            }
            return (true,"Registrado correctamente.");

        }

        //esto para validar la segunda pestaña que es el lista doble
        public (bool, string) validarListaDoble(string dni, string nombres, string apellidos,
            string direccion, string fechaCita, string celular, string sintomas, string especialidad)
        {
            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(nombres) ||
                string.IsNullOrEmpty(apellidos) ||  string.IsNullOrEmpty(direccion) ||
                string.IsNullOrEmpty(fechaCita) || string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(sintomas))
            {
                return (false, "Llene todos los campos requeridos"); // Informacion incompleta
            }
            if (dni.Length != 8 || !dni.All(char.IsDigit))
            {
                return (false, "DNI debe tener exactamente 8 dígitos y solo números");
            }
            if (!nombres.All(char.IsLetter))
            {
                return (false, "Los nombres deben contener solo letras");
            }
            if (!apellidos.All(char.IsLetter))
            {
                return (false, "Los apellidos deben contener solo letras");
            }
            if (sintomas.Length > 80)
            {
                return (false, "La descripción de síntomas no puede superar los 80 caracteres");
            }
            if (celular.All(char.IsLetter))
            {
                return (false, "El número de celular debe contener solo números");
            }
            if (celular.Length > 9 || celular.Length < 9) {
                return (false, "El número de celular solo puede contener 9 números");
            }
            if (listaPacientes.ExisteNumeroCelular(int.Parse(celular)))
                return (false, "Ya existe un paciente registrado con este número de celular.");
            if (string.IsNullOrEmpty(especialidad)) {
                return (false, "Seleccione una especialidad.");
            }
            return (true, "");
        }
        public (bool, string) ValidarInfoGrafo(string nombres, string apellidos, string servicio, string rol, string puntoInicio)
        {

            if (string.IsNullOrWhiteSpace(nombres) ||
                string.IsNullOrWhiteSpace(apellidos) ||
                string.IsNullOrEmpty(servicio) ||
                string.IsNullOrEmpty(rol) ||
                string.IsNullOrEmpty(puntoInicio))
            {
                return (false,"Ingrese todos los campos requeridos.");
           
            }

            if (nombres.All(char.IsDigit))
            {
                return (false, "Los nombres solo deben contener letras.");
            }
            if (apellidos.All(char.IsDigit))
            {
                return (false,"Los apellidos solo deben contener letras");
            }
            return (true,"");
        }

    }
}
