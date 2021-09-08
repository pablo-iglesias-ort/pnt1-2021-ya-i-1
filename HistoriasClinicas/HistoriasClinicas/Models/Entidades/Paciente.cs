using System;

namespace HistoriasClinicas.Models.Entidades
{
    public class Paciente
    {
<<<<<<< HEAD

        public Guid Id{ get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Email { get; set; }
        public string ObraSocial { get; set; }
        public HistoriaClinica historiaClinica { get; set; }

        

            


=======
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Dni { get; set; }
        private string Telefono { get; set; }
        private string Direccion { get; set; }
        private DateTime FechaAlta { get; set; }
        private string Email { get; set; }
        private string ObraSocial { get; set; }
        private HistoriaClinica HistoriaClinica { get; set; }
>>>>>>> fa8a645f37987e98ed87a6fe6e909f70e1f36ccc
    }
}
