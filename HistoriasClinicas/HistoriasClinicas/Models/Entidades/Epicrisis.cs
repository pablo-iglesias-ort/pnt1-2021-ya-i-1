using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Epicrisis
    {
        public Guid Id { get; set; } /* Cambiado el tipo de dato pq no me dejaba hacer el scaffolding*/
        public Episodio Episodio { get; set; }
        public Medico Medico { get; set; }
        public DateTime FechaYHora { get; set; }
        public Diagnostico Diagnostico { get; set; }
    }
}
