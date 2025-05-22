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
            Console.WriteLine(" GRUPO JJM SAC - PERÚ");
            Console.WriteLine(" =======================================================================================");
            Console.WriteLine(" F E N I X   P O W E R   P E R Ú   S A C");
            Console.WriteLine("                                        ");
            Console.WriteLine(DateTime.Now);
            
            Console.WriteLine("                                        ");
            Console.WriteLine("QUE PISO DEL EDIFICIO DESEA MONITOREAR: ");
            Console.WriteLine("       _______________________________________");
            Console.WriteLine("      //       _  _     _ _    _   _         /|");
            Console.WriteLine("     //        / /     /_ /    /| /         //|");
            Console.WriteLine("    //        /_/     /      _/ |/         // |");
            Console.WriteLine("   //_____________________________________//  |");
            Console.WriteLine("   ||'''''''''''''''''||'''''''''''''''''||   |");
            Console.WriteLine("   ||   |__|   |__|   ||   |__|   |__|   ||   |");
            Console.WriteLine("   ||   |__|   |__|   ||   |__|   |__|   ||  /|");
            Console.WriteLine("   ||   |__|   |__| PISO 4 |__|   |__|   || / |");
            Console.WriteLine("   ||                 ||                 ||/  |");
            Console.WriteLine("   ||-----------------||-----------------||   |");
            Console.WriteLine("   ||                 ||                 ||   |");
            Console.WriteLine("   ||   |__|   |__|   ||   |__|   |__|   ||  /|");
            Console.WriteLine("   ||   |__|   |__| PISO 3 |__|   |__|   || / |");
            Console.WriteLine("   ||   |__|   |__|   ||   |__|   |__|   ||/  |");
            Console.WriteLine("   ||-----------------||-----------------||   |");
            Console.WriteLine("   ||                 ||                 ||   |");
            Console.WriteLine("   ||   |__|   |__| PISO 2 |__|   |__|   ||  /|");
            Console.WriteLine("   ||   |__|   |__|   ||   |__|   |__|   || / |");
            Console.WriteLine("   ||   |__|   |__|   ||   |__|   |__|   ||/  |");
            Console.WriteLine("   ||-----------------||-----------------||   |");
            Console.WriteLine("   ||                 ||                 ||   |");
            Console.WriteLine("   ||      _____    PISO 1    _____      ||   /");
            Console.WriteLine("   ||      |S E|      ||      |S E|      ||  /");
            Console.WriteLine("   ||      |?  |      ||      |?  |      || /");
            Console.WriteLine("   ||______|___|______||______|___|______||/");
            Console.WriteLine("  _______________________________________");
            Console.WriteLine("______________________________________");
            MenuPrincipal();
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
                    Console.WriteLine("📍 Ingresando Piso 1...");
                    Piso1(); 
                    break;
                case 2:
                    Console.WriteLine("📍 Ingresando Piso 2...");
                    break;
                case 3:
                    Console.WriteLine("📍 Ingresando Piso 3...");
                    break;
                case 4:
                    Console.WriteLine("📍 Ingresando Piso 4...");
                    break;
                case 5:
                    Console.WriteLine("📍 Saliendo 🛑...");
                    Thread.Sleep(1000);
                    break;
                default:
                    Console.WriteLine("Opción no valida...");
                    Thread.Sleep(1500);

                    break;
            }
        }
        static void Piso1()
        {
            Console.WriteLine("Estadisticas del Turbo Generador uno:");
            int temperatura, humo;
            Random TurboGenerador = new Random();
            temperatura = TurboGenerador.Next(20, 101);
            Console.WriteLine("🌡 Temperatura: " + temperatura + "°");
            humo = TurboGenerador.Next(0, 101);
            Console.WriteLine("💨 Nivel de Humo: " + humo+"%");
        }

    }
}
