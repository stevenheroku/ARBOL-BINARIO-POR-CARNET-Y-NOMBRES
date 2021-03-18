using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Nombres_Carnet.Clases.ArbolBinarioOrdenado
{
    interface Comparador
    {
        bool igualQue(Object q);
        bool menorigualQue(Object q);
        bool mayorQue(object q);
        bool mayorigualQue(Object q);
        bool menorQue(Object q);

    }
}
