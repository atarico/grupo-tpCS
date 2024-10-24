using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tpCS.ENUMS;

namespace tpCS
{
    static public class SystemProyecto
    {
        static List<Proyecto_Desarrollo_Movil> Desarrollo_Movil = new();
        static List<Proyecto_Desarrollo_Web> Desarrollo_Web = new();
        static readonly string DesarrolloWeb = "Desarrollo_Web.txt";
        static readonly string DesarrolloMovil = "Desarrollo_Movil.txt";
        static public void AgregarProyectoMovil(Proyecto_Desarrollo_Movil desarrollo_Movil) => Desarrollo_Movil.Add(desarrollo_Movil);
        static public void AgregarProyectoWeb(Proyecto_Desarrollo_Web desarrolloweb) => Desarrollo_Web.Add(desarrolloweb);
        public static void GuardarProyectos()
        {
            using (StreamWriter writer = new StreamWriter(DesarrolloMovil))
            {
                foreach (var Proyecto in Desarrollo_Movil)
                {
                    writer.WriteLine($"{Proyecto.Nombre},{Proyecto.Plataforma},{Proyecto.CantidadDeDesarrolladores},{Proyecto.Estado},{Proyecto.FechaDeInicio},{Proyecto.FechaEstimada}");
                }
            }

            using (StreamWriter writer = new StreamWriter(DesarrolloWeb))
            {
                foreach (var Proyecto in Desarrollo_Web)
                {
                    writer.WriteLine($"{Proyecto.Nombre},{Proyecto.Tecno},{Proyecto.CantidadDeDesarrolladores},{Proyecto.Estado},{Proyecto.FechaDeInicio},{Proyecto.FechaEstimada}");
                }
            }
            Console.WriteLine("Proyectos guardado correctamente");
        }

        public static void CargarDatos()
        {
            if (File.Exists(DesarrolloMovil))
            {
                using (StreamReader reader = new StreamReader(DesarrolloMovil))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {

                        var values = linea.Split(',');

                        if (values.Length == 6)
                        {
                            string Nombre = values[0].Trim();
                            Plataformas Plataforma = (Plataformas)Enum.Parse(typeof(Plataformas), values[1].Trim());
                            int CantidadDeDesarrolladores = int.Parse(values[2].Trim());
                            EstadoActual Estado = (EstadoActual)Enum.Parse(typeof(EstadoActual), values[3].Trim());
                            DateTime FechaDeInicio = DateTime.Parse(values[4].Trim());
                            DateTime FechaEstimada = DateTime.Parse(values[5].Trim());
                            Desarrollo_Movil.Add(new Proyecto_Desarrollo_Movil(Nombre, Estado, CantidadDeDesarrolladores, Plataforma));
                        }
                    }
                }
                Console.WriteLine("Proyectos de desarrollo móvil cargados correctamente");
            }
            else
            {
                Console.WriteLine("No se encontró el archivo de proyectos móviles");
            }

            if (File.Exists(DesarrolloWeb))
            {
                using (StreamReader reader = new StreamReader(DesarrolloWeb))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        
                        var values = linea.Split(',');

                        if (values.Length == 6)
                        {
                            string Nombre = values[0].Trim();
                            Tecnologias Tecno = (Tecnologias)Enum.Parse(typeof(Tecnologias), values[1].Trim());
                            int CantidadDeDesarrolladores = int.Parse(values[2].Trim());
                            EstadoActual Estado = (EstadoActual)Enum.Parse(typeof(EstadoActual), values[3].Trim());
                            DateTime FechaDeInicio = DateTime.Parse(values[4].Trim());
                            DateTime FechaEstimada = DateTime.Parse(values[5].Trim());
                            Desarrollo_Web.Add(new Proyecto_Desarrollo_Web(Nombre, Estado, CantidadDeDesarrolladores, Tecno));
                        }
                    }
                }
                Console.WriteLine("Proyectos de desarrollo web cargados correctamente");
            }
            else
            {
                Console.WriteLine("No se encontró el archivo de proyectos web");
            }
        }

        public static void MostrarTodosLosProyectos()
        {
            Console.WriteLine("-----PROYECTOS DESARROLLO WEB-----\n");
            foreach (var proyectoweb in Desarrollo_Web)
            {
                Console.WriteLine(proyectoweb.ToString());
            }
            Console.WriteLine("\n----PROYECTOS DESARROLLO MOVIL-----\n");
            foreach (var proyectomovil in Desarrollo_Movil)
            {
                Console.WriteLine(proyectomovil.ToString());
            }
        }
        public static void EliminarProyecto()
        {
            int opcion;
            Console.WriteLine("¿que tipo de proyecto desea eliminar?" +
                              "\n1. Desarrollo Movil\n" +
                              "2. Desarrollo Web");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    
                    foreach (var proyectoMovil in Desarrollo_Movil)
                    {
                        Console.WriteLine($"Nombre: {proyectoMovil.Nombre}");
                    }
                    Console.WriteLine("Ingrese el nombre del proyecto que desea eliminar:");
                    string nombreMovil = Console.ReadLine();
                    var proyectoAEliminarMovil = Desarrollo_Movil.Find(proyecto => proyecto.Nombre.Equals(nombreMovil, StringComparison.OrdinalIgnoreCase));

                    if (proyectoAEliminarMovil != null)
                    {
                        Desarrollo_Movil.Remove(proyectoAEliminarMovil);
                        Console.WriteLine($"Proyecto: {nombreMovil} eliminado con exito.");
                    }
                    else
                    {
                        Console.WriteLine($"Proyecto: {nombreMovil} no encontrado.");
                    }
                    break;

                case 2:
                   
                    foreach (var proyectoWeb in Desarrollo_Web)
                    {
                        Console.WriteLine($"Nombre: {proyectoWeb.Nombre}");
                    }
                    Console.WriteLine("Ingrese el nombre del proyecto que desea eliminar:");
                    string nombreWeb = Console.ReadLine();
                    var proyectoAEliminarWeb = Desarrollo_Web.Find(proyecto => proyecto.Nombre.Equals(nombreWeb, StringComparison.OrdinalIgnoreCase));

                    if (proyectoAEliminarWeb != null)
                    {
                        Desarrollo_Web.Remove(proyectoAEliminarWeb);
                        Console.WriteLine($"Proyecto: {nombreWeb} eliminado con exito.");
                    }
                    else
                    {
                        Console.WriteLine($"Proyecto: {nombreWeb} no encontrado.");
                    }
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
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

