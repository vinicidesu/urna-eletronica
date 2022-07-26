using UrnaEletronica.Data;
using UrnaEletronica.Domain;

namespace UrnaEletronica.Endpoints
{
    public class CandidatoPost
    {
        public static string Template => "/candidate";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler => Action;
        public static IResult Action(CandidatoRequest candidatoRequest, ApplicationDbContext context) 
        {
            var Candidato = new Candidato
            {
                Nome = candidatoRequest.Nome,
                NomeVice = candidatoRequest.NomeVice,
                Legenda = candidatoRequest.Legenda,
                DataRegistro = DateTime.Now
            };
            context.Candidatos.Add(Candidato);
            context.SaveChanges();

            return Results.Created($"/candidate/{Candidato.CandidatoId}", Candidato.CandidatoId);
        }
    }
}
