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
            Random random = new Random();
            timer = new Timer();
            const int TEMPERATURA = 140;
            const int HUMO = 100;
            Console.WriteLine("     _______________________________________");
            Console.WriteLine("    /                                      /|");
            Console.WriteLine("   /         / /  /_ ] /| /               / |");
            Console.WriteLine("  /         /_/  /    / |/               /  |");
            Console.WriteLine(" /______________________________________/   |");
            Console.WriteLine(" ||'''''''''''''''''||'''''''''''''''''||   |");
            Console.WriteLine(" ||   |__|   |__|   ||                 ||   |");
            Console.WriteLine(" ||   |__|   |__|   ||                 ||  /|");
            Console.WriteLine(" ||   |__|   |__| PISO 4               || / |");
            Console.WriteLine(" ||                 ||                 ||/  |");
            Console.WriteLine(" ||-----------------||-----------------||   |");
            Console.WriteLine(" ||                 ||                 ||   |");
            Console.WriteLine(" ||                 ||                 ||  /|");
            Console.WriteLine(" ||               PISO 3               || / |");
            Console.WriteLine(" ||                 ||                 ||/  |");
            Console.WriteLine(" ||-----------------||-----------------||   |");
            Console.WriteLine(" ||                 ||                 ||   |");
            Console.WriteLine(" ||               PISO 2               ||  /|");
            Console.WriteLine(" ||                 ||                 || / |");
            Console.WriteLine(" ||                 ||                 ||/  |");
            Console.WriteLine(" ||-----------------||-----------------||   |");
            Console.WriteLine(" ||                 ||                 ||   |");
            Console.WriteLine(" ||      _____    PISO 1    _____      ||   /");
            Console.WriteLine(" ||      |S E|      ||      |S E|      ||  /");
            Console.WriteLine(" ||      |!  |      ||      |!  |      || /");
            Console.WriteLine(" ||______|___|______||______|___|______||/");
            Console.WriteLine("                               ");
            Console.WriteLine("");
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
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
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
