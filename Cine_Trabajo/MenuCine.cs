using System;
using System.Collections.Generic;
using System.Text;

namespace Cine_Trabajo
{
    //Herencia
    class MenuCine : Menu
    {
        public MenuCine()
        {

        }
        //METODO PARA MOSTRAR TITULO DEL PROGRAMA
        public void TituloPrograma()
        {
            Console.Title = "Programa de Cine";

        }
        //Menu General
        //METODO PARA MOSTRAR INICIO
        public override void menu()
        {
            Console.WriteLine("\t\t **********************************************");
            Console.WriteLine("\t\t *                  INICIO                    *");
            Console.WriteLine("\t\t **********************************************");
            Console.WriteLine("\t\t * 1- Ver Cartelera                           *");
            Console.WriteLine("\t\t * 2- Seleccionar Pelicula                    *");
            Console.WriteLine("\t\t * 3- Salir                                   *");
            Console.WriteLine("\t\t **********************************************");
            Console.WriteLine("\t\t **********************************************");
        }



        //METODO SELECCIONAR PELICULA DE CARTELERA
        public void menupeliculas()
        {

            Console.WriteLine("\t\t *********************************************");
            Console.WriteLine("\t\t *****      PELICULAS EN CARTELERAS      *****");
            Console.WriteLine("\t\t *********************************************");
            Console.WriteLine("\t\t * 1- John Wick 3                            *");
            Console.WriteLine("\t\t * 2- Aladdin                                *");
            Console.WriteLine("\t\t * 3- Avengers                               *");
            Console.WriteLine("\t\t * 4- Pikachu                                *");
            Console.WriteLine("\t\t * 5- Spider-Man:No Way Home                 *");
            Console.WriteLine("\t\t *********************************************");
            Console.WriteLine("\t\t ***** Ingrese la pelicula que deseas ver ****");
            Console.WriteLine("\t\t *********************************************");
        }
        public void erroropcion()
        {
            Console.WriteLine("La opcion no existe");
        }
    }
}
namespace Cine_Trabajo
{
    class menucarteleta : Menu
    {
        //Menu cartelera
        //Metodo PARA VER CARTELERA
        public override void menu()
        {

            Console.WriteLine("\t\t *********************************************");
            Console.WriteLine("\t\t *****      PELICULAS EN CARTELERAS      *****");
            Console.WriteLine("\t\t *********************************************");
            Console.WriteLine("\t\t * 1- John Wick 3                            *");
            Console.WriteLine("\t\t * 2- Aladdin                                *");
            Console.WriteLine("\t\t * 3- Avengers                               *");
            Console.WriteLine("\t\t * 4- Pikachu                                *");
            Console.WriteLine("\t\t * 5- Spider-Man:No Way Home                 *");
            Console.WriteLine("\t\t *********************************************");
            Console.WriteLine("\t\t ****** Pulse 6 para retroceder a inicio  ****");
            Console.WriteLine("\t\t *********************************************");
        }
    }
}
