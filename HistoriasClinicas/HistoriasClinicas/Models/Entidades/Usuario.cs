using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Usuario
    {
        private string Nombre { get; set; }
        private string Email { get; set; }
        private DateTime FechaAlta { get; set; }
        private string Password { get; set; }
    }
}
