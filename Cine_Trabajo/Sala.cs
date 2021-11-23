using System;
using System.Collections.Generic;
using System.Text;

namespace Cine_Trabajo
{
    class Sala : OpcionCine
    {
        public Sala()
        {

        }
        private string sal;
        //Metodo PARA VER Sala
        public void sala()
        {
            Console.WriteLine("\t\t ***************************************");
            Console.WriteLine("\t\t **          SALAS DISPONIBLES        **");
            Console.WriteLine("\t\t ***************************************");
            Console.WriteLine("\t\t * 1- SALA 1                           *");
            Console.WriteLine("\t\t * 2- SALA 2                           *");
            Console.WriteLine("\t\t * 3- SALA 3                           *");
            Console.WriteLine("\t\t * 4- SALA 4                           *");
            Console.WriteLine("\t\t * 5- SALA 5                           *");
            Console.WriteLine("\t\t ***************************************");
            Console.WriteLine("\t\t **          Seleccione la Sala       **");
            Console.WriteLine("\t\t ***************************************");

        }
        //METODO PARA SELECCIONAR OPCION DE SALA
        public int Opcionsala()
        {
            string num = Console.ReadLine();
            int ele = int.Parse(num);
            if (ele == 1)
            {
                sal = "Sala 1  ";
            }
            if (ele == 2)
            {
                sal = "Sala 2  ";
            }
            if (ele == 3)
            {
                sal = "Sala 3  ";
            }
            if (ele == 4)
            {
                sal = "Sala 4  ";
            }
            if (ele == 5)
            {
                sal = "Sala 5  ";
            }
            else if (ele >= 6 || ele <= 0)

            {
                erroropcion();
            }
            return ele;
        }
        public void mostrarsala()
        {
            Console.WriteLine("Sala escogida: " + sal);
        }
    }
}

