using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Medico
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Dni { get; set; }
        private string Telefono { get; set; }
        private string Direccion { get; set; }
        private DateTime FechaAlta { get; set; }
        private string Email { get; set; }
        private string Matricula { get; set; }
        private string Especialidad { get; set; }
    }
}