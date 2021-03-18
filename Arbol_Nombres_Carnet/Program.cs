using Arbol_Nombres_Carnet.Clases.ArbolBinarioOrdenado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Nombres_Carnet
{
    class Program
    {

        public static void pruebaordenNombres()
        {
            ArbolBinarioBusqueda abr = new ArbolBinarioBusqueda();
            Estudiante student = new Estudiante();
            // string[] nom = { "Jeff", "Luis", "Pedro", "Carlos", "Fernando", "Zandra" };
            string[] nombre = new string[5];

            Console.WriteLine("Debe Ingresar 5 Nombres Ejemplo:Jefferson\n");
            int contador = 1;
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Ingrese el Nombre No." + contador);
                nombre[i] = Console.ReadLine();
                contador++;
            }

            foreach (string d in nombre)
            {

                student.nombre = d;
                student.descripcion = $"insertar Nombre. {d}";
                abr.insertar(student);
                student = new Estudiante();
            }
            int pausa;
            pausa = 0;


        }
        public static void pruebaPorCorrelativo()
        {
            ArbolBinarioBusqueda abr = new ArbolBinarioBusqueda();
            PorCorrelativo student = new PorCorrelativo();
            //string[] carnet = { "19-13857", "18-5420", "17-1520", "15-1025", "20-56135" };
            string[] carnet = new string[5];
            Console.WriteLine("Debe Ingresar 5 Codigos de Carnet Ejemplo: 19-13857\n");
            int contador = 1;
            for (int i = 0; i < carnet.Length; i++)
            {
                Console.WriteLine("Ingrese el Carnet No." + contador);
                carnet[i] = Console.ReadLine();
                contador++;
            }
            


            foreach (string d in carnet)
            {

                student.correlativo = d;
                student.descripcion = $"insertar Carnet. {d}";
                abr.insertar(student);
                student = new PorCorrelativo();
            }
            int pausa;
            pausa = 0;


        }

        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("\tORDENAMIENTO DE ARBOLES POR NOMBRES Y CARNET");
            Console.WriteLine("1.ORDENAMIENTO DE ARBOL POR NOMBRES\n");
            Console.WriteLine("2.ORDENAMIENTO DE ARBOL POR CARNET\n");
            int opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                        //Console.WriteLine("ANIMALES QUE YA ESTAN AGUARDADOS");

                        pruebaordenNombres();
                    break;

                case 2:
                        pruebaPorCorrelativo();

                    break;

                default:

                    break;
              }

                Console.WriteLine("Desea volver a jugar");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                a = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (a != 2);
            Console.ReadKey();

           
        }
    }
}
