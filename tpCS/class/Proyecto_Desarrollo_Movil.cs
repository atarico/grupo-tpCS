using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpCS.ENUMS;
namespace tpCS
{
   public  class Proyecto_Desarrollo_Movil :Proyecto
    {
        private string _nombre;
        private EstadoActual _estado;
        private int _cantidadDeDesarrolladores;
        private DateTime _fechaDeInicio;
        private DateTime _fechaEstimada;
        private Plataformas _plataforma;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public EstadoActual Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public int CantidadDeDesarrolladores
        {
            get { return _cantidadDeDesarrolladores; }
            set { _cantidadDeDesarrolladores = value; }
        }
        public DateTime FechaDeInicio
        {
            get { return _fechaDeInicio; }
            set { _fechaDeInicio = value; }
        }
        public DateTime FechaEstimada
        {
            get { return _fechaEstimada; }
            set { _fechaEstimada = value; }
        }
        public Plataformas Plataforma
        {
            get { return _plataforma; }
            set { _plataforma = value; }
        }


        public Proyecto_Desarrollo_Movil(string nombre, EstadoActual estado, int cantidadDeDesarrolladores, Plataformas plataforma) : base(nombre, estado, cantidadDeDesarrolladores)
        {
            Nombre = nombre;
            Estado = estado;
            CantidadDeDesarrolladores = cantidadDeDesarrolladores;
            FechaDeInicio = DateTime.Now;
            FechaEstimada = CalcularFechastima();
            Plataforma = plataforma;
        }
        public DateTime CalcularFechastima()
        {
            int diasBase = 40;
            double factorReduccion = 0.9;
            double diasEstimados = diasBase;


            for (int i = 1; i < CantidadDeDesarrolladores; i++)
            {
                diasEstimados *= factorReduccion;
            }

            return FechaDeInicio.AddDays(diasEstimados);
        }
        public string ToString()
        {
            return $"Nombre:{Nombre},Estado:{Estado},N° desarrolladores:{CantidadDeDesarrolladores},\n" +
                $"Fecha de inicio:{FechaDeInicio},Fecha estimada:{FechaEstimada},Plataforma:{Plataforma}";
        }


    }
}

