using System;
using System.Collections.Generic;

namespace HistoriasClinicas.Models.Entidades
{
    public class Evolucion
    {
        private int EvolucionId { get; set; }
        private Medico Medico { get; set; }
        private DateTime FechaYHoraInicio { get; set; }
        private DateTime FechaYHoraAlta { get; set; }
        private DateTime FechaYHoraCierre { get; set; }
        private string DescripcionAtencion { get; set; }
        private bool EstadoAbierto { get; set; }
        private List<Nota> Notas { get; set; }
    }
}
