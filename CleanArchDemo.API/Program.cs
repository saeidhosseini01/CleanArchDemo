using CleanArchDemo.API.EndPoint;
using CleanArchDemo.Applications.Handlers.Users.QuerisHandlers;
using CleanArchDemo.Applications.Mapping;
using CleanArchDemo.Persistance.DemoDbContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
ConfigureServices(builder.Services, builder.Configuration);



var app = builder.Build();
ConfigureMiddelware(app);

app.MapRoot();
app.Run();

void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    services.AddControllers();
    services.AddAutoMapper(typeof(MappingsProfile));
    builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(GetAllUserQueryHandler).Assembly));
    services.AddDbContext<DemoDbContext>(options
        => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
        sqlpots => sqlpots.EnableRetryOnFailure()));


    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();

}

void ConfigureMiddelware(WebApplication app)
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseHttpsRedirection();

    app.UseAuthorization();
    app.UseStaticFiles();
    app.UseStatusCodePages();
    app.UseDeveloperExceptionPage();
    app.MapControllers();
    
}