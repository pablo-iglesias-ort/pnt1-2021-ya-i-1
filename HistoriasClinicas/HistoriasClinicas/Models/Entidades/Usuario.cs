using System;
using System.ComponentModel.DataAnnotations;

namespace HistoriasClinicas.Models.Entidades
{
    public class Usuario
    {
/*<<<<<<< HEAD*/
        [Required]
        public Guid  Id { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar su nombre")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar su E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "El E-mail no es valido")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar su Contraseña")]
        [MinLength(length:8, ErrorMessage = "El minimo de caracteres es 8 digitos")]
        public string Password { get; set; }
        [Required]
        public DateTime fechaAlta { get; set; }

    
    
/*=======
        private string Nombre { get; set; }
        private string Email { get; set; }
        private DateTime FechaAlta { get; set; }
        private string Password { get; set; }
/*>>>>>>> fa8a645f37987e98ed87a6fe6e909f70e1f36ccc*/
    }
}
