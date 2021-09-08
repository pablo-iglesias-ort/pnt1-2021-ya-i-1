using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Empleado
    {
        private int EmpleadoId { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string DNI { get; set; }
        private string Telefono { get; set; }
        private string Direccion { get; set; }
        private DateTime FechaAlta { get; set; }
        private string Email { get; set; }
        private string ObraSocial { get; set; }
        private HistoriaClinica HistoriaClinica { get; set; }
    }
}