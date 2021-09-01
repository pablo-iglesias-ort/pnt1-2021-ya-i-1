using System;
using System.Collections.Generic;

namespace HistoriasClinicas.Models.Entidades
{
    public class Evolucion
    {
        public int EvolucionId { get; set; }
        public Medico Medico { get; set; }
        public DateTime FechaYHoraInicio { get; set; }
        public DateTime FechaYHoraAlta { get; set; }
        public DateTime FechaYHoraCierre { get; set; }
        public string DescripcionAtencion { get; set; }
        public bool EstadoAbierto { get; set; }
        public List<Nota> Notas { get; set; }
    }
}
