using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dirtycode
{
    public class auto
    {
        public string nc { get; set; }
        public string m { get; set; }
        public int a { get; set; }
        public string pta { get; set; }
        public int i { get; set; }

        public auto()
        { }

        public auto(string vnc, string vm, int va, string vpta, int vi)
        {
            this.nc = vnc;
            this.m = vm;
            this.a = va;
            this.pta = vpta;
            this.i = vi;
        }

        public string antiguedad()
        {
            if (a >= 2000)
                return "auto nuevo";
            else
                return "auto viejo";
        }

        public string pagar_impuesto()
        {
            if (a >= 2000)
                return "paga impuesto";
            else
                return "paga impuesto MINIMO";
        }
    }
}
