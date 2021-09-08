namespace HistoriasClinicas.Models.Entidades
{
    public class Medico 
    {
        public System.Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public string Email { get; set; }
        public string Matricula { get; set; }
        public string Especialidad { get; set; }
    }
}