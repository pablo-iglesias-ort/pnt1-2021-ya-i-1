using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoriasClinicas.Models.Entidades
{
    public class Usuario
    {
        public Guid  Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public DateTime fechaAlta { get; set; }
        public string Password { get; set; }

    
    
    }
}
