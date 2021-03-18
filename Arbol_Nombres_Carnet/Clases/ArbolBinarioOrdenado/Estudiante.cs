using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Nombres_Carnet.Clases.ArbolBinarioOrdenado
{
    class Estudiante : Comparador
    {

        public string nombre;
        int comparar;
        public string prueba;
        public string descripcion;

        public bool igualQue(object q)
        {
            ////esto es prueba
            //SoloNumeros p2 = (SoloNumeros)q;
            //return numero == p2.numero;
            return true;
        }

        public bool mayorigualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            //comparar = int.Parse(nombre);

            return nombre.CompareTo(p2.nombre) >= 0;
            // return numero >= p2.numero;

        }


        public bool mayorQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            //  comparar = int.Parse(nombre);
            return nombre.CompareTo(p2.nombre) > 0;
            // return numero > p2.numero;
        }

        public bool menorigualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            //comparar = int.Parse(nombre);
            return nombre.CompareTo(p2.nombre) <= 0;
            //return numero <= p2.numero;
        }
        public bool menorQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            //   
            return nombre.CompareTo(p2.nombre) < 0;
            //  return numero < p2.numero;
        }
    }
}
