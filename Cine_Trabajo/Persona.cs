using System;
using System.Collections.Generic;
using System.Text;

namespace Cine_Trabajo
{
    class Persona
    {
        //PROPIEDAD
        private string nombre;

        //METODO DE INGRESAR NOMBRE
        public void Ingresenombre()
        {

            Console.WriteLine("*********");
            Console.WriteLine("*   Ingrese su Nombre   *");
            Console.WriteLine("*********");
            nombre = Console.ReadLine();
        }
        //METODO PARA MOSTRAR NOMBRE
        public void usuarionombre()
        {
            Console.WriteLine("Su nombre es: " + nombre);
        }
    }
}
