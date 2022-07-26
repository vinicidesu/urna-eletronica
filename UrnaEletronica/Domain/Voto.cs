namespace UrnaEletronica.Domain
{
    public class Voto
    {
        public int VotoId { get; set; }
        public int CandidatoId { get; set; }
        public DateTime DataVoto { get; set; }
        public Candidato Candidato { get; set; }
    }
}
