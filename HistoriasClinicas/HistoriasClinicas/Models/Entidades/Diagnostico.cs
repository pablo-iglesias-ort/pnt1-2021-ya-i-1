namespace HistoriasClinicas.Models.Entidades
{
    public class Diagnostico
    {
        private int DiagnosticoId { get; set; }
        private Epicrisis Epicrisis { get; set; }
        private string Descripcion { get; set; }
        private string Recomendacion { get; set; }
    }
}