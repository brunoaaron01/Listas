using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class ListaNodo
    {
        public char Valor;
        public ListaNodo Siguiente;

        public ListaNodo(char valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

   
}
