using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dirtycode
{
    public class auto
    {
        public string numeroCupo { get; set; }
        public string marca { get; set; }
        public int modelo { get; set; }
        public string placa { get; set; }
        public int impuesto { get; set; }

        public auto()
        { }

        public auto(string numeroCupo, string marca, int modelo, string placa, int impuesto)
        {
            this.numeroCupo = numeroCupo;
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.impuesto = impuesto;
        }

        public string antiguedad()
        {
            if (modelo >= 2000)
                return "auto nuevo";
            else
                return "auto viejo";
        }

        public string pagar_impuesto()
        {
            if (modelo >= 2000)
                return "paga impuesto";
            else
                return "paga impuesto MINIMO";
        }
    }
}
