using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torres_de_hanoi_100__real_no_fake
{
    internal class pila
    {
        public nodo primero;

        public bool pilavacia()
        {
            return primero == null;
        }

        public void push(int valor)
        {
            nodo chepusei = new nodo(valor);
            if (pilavacia())
            {
                primero = chepusei;
                return;
            }
            chepusei.next = primero;
            primero.prev = chepusei;
            primero = chepusei;
        }

        public int pop()
        {
            if (pilavacia())
            {
                return 0;
            }
            int valor = primero.dato;
            primero = primero.next;
            if (primero != null)
            {
                primero.prev = null;
            }
            return valor;
        }

        public int peek()
        {
            if (pilavacia())
            {
                return 0;
            }
            return primero.dato;
        }

    }
}
