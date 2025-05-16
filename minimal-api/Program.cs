using minimal_api.dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (loginDTO loginDTO) => {
    if(loginDTO.Email == "adm@teste.com" && loginDTO.senha == "123456")
        return Results.Ok("Login realizado com sucesso");
    else
        return Results.BadRequest("Email ou senha inválidos");
});

app.Run();

