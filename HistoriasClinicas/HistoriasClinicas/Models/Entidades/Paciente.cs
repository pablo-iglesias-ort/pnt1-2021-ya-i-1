using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoriasClinicas.Models.Entidades
{
    public class Paciente
    {

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

        

            


    }
}
