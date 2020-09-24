using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dirtycode
{
    public class menu
    {
        List<auto> autos = new List<auto>();
        string numeroCupo1, m1, placa1;
        int a1, i1;
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
            Console.WriteLine("Menu prinumeroCupoipaL -r- ");
            op = Console.ReadLine();
            SeleccionMenu(op);
        }
        public void f1()
        {
            Console.WriteLine("--Crear Automovil");
            Console.Write("ingrese numero de copo:");
            numeroCupo1 = Console.ReadLine();
            Console.Write("ingrese marca:");
            m1 = Console.ReadLine();
            Console.Write("ingrese plac aplaca:");
            placa1 = Console.ReadLine();
            Console.Write("ingrese el anio:");
            a1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese el impuesto:");
            i1 = int.Parse(Console.ReadLine());

            autos.Add(new auto(numeroCupo1, m1, a1, placa1, i1));

            Console.WriteLine("dato guardado.....");
        }
        public void f22()
        {

            Console.WriteLine("total de registros es:" + autos.Count);
            Console.WriteLine("====registros====");
            foreach (auto item in autos)
            {
                f2(item);
            }

            Console.WriteLine("\n");
        }
        private void f2(auto dato)
        {

            Console.WriteLine("|numer de copo: {0}| marca: {1}| anio de carro: {2}| placaplaca: {3}| impuesto {4}|", dato.numeroCupo, dato.marca, dato.modelo, dato.placa, dato.impuesto);
            Console.Write(">>{0}>>{1}", dato.antiguedad(), dato.pagar_impuesto());
            Console.WriteLine("\n");

        }
        public void f4()
        {
            string x;
            Console.Write("ingrese numero copo:");
            x = Console.ReadLine();
            foreach (var item in autos)
            {
                if (x == item.numeroCupo)
                {
                    Console.WriteLine("|numer de copo: {0}| marca: {1}| anio de carro: {2}| placaplaca: {3}| impuesto {4}|", item.numeroCupo, item.marca, item.modelo, item.placa, item.impuesto);
                    Console.WriteLine("\n");
                    autos.Remove(item);
                    Console.WriteLine("DATOs ELIMINADOs");
                    break;

                }
                else
                {
                    Console.WriteLine("registro no exite......");
                }
            }
        }
        public void f3()
        {
            auto ap = new auto();
            string buscar;
            Console.Write("ingrese numero de copo:");
            buscar = Console.ReadLine();
            foreach (var item in autos)
            {
                if (buscar == item.numeroCupo)
                {
                    Console.WriteLine("|numer de copo: {0}| marca: {1}| anio de carro: {2}| placa: {3}| impuesto {4}|", item.numeroCupo, item.marca, item.modelo, item.placa, item.impuesto);
                    Console.Write(">>{0}>>{1}", item.antiguedad(), item.pagar_impuesto());

                    Console.Write("ingrese numero de copo:  ");
                    ap.numeroCupo = Console.ReadLine();
                    item.numeroCupo = ap.numeroCupo;
                    Console.Write("ingrese marca:");
                    ap.marca = Console.ReadLine();
                    item.marca = ap.marca;
                    Console.Write("ingrese anio:");
                    ap.modelo = int.Parse(Console.ReadLine());
                    item.modelo = ap.modelo;
                    Console.Write("ingrese placa:");
                    ap.placa = Console.ReadLine();
                    item.placa = ap.placa;
                    Console.Write("ingrese impuestos:");
                    ap.impuesto = int.Parse(Console.ReadLine());
                    item.impuesto = ap.impuesto;
                    Console.WriteLine("datos modificados...........");
                }

            }
        }

    }
}
