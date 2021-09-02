using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class HistoriaClinica
    {
        private int HistoriaClinicaId { get; set; }
        private Paciente paciente { get; set; }
        private Episodio Episodios { get; set; }
    }
}
