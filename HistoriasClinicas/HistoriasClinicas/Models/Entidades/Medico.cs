using System;
using System.ComponentModel.DataAnnotations;

namespace HistoriasClinicas.Models.Entidades
{
    public class Medico 
    {
/*<<<<<<< HEAD*/
        [Required]
        public System.Guid Id { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar su nombre")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar su apellido")]
        public string Apellido { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar su Dni")]
        [MinLength(length: 8, ErrorMessage = "El minimo de caracteres es 8 digitos")]
        [Range(1, 9999999999999, ErrorMessage = "Dni fuera del rango permitido")]
        public string Dni { get; set; }
        
        [Required(ErrorMessage = "Debe completar este campo")]
        public string Telefono { get; set; }
        
        [Required(ErrorMessage = "Debe completar este campo")]
        public string Direccion { get; set; }
        [Required]
        public System.DateTime FechaAlta { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar su E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "El E-mail no es valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe ingresar su matricula")]
        [MinLength(length: 8, ErrorMessage = "El minimo de caracteres es 8 digitos")]
        public string Matricula { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar su especialidad")]
        public string Especialidad { get; set; }
/*=======
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Dni { get; set; }
        private string Telefono { get; set; }
        private string Direccion { get; set; }
        private DateTime FechaAlta { get; set; }
        private string Email { get; set; }
        private string Matricula { get; set; }
        private string Especialidad { get; set; }
>>>>>>> fa8a645f37987e98ed87a6fe6e909f70e1f36ccc*/
    }
}