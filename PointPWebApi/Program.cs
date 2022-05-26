var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerSetup();

var app = builder.Build();
app.UseSwaggerSetup();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();