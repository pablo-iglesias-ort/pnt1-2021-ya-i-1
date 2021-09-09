using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Empleado
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Email { get; set; }
        public string ObraSocial { get; set; }
        /*public HistoriaClinica HistoriaClinica { get; set; }*/
    }
}