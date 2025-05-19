using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoFinal_Taller_de_Casos_13126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUE PISO DEL EDIFICIO DESEA MONITOREAR: ");
            MenuPrincipal();
            Console.WriteLine("     _______________________________________");
            Console.WriteLine("    /        _  _     _ _        _         /|");
            Console.WriteLine("   /         / /     /_ /    /| /         / |");
            Console.WriteLine("  /         /_/     /      _/ |/         /  |");
            Console.WriteLine(" /______________________________________/   |");
            Console.WriteLine(" ||'''''''''''''''''||'''''''''''''''''||   |");
            Console.WriteLine(" ||   |__|   |__|   ||   |__|   |__|   ||   |");
            Console.WriteLine(" ||   |__|   |__|   ||   |__|   |__|   ||  /|");
            Console.WriteLine(" ||   |__|   |__| PISO 4 |__|   |__|   || / |");
            Console.WriteLine(" ||                 ||                 ||/  |");
            Console.WriteLine(" ||-----------------||-----------------||   |");
            Console.WriteLine(" ||                 ||                 ||   |");
            Console.WriteLine(" ||   |__|   |__|   ||   |__|   |__|   ||  /|");
            Console.WriteLine(" ||   |__|   |__| PISO 3 |__|   |__|   || / |");
            Console.WriteLine(" ||   |__|   |__|   ||   |__|   |__|   ||/  |");
            Console.WriteLine(" ||-----------------||-----------------||   |");
            Console.WriteLine(" ||                 ||                 ||   |");
            Console.WriteLine(" ||   |__|   |__| PISO 2 |__|   |__|   ||  /|");
            Console.WriteLine(" ||   |__|   |__|   ||   |__|   |__|   || / |");
            Console.WriteLine(" ||   |__|   |__|   ||   |__|   |__|   ||/  |");
            Console.WriteLine(" ||-----------------||-----------------||   |");
            Console.WriteLine(" ||                 ||                 ||   |");
            Console.WriteLine(" ||      _____    PISO 1    _____      ||   /");
            Console.WriteLine(" ||      |S E|      ||      |S E|      ||  /");
            Console.WriteLine(" ||      |?  |      ||      |?  |      || /");
            Console.WriteLine(" ||______|___|______||______|___|______||/");
            Console.WriteLine("  _______________________________________");
            Console.WriteLine("______________________________________");
        }
        static void MenuPrincipal()
        {
            Console.WriteLine("1.Piso Uno--");
            Console.WriteLine("2.Piso Dos--");
            Console.WriteLine("3.Piso Tres--");
            Console.WriteLine("4.Piso Cuatro--");
            Console.WriteLine("5.Salir--");
            int Opcion=int.Parse(Console.ReadLine());
            
            switch(Opcion)
            {
                case 1:
                    Console.WriteLine("Ingresando Piso 1...");
                    break;
                case 2:
                    Console.WriteLine("Ingresando Piso 2...");
                    break;
                case 3:
                    Console.WriteLine("Ingresando Piso 3...");
                    break;
                case 4:
                    Console.WriteLine("Ingresando Piso 4...");
                    break;
                case 5:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no valida...");
                    break;
            }
        }
        static void ContraIncendio()
        {
            
        }

    }
}
