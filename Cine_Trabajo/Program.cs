using System;

namespace Cine_Trabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime diaHoy = DateTime.Now;
            string dms = diaHoy.ToString("F");
            Console.WriteLine(dms);
            Sala sala = new Sala();
            //intanciamos clase
            Asiento puesto = new Asiento();
            //intanciamos clase
            Persona nom = new Persona();
            //intanciamos clase
            Comida combo = new Comida();
            //intanciamos clase
            OpcionCine mostrar = new OpcionCine();
            //intanciamos clase
            mostrar.TituloPrograma();
            Menu men = new MenuCine();
            //instanciamos clase
            men.menu();
            mostrar.OpcionInicio();
            nom.Ingresenombre();
            puesto.asientos();
            Console.WriteLine("*********Confirme Pelicula ********");
            mostrar.menupeliculas();
            mostrar.OpcionPeliculas();
            sala.sala();
            sala.Opcionsala();
            Console.Clear();
            //Detalles del cliente
            Console.WriteLine("----------DETALLES DEL CLIENTE--------");
            nom.usuarionombre();
            mostrar.mostrarpelicula();
            sala.mostrarsala();
            puesto.mostrarasiento();
            Console.WriteLine("******************************");
            Console.WriteLine(" Seleccion de Combo de comida ");
            Console.WriteLine("******************************");
            combo.menucombo();
            combo.elejircombo();
            Console.WriteLine("************************************");
            Console.WriteLine("  Seleccion un aperiticvo adicional ");
            Console.WriteLine("************************************");
            combo.menuadicional();
            combo.elejiradicianal();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------GRACIAS-----------------");
            Console.WriteLine();
        }
    }
}
