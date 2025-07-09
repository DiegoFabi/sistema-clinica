using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public class ColaPrioridad
    {
        private Nodo frente = null;
        private Nodo final = null;


        public void Encolar(Paciente d)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = d;

            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else if (d.Prioridad == true)
            {
                Nodo actual = frente;
                Nodo anterior = null;

                while (actual != null && actual.dato.Prioridad)
                {
                    anterior = actual;
                    actual = actual.sig;
                }

                if (anterior == null)
                {
                    nuevo.sig = frente;
                    frente = nuevo;
                }
                else
                {
                    nuevo.sig = anterior.sig;
                    anterior.sig = nuevo;

                    if (nuevo.sig == null)
                        final = nuevo;
                }
            }
            else
            {
                final.sig = nuevo;
                final = nuevo;
            }
        }


        public Paciente Desencolar()
        {
            if(frente != null){
                Paciente atendido = frente.dato;
                frente = frente.sig;

                if (frente == null)
                    final = null;

                return atendido;
            }

            return null; 
        }

        public Paciente Peek()
        {
            if (frente != null)           
            {
                return frente.dato;       
            }
            else
            {
                return null;             
            }
        }

        public void Vaciar()
        {
            frente = null;
            final = null;
        }

        public int Contar()
        {
            int contador = 0;
            Nodo actual = frente;

            while (actual != null)
            {
                contador++;
                actual = actual.sig;
            }

            return contador;
        }

        public bool ExisteDNI(string dni)
        {
            Nodo actual = frente;

            while (actual != null)
            {
                if (actual.dato.DNI == dni)
                {
                    return true; //dni existe
                }
                actual = actual.sig;
            }

            return false; //no hay dni
        }

        public void DataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            Nodo actual = frente;

            while (actual != null)
            {
                Paciente p = actual.dato;
                dgv.Rows.Add(
                    p.DNI,
                    p.Prioridad ? "Si" : "No",
                    p.Nombres,
                    p.Apellidos,
                    p.Sintomas,
                    p.Especialidad,
                    p.Edad
                );

                actual = actual.sig;
            }
        }

    }

}
