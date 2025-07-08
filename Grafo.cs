using ClasesGrafo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGrafo
{
    public class Grafo
    {
        public Vertice inicio_lista = null;
        public int[,] ma;

        public Grafo(int n)
        {
            ma = new int[n, n];
        }

        public void insertar(int d)
        {
            //1.Crear el nuevo nodo
            Vertice nuevo = new Vertice();
            nuevo.dato = d;

            if (inicio_lista == null)
            {
                //la lista esta vacia
                //el nuevo debe guardarse en el primero
                inicio_lista = nuevo;
            }
            else
            {
                //2. buscar el ultimo
                Vertice temp = inicio_lista;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                //temp esta ubicado en el ultimo
                //3. ultimo.sig el nuevo
                temp.sig = nuevo;

            }
        }

        //METODOS PARA MATRIZ 
        public void llenarMatriz()
        {
            Random r = new Random();
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    ma[i, j] = r.Next(0, 2);
                }
            }
        }

        //METODOS DE GRAFOS
        public void crearGrafo()
        {
            Random r = new Random();
            Vertice tempOrigen = inicio_lista;
            for (int i = 0; i < ma.GetLength(0); i++)//0= filas, origen
            {
                Vertice tempDestino = inicio_lista;
                for (int j = 0; j < ma.GetLength(1); j++)//1=columnas, destinos
                {
                    if (ma[i, j] == 1)//si adyacencia o arista
                    {
                        //union
                        tempOrigen.insertarArista(tempDestino, r.Next(10, 101), "metro(s)");
                    }
                    tempDestino = tempDestino.sig;
                }
                tempOrigen = tempOrigen.sig;
            }
        }

    }
}
