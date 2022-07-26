using Microsoft.AspNetCore.Mvc;
using UrnaEletronica.Data;
using UrnaEletronica.Domain;

namespace UrnaEletronica.Endpoints
{
    public class CandidatoDelete
    {
        public static string Template => "/candidate/{id}";
        public static string[] Methods => new string[] { HttpMethod.Delete.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action(CandidatoRequest candidato, ApplicationDbContext context) 
        {
            var Candidato = new Candidato
            {
                CandidatoId = candidato.CandidatoId,
            };

            if (candidato.CandidatoId == 0) 
            {
                return Results.NotFound();
            }

            context.Remove(Candidato);
            context.SaveChanges();

            return Results.Accepted($"/candidate/{candidato.CandidatoId} Excluído.", candidato.CandidatoId);
        }
    }
}
