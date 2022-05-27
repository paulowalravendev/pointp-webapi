var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddDbContextsSetup(builder.Configuration.GetConnectionString("DefaultConnection"))
    .AddApplicationRepositoriesSetup()
    .AddApplicationServicesSetup()
    .AddControllers()
    .AddFluentValidationWithSwaggerSetup()
    .AddEndpointsApiExplorer()
    .AddSwaggerSetup()
    .AddMediatR(typeof(Program));

var app = builder.Build();
app.UseSwaggerSetup();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();