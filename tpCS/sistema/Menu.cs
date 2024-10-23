using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tpCS
{
   public static class Menu
    {
       
            public static void CrearProyecto_Web()
            {
                Console.WriteLine("ingrese el nombre del proyecto");
                string Nombre = Console.ReadLine();
                Console.WriteLine("ingrese el estado del proyecto\n" +
                    "1.PLanificacion\n" +
                    "2.En Desarrollo\n" +
                    "3.En Prueba\n" +
                    "4.Completado\n" +
                    "5.Cancelado\n");
                int Opcion = int.Parse(Console.ReadLine());
                EstadoActual elegirEstado = (EstadoActual)Opcion;
                Console.WriteLine("ingrese la cantidad de desarrolladores");
                int CantidadDeDesarrolladores = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la tecnologia que se usara en ele proyecto\n" +
                    "1.React\n" +
                    "2.Angular\n" +
                    "3.Vue.Js");
                int Tecnologia = int.Parse(Console.ReadLine());
                Tecnologias tecno = (Tecnologias)Tecnologia;
                Proyecto_Desarrollo_Web desarrolloWEb = new Proyecto_Desarrollo_Web(Nombre, elegirEstado, CantidadDeDesarrolladores, tecno);
            SystemProyecto.AgregarProyectoWeb(desarrolloWEb);

            }
            public static void CrearProyecto_Movil()
            {
                Console.WriteLine("ingrese el nombre del proyecto");
                string Nombre = Console.ReadLine();
                Console.WriteLine("ingrese el estado del proyecto\n" +
                    "1.PLanificacion\n" +
                    "2.En Desarrollo\n" +
                    "3.En Prueba\n" +
                    "4.Completado\n" +
                    "5.Cancelado\n");
                int Opcion = int.Parse(Console.ReadLine());
                EstadoActual elegirEstado = (EstadoActual)Opcion;
                Console.WriteLine("ingrese la cantidad de desarrolladores");
                int CantidadDeDesarrolladores = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la tecnologia que se usara en ele proyecto\n" +
                    "1.Ios\n" +
                    "2.Android\n" +
                    "3.Windows Phone");
                int Plataforma = int.Parse(Console.ReadLine());
                Plataformas plataformas = (Plataformas)Plataforma;
                Proyecto_Desarrollo_Movil desarrolloMovil = new Proyecto_Desarrollo_Movil(Nombre, elegirEstado, CantidadDeDesarrolladores, plataformas);
            SystemProyecto.AgregarProyectoMovil(desarrolloMovil);
            }
        public static void ModificarMovil(List<Proyecto_Desarrollo_Movil> moviles)
        {
            Console.WriteLine("\nProyectos moviles");
            foreach (var proyectomovil in moviles)
            {
                Console.WriteLine(proyectomovil.Nombre);
                Console.WriteLine("\nIngresar nombre del proyecto:");
                string nombre = Console.ReadLine();
                if (nombre == proyectomovil.Nombre)
                {
                    Console.WriteLine("\nInformacion del proyecto:\n");
                    Console.WriteLine($" {proyectomovil.ToString()} \n");
                    Console.WriteLine("Ingresar dato a modificar: \n" +
                        "1- Estado\n" +
                        "2- Numero de programadores\n" +
                        "3- Plataforma\n");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"Estado actual {proyectomovil.Estado}\n" +
                            "Escoger nuevo estado: \n" +
                            "1.Planificacion\n" +
                            "2.En Desarrollo\n" +
                            "3.En Prueba\n" +
                            "4.Completado\n" +
                            "5.Cancelado\n");
                            int estado = int.Parse(Console.ReadLine());
                            EstadoActual nuevoEstado = (EstadoActual)estado;
                            proyectomovil.Estado = nuevoEstado;
                            Console.WriteLine("Informacion actualizada.\n");
                            break;
                        case 2:
                            Console.WriteLine($"Numero de programadores actual: {proyectomovil.CantidadDeDesarrolladores}\n" +
                                $"Ingresar nuevo numero de programadores:\n");
                            int nronuevo = int.Parse(Console.ReadLine());
                            proyectomovil.CantidadDeDesarrolladores = nronuevo;
                            Console.WriteLine("Informacion actualizada.\n");
                            break;
                        case 3:
                            Console.WriteLine($"Plataforma actual: {proyectomovil.Plataforma}." +
                                $"Ingrese la nueva plataforma\n" +
                                "1.IOS\n" +
                                "2.Android\n" +
                                "3.Windows Phone");
                            int plata = int.Parse(Console.ReadLine());
                            Plataformas nuevaPlata = (Plataformas)plata;
                            proyectomovil.Plataforma = nuevaPlata;
                            Console.WriteLine("Informacion actualizada.\n");
                            break;
                    }
                }
            }
        }
        public static void ModificarWeb(List<Proyecto_Desarrollo_Web> webs)
        {
            Console.WriteLine("\nProyectos moviles");
            foreach (var proyectoweb in webs)
            {
                Console.WriteLine(proyectoweb.Nombre);
                Console.WriteLine("\nIngresar nombre del proyecto:");
                string nombre = Console.ReadLine();
                if (nombre == proyectoweb.Nombre)
                {
                    Console.WriteLine("\nInformacion del proyecto:\n");
                    Console.WriteLine($" {proyectoweb.ToString()} \n");
                    Console.WriteLine("Ingresar dato a modificar: \n" +
                        "1- Estado\n" +
                        "2- Numero de programadores\n" +
                        "3- Plataforma\n");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"Estado actual {proyectoweb.Estado}\n" +
                            "Escoger nuevo estado: \n" +
                            "1.Planificacion\n" +
                            "2.En Desarrollo\n" +
                            "3.En Prueba\n" +
                            "4.Completado\n" +
                            "5.Cancelado\n");
                            int estado = int.Parse(Console.ReadLine());
                            EstadoActual nuevoEstado = (EstadoActual)estado;
                            proyectoweb.Estado = nuevoEstado;
                            Console.WriteLine("Informacion actualizada.\n");
                            break;
                        case 2:
                            Console.WriteLine($"Numero de programadores actual: {proyectoweb.CantidadDeDesarrolladores}\n" +
                                $"Ingresar nuevo numero de programadores:\n");
                            int nronuevo = int.Parse(Console.ReadLine());
                            proyectoweb.CantidadDeDesarrolladores = nronuevo;
                            Console.WriteLine("Informacion actualizada.\n");
                            break;
                        case 3:
                            Console.WriteLine($"Tecnologia actual: {proyectoweb.Tecno}." +
                                $"Ingrese la nueva tecnologia\n" +
                                "1.React\n" +
                                "2.Angular\n" +
                                "3.Vue.Js");
                            int Tecnologia = int.Parse(Console.ReadLine());
                            Tecnologias nuevaTecno = (Tecnologias)Tecnologia;
                            proyectoweb.Tecno = nuevaTecno;
                            Console.WriteLine("Informacion actualizada.\n");
                            break;
                    }
                }
            }
        }
    }

}
