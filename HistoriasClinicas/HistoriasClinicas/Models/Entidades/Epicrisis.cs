using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Epicrisis
    {
        private int EpicrisisId { get; set; }
        private Episodio Episodio { get; set; }
        private Medico Medico { get; set; }
        private DateTime FechaYHora { get; set; }
        private Diagnostico Diagnostico { get; set; }
    }
}
