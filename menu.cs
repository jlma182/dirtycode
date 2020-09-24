using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dirtycode
{
    public class menu
    {
        List<Auto> autos = new List<Auto>();
        string numeroCupo1, m1, placa1;
        int a1, i1;
        string OpcionMenu = " ";
        public void iniciar()
        {
            do
            {
                mostrarMenu();

            } while (OpcionMenu != "0");
        }
        private void mostrarMenu()
        {
            Console.WriteLine("=====Control impuestos autos de Bolivia=====\n");
            Console.WriteLine("1 Crear registro");
            Console.WriteLine("2 Ver lista de registros");
            Console.WriteLine("3 Modificar registro");
            Console.WriteLine("4 Eliminar registro");
            Console.WriteLine("0 SALIR\n");
            Console.Write("Escoja una opcion");
            OpcionMenu = Console.ReadLine();
            SeleccionMenu(OpcionMenu);
        }
        private void SeleccionMenu(string opcion)
        {
            if (opcion == "")
                return;
            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    crearRegistro();
                    RetornarMenu();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    verLista();
                    RetornarMenu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    modificarRegistro();
                    RetornarMenu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    eliminarRegistro();
                    RetornarMenu();
                    Console.ReadKey();
                    break;
                case "r":
                    Console.Clear();
                    mostrarMenu();
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
            string opcion;
            Console.WriteLine("Precione cualquier tecla para volver al menu");
            opcion = Console.ReadLine();
            SeleccionMenu(opcion);
        }
        public void crearRegistro()
        {
            Console.WriteLine("--Crear Automovil");
            Console.Write("ingrese numero de copo:");
            numeroCupo1 = Console.ReadLine();
            Console.Write("ingrese marca:");
            m1 = Console.ReadLine();
            Console.Write("ingrese placa:");
            placa1 = Console.ReadLine();
            Console.Write("ingrese el anio:");
            a1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese el impuesto:");
            i1 = int.Parse(Console.ReadLine());

            autos.Add(new Auto(numeroCupo1, m1, a1, placa1, i1));

            Console.WriteLine("dato guardado.....");
        }
        public void verLista()
        {

            Console.WriteLine("total de registros es:" + autos.Count+"\n");
            Console.WriteLine("====registros====");
            foreach (Auto item in autos)
            {
                verAuto(item);
            }

            Console.WriteLine("\n");
        }
        private void verAuto(Auto dato)
        {

            Console.WriteLine("|numero de copo: {0}| marca: {1}| anio de carro: {2}| placa: {3}| impuesto {4}|", dato.numeroCupo, dato.marca, dato.modelo, dato.placa, dato.impuesto);
            Console.Write(">>{0}>>{1}", dato.antiguedad(), dato.pagar_impuesto());
            Console.WriteLine("\n");

        }

        public Auto buscarAuto (string numeroCopo){
            foreach (var item in autos)
            {
                if (numeroCopo == item.numeroCupo)
                {
                    return item;
                }
            }
            Console.WriteLine("registro no exite......");
            return null;
        }

        public void eliminarRegistro()
        {
            string copoEliminado;
            Auto autoToDelete = new Auto();

            Console.Write("ingrese numero copo:");
            copoEliminado = Console.ReadLine();
            autoToDelete=buscarAuto(copoEliminado);
            if (autoToDelete!=null){
               verAuto(autoToDelete);
               autos.Remove(autoToDelete);
               Console.WriteLine("Datoss eliminados");
            }
       
        }

        public void modificarRegistro()
        {
            Auto autoToUpdate = new Auto();
            string copoActualizar;
            Console.Write("ingrese numero de copo:");
            copoActualizar = Console.ReadLine();
            autoToUpdate=buscarAuto(copoActualizar);
            if (autoToUpdate!=null){
                verAuto(autoToUpdate);
                Console.Write("ingrese numero de copo:  ");
                autoToUpdate.numeroCupo = Console.ReadLine();
                Console.Write("ingrese marca:");
                autoToUpdate.marca = Console.ReadLine();
                Console.Write("ingrese anio:");
                autoToUpdate.modelo = int.Parse(Console.ReadLine());
                Console.Write("ingrese placa:");
                autoToUpdate.placa = Console.ReadLine();
                Console.Write("ingrese impuestos:");
                autoToUpdate.impuesto = int.Parse(Console.ReadLine());
                Console.WriteLine("datos modificados...........");
            }
        }
    }
}
