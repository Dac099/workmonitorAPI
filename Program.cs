using workmonitorAPI.Data;
using workmonitorAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddValidation();
builder.AddWorkmonitorDb();
builder.AddDefaultCors();
builder.RegisterProjectsServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
else
{
    app.UseHttpsRedirection();
}

app.UseDefaultCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
