using UrnaEletronica.Data;
using UrnaEletronica.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration["ConnectionString:UrnaEletronica"]);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapMethods(CandidatoPost.Template, CandidatoPost.Methods, CandidatoPost.Handler);
app.MapMethods(CandidatoDelete.Template, CandidatoDelete.Methods, CandidatoDelete.Handle);

app.Run();
