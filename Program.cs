using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subtema5_5._1
{
    internal class Program
    {
        static string nombreArchivo = "Listaproductos.txt";  //variable de clases
        static void Main(string[] args)
        {
            agregarNuevoProducto();
        }
        static void agregarNuevoProducto()
        {
            //crear y abrir el docuento de texto
            StreamWriter nuevoDocumento = new StreamWriter(nombreArchivo, true);

            Console.Write("Ingreseel nombre de l producto a registrar");
            string producto = Console.ReadLine();
            nuevoDocumento.WriteLine(producto);
            //IMPORTANTE CERRAR PARA GUARDAR LOS CAMBIOS
            nuevoDocumento.Close();

        }
    }
}
