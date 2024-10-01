using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Ejercicio9
    {
        private ListaNodo cabeza;

        public void Agregar(char valor)
        {
            ListaNodo nuevoNodo = new ListaNodo(valor);
            nuevoNodo.Siguiente = cabeza;
            cabeza = nuevoNodo;
        }

        public string Invertir()
        {
            string resultado = "";
            ListaNodo actual = cabeza;

            while (actual != null)
            {
                resultado += actual.Valor;
                actual = actual.Siguiente;
            }

            return resultado;
        }
    }
}
