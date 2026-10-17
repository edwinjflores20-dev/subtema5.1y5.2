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

static void GenerarReporte(){
                //StreamReader leer un archivo de texto
                StreamReader Leerdocumento = new StreamReader(nombreArchivo);

                //Leerdocumento coca cola 600, galleta , agua
                int contador = 0;
                string linea;
                while ((linea = Leerdocumento.ReadLine()) != null)
{
                    contador++;
                    Console.WriteLine("producto: " + linea);
}
                Console.WriteLine("el total de productos en el almacen son: " + contador);
                Leerdocumento.Close();
        }
    }
}
}
