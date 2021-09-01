using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Nota
    {
        private int NotaId { get; set; }
        private Evolucion Evolucion { get; set; }
        private Empleado Empleado { get; set; }
        private string Mensaje { get; set; }
        private DateTime FechaYHora { get; set; }
    }
}