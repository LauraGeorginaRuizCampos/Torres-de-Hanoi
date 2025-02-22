using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torres_de_hanoi_100__real_no_fake
{
    internal class nodo
    {
        public nodo next;
        public nodo prev;
        public int dato;

        public nodo(int dato)
        {
            this.dato = dato;
            this.prev = null;
            this.next = null;
        }

        public nodo(int dato, nodo prev)
        {
            this.dato = dato;
            this.prev = prev;
            this.next = null; 
        }

        public nodo (int dato, nodo prev, nodo next)
        {
            this.dato = dato;
            this.prev = prev;
            this.next = next; 
        }


    }
}
