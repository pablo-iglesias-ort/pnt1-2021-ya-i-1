using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Epicrisis
    {
        public int EpicrisisId { get; set; }
        public Episodio Episodio { get; set; }
        public Medico Medico { get; set; }
        public DateTime FechaYHora { get; set; }
        public Diagnostico Diagnostico { get; set; }
    }
}
