using System;
using System.Collections.Generic;
using System.Text;

namespace Cine_Trabajo
{
    class Comida : OpcionCine
    {
        //ATRIBUTO
        public int opc = 0, op = 0;
        public Comida()
        {

        }
        //METODO PARA MOSTRAR MENU DE COMBO
        public void menucombo()
        {
            //APLICACION DE LISTA
            List<string> menucomida = new List<string>();
            menucomida.Add("1- Combo Familiar");
            menucomida.Add("2- Combo Individual");
            menucomida.Add("3- Combo Junior ");
            menucomida.Add("4- Combo Grande");
            menucomida.Add("5- Combo Especial");

            foreach (string c in menucomida)
            {
                Console.WriteLine(c);
            }
        }
        //METODO PARA ELEGIR COMBO
        public void elejircombo()
        {


            opc = Convert.ToInt16(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Combo seleccionado:Combo Familiar ");
                    Console.WriteLine("Que contiene: 2 Canguil Grande - 1 Hot-dog - 3 Bebidas medianas");
                    break;

                case 2:
                    Console.WriteLine("Combo seleccionado:Individual ");
                    Console.WriteLine("Que contiene: 1 Canguil mediano - 1 Bebidas mediana");
                    break;

                case 3:
                    Console.WriteLine("Combo seleccionado:Combo Junior ");
                    Console.WriteLine("Que contiene: 1 Canguil pequeño o 1 Hot-dog - 1 Bebidas pequeña");
                    break;
                case 4:
                    Console.WriteLine("Combo seleccionado:Combo Grande ");
                    Console.WriteLine("Que contiene: 1 Canguil Grande - 1 Bebidas Grande");
                    break;
                case 5:
                    Console.WriteLine("Combo seleccionado:Combo Especial ");
                    Console.WriteLine("Que contiene: 1 Canguil  - 2 Hot-dog - 2 Bebidas medianas");
                    break;
                default:
                    erroropcion();
                    break;
            }
        }
        //METODO
        public void menuadicional()
        {
            //APLICACION DE LISTA
            List<string> menucomida = new List<string>();
            menucomida.Add("1- Choclate");
            menucomida.Add("2- Cola");
            menucomida.Add("3- Canguil ");
            menucomida.Add("4- Papitas");

            foreach (string a in menucomida)
            {
                Console.WriteLine(a);
            }
        }
        //METODO
        public void elejiradicianal()
        {
            op = Convert.ToInt16(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Combo seleccionado adicional :Chocolate ");

                    break;

                case 2:
                    Console.WriteLine("Combo seleccionado adicional :Cola ");

                    break;

                case 3:
                    Console.WriteLine("Combo seleccionado adicional :Canguil ");

                    break;
                case 4:
                    Console.WriteLine("Combo seleccionado adicional :Papitas ");

                    break;
                default:
                    erroropcion();
                    break;
            }
        }
    }
}
