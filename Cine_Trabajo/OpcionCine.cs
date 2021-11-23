using System;
using System.Collections.Generic;
using System.Text;

namespace Cine_Trabajo
{
    //APLICACION DE HERENCIA
    class OpcionCine : MenuCine
    {
        //ATRIBUTO
        private string peli;
        public OpcionCine()
        {

        }

        //METODO PARA ELEJIR UNA OPCION DE INICIO
        public int OpcionInicio()
        {
            string num = Console.ReadLine();
            int elejir = int.Parse(num);
            if (elejir == 1)
            {
                Console.Clear();
                Menu me = new menucarteleta();
                me.menu();
                OpcionCartelera();
            }
            if (elejir == 2)
            {
                OpcionCine opc = new OpcionCine();
                Console.Clear();
                opc.menupeliculas();
                opc.OpcionPeliculas();
            }
            if (elejir == 3)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-------   GRACIAS POR ELEGIRNOS   ---------");
                Console.WriteLine("-------------------------------------------");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("-------           ADIOS           ---------");
            }
            else if (elejir >= 4 || elejir <= 0)
            {
                erroropcion();
            }
            return elejir;
        }

        //Metodo PARA REGRESAR A INICIO
        public int OpcionCartelera()
        {
            string num = Console.ReadLine();
            int opcion = int.Parse(num);

            if (opcion == 6)
            {
                Console.Clear();
                Menu menu = new MenuCine();
                menu.menu();
                OpcionInicio();
            }

            else if (opcion >= 7 || opcion <= 5)
            {
                erroropcion();
            }
            return opcion;
        }
        //METODO PARA SELECCIONAR OPCION DE LA CARTELERA
        public int OpcionPeliculas()
        {
            string num = Console.ReadLine();
            int elejir = int.Parse(num);
            if (elejir == 1)
            {
                peli = "John Wick 3 ";

            }
            if (elejir == 2)
            {
                peli = "Aladdin ";
            }
            if (elejir == 3)
            {
                peli = "Avengers: END GAME ";
            }
            if (elejir == 4)
            {
                peli = "Pikachu  ";
            }
            if (elejir == 5)
            {
                peli = "Spider-Man:No Way Home ";
            }
            else if (elejir >= 6 || elejir <= 0)
            {
                erroropcion();
            }
            return elejir;
        }
        //METODO PARA MOSTRAR PELICULA 
        public void mostrarpelicula()
        {
            Console.WriteLine("Pelicula seleccionada: " + peli);
        }
        //METODO PARA MOSTRAR ERROR DE OPCION
    }
}
