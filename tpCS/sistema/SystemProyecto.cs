using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tpCS
{
    static public class SystemProyecto
    {
        static List<Proyecto_Desarrollo_Movil> Desarrollo_Movil = new();
        static List<Proyecto_Desarrollo_Web> Desarrollo_Web = new();

        public static void EliminarProyecto()
        {
            int opcion;
            Console.WriteLine(" que tipo de proyecto desea eliminar");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    foreach (var proyectoMovil in Desarrollo_Movil)
                    {
                        Console.WriteLine($"nombre:{proyectoMovil.Nombre}");
                    }
                    Console.WriteLine("ingrese el nombre del proyecto que desea eliminar");
                    string nombre=Console.ReadLine();
                    var proyectoAEliminar = Desarrollo_Movil.Find(proyecto => proyecto.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

                    if (proyectoAEliminar != null)
                    {
                        Desarrollo_Movil.Remove(proyectoAEliminar);
                        Console.WriteLine($"Proyecto :{nombre}, eliminado con exito.");
                    }
                    else
                    {
                        Console.WriteLine($"Proyecto :{nombre}, no encontrado.");
                    }
                    break;
                case 2:
                    foreach (var proyectoMovil in Desarrollo_Movil)
                    {
                        Console.WriteLine($"nombre:{proyectoMovil.Nombre}");
                    }
                    Console.WriteLine("ingrese el nombre del proyecto que desea eliminar");
                    string nombreMovil = Console.ReadLine();
                    var proyectoAeliminar = Desarrollo_Web.Find(proyecto => proyecto.Nombre.Equals(nombreMovil, StringComparison.OrdinalIgnoreCase));

                    if (proyectoAeliminar != null)
                    {
                        Desarrollo_Web.Remove(proyectoAeliminar);
                        Console.WriteLine($"Proyecto :{nombreMovil}, eliminado con exito.");
                    }
                    else
                    {
                        Console.WriteLine($"Proyecto: {nombreMovil}, no encontrado.");
                    }
                    break;
            }

        }
        public static void ModificarProyecto()
        {
            Console.WriteLine("Ingresar tipo de proyecto a modificar (movil/web):");
            string tipo = Console.ReadLine();
            if (tipo == "movil")
            {
                Menu.ModificarMovil(Desarrollo_Movil);
            }
            else
            {
                Menu.ModificarWeb(Desarrollo_Web);
            }

        }
    }
}

