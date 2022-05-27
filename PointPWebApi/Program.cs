var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddControllers()
    .AddFluentValidationWithSwaggerSetup()
    .AddEndpointsApiExplorer()
    .AddSwaggerSetup();

var app = builder.Build();
app.UseSwaggerSetup();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();