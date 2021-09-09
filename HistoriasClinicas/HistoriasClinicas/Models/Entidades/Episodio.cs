using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Episodio
    {
        public Guid Id { get; set; }
        public string Motivo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaYHoraInicio { get; set; }
        public DateTime FechaYHoraAlta { get; set; }
        public DateTime FechaYHoraCierre { get; set; }
        public bool EstadoAbierto { get; set; }
        /*public Evolucion evoluciones { get; set; }*/
        /*public Epicrisis epicrisis { get; set; }*/
        public bool EmpleadoRegistra { get; set; } /* en duda si dejar bool */

    }
}