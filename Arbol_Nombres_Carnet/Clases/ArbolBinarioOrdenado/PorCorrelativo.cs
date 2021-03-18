using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Nombres_Carnet.Clases.ArbolBinarioOrdenado
{
    class PorCorrelativo : Comparador
    {
        public string correlativo;
        public string prueba;
        int numVal;
        public string descripcion;
        public bool igualQue(object q)
        {
            return true;
        }

        public bool mayorigualQue(object q)
        {
            PorCorrelativo p2 = (PorCorrelativo)q;
            //numVal = int.Parse(correlativo);
            return correlativo.CompareTo(p2.correlativo) >= 0;
        }


        public bool mayorQue(object q)
        {
            PorCorrelativo p2 = (PorCorrelativo)q;
            //numVal = int.Parse(correlativo);
            return correlativo.CompareTo(p2.correlativo) > 0;
        }

        public bool menorigualQue(object q)
        {
            PorCorrelativo p2 = (PorCorrelativo)q;
            //numVal = int.Parse(correlativo);
            return correlativo.CompareTo(p2.correlativo) <= 0;
        }
        public bool menorQue(object q)
        {
            PorCorrelativo p2 = (PorCorrelativo)q;
            //numVal = int.Parse(correlativo); 
            return correlativo.CompareTo(p2.correlativo) < 0;
        }
    }
}
