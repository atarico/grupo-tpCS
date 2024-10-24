using System.IO;
using tpCS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tpCS
{
    class Program
    {
        static void Main()
        {
            SystemProyecto.CargarDatos();


            int opcion;

            do
            {
                Console.WriteLine("/////Bienvenido a TecnoInnovate/////");
                Console.WriteLine("1.AGREGAR UN NUEVO PROYECTO");
                Console.WriteLine("2.MOSTRAR TODOS LOS PROYECTOS");
                Console.WriteLine("3.MODIFICAR PROYECTO EXISTENTE");
                Console.WriteLine("4.ELIMINAR PROYECTO POR SU NOMBRE");
                Console.WriteLine("5.GUARDAR PROYECTOS");
                Console.WriteLine("6.SALIR");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Que Tipo de proyecto quiere agregar:\n" +
                            "1.Proyecto de desarrollo Movil\n" +
                            "2.Proyecto de Desarrollo  web");
                        int pr = int.Parse(Console.ReadLine());
                        switch (pr)
                        {
                            case 1:
                                Menu.CrearProyecto_Movil();
                                break;
                            case 2:
                                Menu.CrearProyecto_Web();

                                break;
                        }
                        break;
                    case 2:
                        SystemProyecto.MostrarTodosLosProyectos();
                        break;
                    case 3:
                        SystemProyecto.ModificarProyecto();
                        break;
                    case 4:
                        SystemProyecto.EliminarProyecto();
                        break;
                    case 5:
                        SystemProyecto.GuardarProyectos();
                        break;
                    case 6:

                        break;



                }
            } while (opcion != 6);
        }
    }
}
