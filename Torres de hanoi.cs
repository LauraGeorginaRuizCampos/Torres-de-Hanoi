using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torres_de_hanoi_100__real_no_fake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Torres de Hanoi");
            Console.WriteLine("---------------");
            Console.WriteLine("Ingrese el número de discos:");
            int n = Convert.ToInt16(Console.ReadLine());
            pila origen = new pila();
            pila auxiliar = new pila();
            pila destino = new pila(); 

            for (int i = n; i > 0; i--) // inicia la torre de origen
            {
                origen.push(i);
            }

            Hanoi(n, origen, destino, auxiliar, 'A', 'C', 'B');
        }

        static void Hanoi(int n, pila origen, pila destino, pila auxiliar, char nombreOrigen, char nombreDestino, char nombreAuxiliar)
        {
            if (n == 1) // nomas mueve de origen a destino
            {
                int disco = origen.pop();
                destino.push(disco);
                Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
                return;
            }

            Hanoi(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);    //llama a n -1 discos de origen a auxiliar
            int discoMovido = origen.pop(); 
            destino.push(discoMovido);
            Console.WriteLine($"Mover disco {discoMovido} de {nombreOrigen} a {nombreDestino}");
            Hanoi(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
        }
    }
}
