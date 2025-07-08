using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaDoble
    {
        public NodoDoble primero = null; // El primer nodo de la lista
        public NodoDoble ultimo = null;

        public void Insertar(Paciente paciente)
        {
            NodoDoble nuevo = new NodoDoble(); // Crea un nuevo nodo
            nuevo.dato = paciente; // Asigna el paciente al dato del nodo

            // Si la lista está vacía, el nuevo nodo es el primero y el último
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else // Si la lista no está vacía, añade el nuevo nodo al final
            {
                ultimo.sig = nuevo; // El siguiente del último actual es el nuevo
                nuevo.ant = ultimo; // El anterior del nuevo es el último actual
                ultimo = nuevo;     // El nuevo nodo se convierte en el último
            }
        }

        public Paciente Atender()
        {
            if (primero == null) // Si la lista está vacía
            {
                return null; // No hay pacientes para atender
            }

            Paciente pacienteAtendido = primero.dato; // Obtiene el paciente del primer nodo

            if (primero == ultimo) // Si solo hay un nodo en la lista
            {
                primero = null; // La lista queda vacía
                ultimo = null;
            }
            else // Si hay más de un nodo
            {
                primero = primero.sig; // El segundo nodo se convierte en el primero
                primero.ant = null;    // El nuevo primero no tiene anterior
            }
            return pacienteAtendido; // Retorna el paciente que fue atendido
        }

        public bool ActualizarPorDNI(string dni, Paciente nuevosDatos)
        {
            NodoDoble temp = primero;
            while (temp != null)
            {
                if (temp.dato.DNI == dni) // Si encuentra el paciente por DNI
                {
                    // Actualiza todos los campos del paciente existente
                    temp.dato.Nombres = nuevosDatos.Nombres;
                    temp.dato.Apellidos = nuevosDatos.Apellidos;
                    temp.dato.Edad = nuevosDatos.Edad;
                    temp.dato.Seguro = nuevosDatos.Seguro;
                    temp.dato.Sintomas = nuevosDatos.Sintomas;
                    return true; // Retorna true indicando que la actualización fue exitosa
                }
                temp = temp.sig;
            }
            return false; // Retorna false si el paciente no fue encontrado
        }
    }
}
