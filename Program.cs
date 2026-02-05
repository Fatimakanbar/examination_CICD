var builder = WebApplication.CreateBuilder(args);

// Lägg till stöd för Controllers (API-endpoints)
builder.Services.AddControllers();

// Gör så att Swagger fungerar (bra för testning)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Aktivera Swagger endast i utvecklingsmiljö.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Säkerställer att API:t använder HTTPS
app.UseHttpsRedirection();

// Aktiverar routing till controllers
app.MapControllers();

// Startar applikationen
app.Run();
