using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Nota
    {
        public int NotaId { get; set; }
        public Evolucion Evolucion { get; set; }
        public Empleado Empleado { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaYHora { get; set; }
    }
}