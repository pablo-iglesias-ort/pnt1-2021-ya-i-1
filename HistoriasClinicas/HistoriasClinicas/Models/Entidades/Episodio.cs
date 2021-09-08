using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Episodio
    {
        private int EpisodioId { get; set; }
        private string Motivo { get; set; }
        private string Descripcion { get; set; }
        private DateTime FechaYHoraInicio { get; set; }
        private DateTime FechaYHoraAlta { get; set; }
        private DateTime FechaYHoraCierre { get; set; }
        private bool EstadoAbierto { get; set; }
        private Evolucion evoluciones { get; set; }
        private Epicrisis epicrisis { get; set; }
        private bool EmpleadoRegistra { get; set; } /* en duda si dejar bool */

    }
}