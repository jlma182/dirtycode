using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dirtycode
{
    public class menu : crud
    {
        string OpcionMenu = " ";
        public void iniciar()
        {
            do
            {
                Cabeza();

            } while (OpcionMenu != "0");
        }

        private void Cabeza()
        {
            Console.WriteLine("=====control impuesto autos BOLIVIA=====");
            Console.WriteLine("\n");
            Console.WriteLine("1 Crear registro");
            Console.WriteLine("2 Revisar(ver)lista de registros");
            Console.WriteLine("3 Modificar registro");
            Console.WriteLine("4 Eliminar registro");
            Console.WriteLine("0 SALIR");
            Console.WriteLine("\n");
            Console.Write("Escoja una opcion");
            OpcionMenu = Console.ReadLine();
            SeleccionMenu(OpcionMenu);
        }
        private void SeleccionMenu(string op)
        {
            if (op == "")
                return;
            switch (op)
            {
                case "1":
                    Console.Clear();
                    f1();
                    RetornarMenu();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    f22();
                    RetornarMenu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    f3();
                    RetornarMenu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    f4();
                    RetornarMenu();
                    Console.ReadKey();
                    break;
                case "r":
                    Console.Clear();
                    Cabeza();
                    Console.ReadKey();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;

                default:
                    Console.Write("seleccion no valida.....");
                    break;
            }
        }

        private void RetornarMenu()
        {
            string op;
            Console.WriteLine("Menu principaL -r- ");
            op = Console.ReadLine();
            SeleccionMenu(op);
        }
    }
}
