using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Clases
{
    public class ListDoble
    {
        public NodDoble primero = null;
        public NodDoble ultimo = null;

       
        public void Insertar(PacienteDoble d)
        {
            NodDoble nuevo = new NodDoble(); 
            nuevo.dato = d;

            if (primero == null) 
            {
                primero = nuevo; 
                ultimo = nuevo;  
            }
            else 
            {
                ultimo.sig = nuevo; 
                nuevo.ant = ultimo; 
                ultimo = nuevo;    
            }
        }

        public void CargarEnDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear(); 
            NodDoble actual = primero; 

            while (actual != null) 
            {
                PacienteDoble p = actual.dato; 
                dgv.Rows.Add(
                    p.DNI,
                    p.Nombres,
                    p.Apellidos,
                    p.Direccion,
                    p.FechaCita,
                    p.NumerodeCelular,
                    p.Sintomas,
                    p.Especialidad
                );
                actual = actual.sig; 
            }
        }

        public void EliminarPorDNI(string dni)
        {
            NodDoble actual = primero; 

            while (actual != null)
            {
                if (actual.dato.DNI == dni) 
                {
                    if (actual.ant != null) 
                        actual.ant.sig = actual.sig; 
                    else
                        primero = actual.sig;

                    if (actual.sig != null) 
                        actual.sig.ant = actual.ant; 
                    else
                        ultimo = actual.ant; 

                    return; 
                }
                actual = actual.sig;
            }
        }
        public void MoverArriba(NodDoble moverArriba)
        {
            if (moverArriba == null || moverArriba == primero) /// No se puede mover hacia arriba si ya es el primer nodo o es nulo
            {

                {
                    return;
                }
            }

            NodDoble nodoAnterior = moverArriba.ant;
            NodDoble nodoSiguiente = moverArriba.sig;

            if (nodoAnterior.ant != null)
            {
                nodoAnterior.ant.sig = moverArriba;
            }
            else
            {
                primero = moverArriba; 
            }

            moverArriba.ant = nodoAnterior.ant;
            moverArriba.sig = nodoAnterior;
            nodoAnterior.ant = moverArriba;
            nodoAnterior.sig = nodoSiguiente;

            if (nodoSiguiente != null)
            {
                nodoSiguiente.ant = nodoAnterior;
            }
            else
            {
                ultimo = nodoAnterior; 
            }
        }

     
        public void MoverAbajo(NodDoble moverArriba)
        {
            if (moverArriba == null || moverArriba == ultimo)
            {
               
                return;
            }

            NodDoble nodoSiguiente = moverArriba.sig;
            NodDoble nodoAnterior = moverArriba.ant;
            if (nodoSiguiente.sig != null)
            {
                nodoSiguiente.sig.ant = moverArriba;
            }
            else
            {
                ultimo = moverArriba; 
            }

            moverArriba.ant = nodoSiguiente;
            moverArriba.sig = nodoSiguiente.sig;
            nodoSiguiente.ant = nodoAnterior;
            nodoSiguiente.sig = moverArriba;

            if (nodoAnterior != null)
            {
                nodoAnterior.sig = nodoSiguiente;
            }
            else
            {
                primero = nodoSiguiente; 
            }
        }

        public PacienteDoble AtenderPrimero()
        {
            if (primero == null)
            {
                return null;
            }

            PacienteDoble atendido = primero.dato;
            primero = primero.sig;

            if (primero != null)
            {
                primero.ant = null;
            }
            else
            {
                ultimo = null; 
            }
            return atendido;
        }
        public NodDoble BuscarPorDNI(string dni)
        {
            NodDoble actual = primero;
            while (actual != null)
            {
                if (actual.dato.DNI == dni)
                {
                    return actual;
                }
                actual = actual.sig;
            }
            return null;
        }
        public bool ExisteDNI(string dni)
        {
            NodDoble actual = primero;
            while (actual != null)
            {
                if (actual.dato.DNI == dni)
                {
                    return true;
                }
                actual = actual.sig;
            }
            return false;
        }

        public bool ExisteNumeroCelular(int numeroCelular)
        {
            NodDoble actual = primero;
            while (actual != null)
            {
                if (actual.dato.NumerodeCelular == numeroCelular)
                {
                    return true;
                }
                actual = actual.sig;
            }
            return false;
        }


    }
}
