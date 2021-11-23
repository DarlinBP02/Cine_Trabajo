using System;
using System.Collections.Generic;
using System.Text;

namespace Cine_Trabajo
{
    class Asiento
    {
        //CONSTRUCTOR
        public Asiento()
        {

        }
        //Atributos
        int fila, columnas;

        int[,] asiento = new int[20, 40];

        //METODO PARA ELEGIR ASIENTO
        public void asientos()
        {

            Console.WriteLine("********************************");
            Console.WriteLine("*     Seleccione el asiento    *");
            Console.WriteLine("********************************");
            Console.WriteLine("Ingrese el numero de fila (1-20)");
            fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de columnas (1-40)");
            columnas = int.Parse(Console.ReadLine());
            if (asiento[fila - 1, columnas - 1] == 0)
            {
                asiento[fila - 1, columnas - 1] = 1;
                Console.WriteLine("Asiento seleccionado");
            }
            else
                Console.WriteLine("Asiento ocupado");
        }
        //METODO PARA MOSTRAR ASIENTO SELECCIONADO
        public void mostrarasiento()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Con el asiento seleccionado");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Columna => " + columnas);
            Console.WriteLine("Fila => " + fila);
        }

    }
}
