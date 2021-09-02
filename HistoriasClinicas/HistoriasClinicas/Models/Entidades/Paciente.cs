using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Paciente
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Dni { get; set; }
        private string Telefono { get; set; }
        private string Direccion { get; set; }
        private DateTime FechaAlta { get; set; }
        private string Email { get; set; }
        private string ObraSocial { get; set; }
        private HistoriaClinica HistoriaClinica { get; set; }
    }
}
