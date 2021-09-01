namespace HistoriasClinicas.Models.Entidades
{
    public class Diagnostico
    {
        public int DiagnosticoId { get; set; }
        public Epicrisis Epicrisis { get; set; }
        public string Descripcion { get; set; }
        public string Recomendacion { get; set; }
    }
}