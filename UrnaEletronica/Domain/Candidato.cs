﻿namespace UrnaEletronica.Domain
{
    public class Candidato
    {
        public int CandidatoId { get; set; }
        public string Nome { get; set; }
        public string NomeVice { get; set; }
        public int Legenda { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
