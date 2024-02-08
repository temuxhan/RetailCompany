using Serilog;
using Store.Management.Service.Application.Behaviors;
using Store.Management.Service.Domain.Interfaces.Database;
using Store.Management.Service.Infrastructure;
using Store.Management.Service.Infrastructure.Repositories;
using System.Reflection;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigureServices(builder.Configuration, builder.Services, builder.Environment.EnvironmentName);
ConfigureHost(builder.Host);


WebApplication app = builder.Build();

ConfigureApp(app);

void ConfigureServices(IConfiguration configuration, IServiceCollection services, string environmentName)
{

    services.AddMediatR(cfg =>
    {
        cfg.RegisterServicesFromAssemblyContaining(typeof(Program));

        cfg.AddOpenBehavior(typeof(LoggingBehavior<,>));
        cfg.AddOpenBehavior(typeof(ValidatorBehavior<,>));
    });


    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddInfrastructure(configuration);
    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

    builder.Services.AddScoped<IStoreRoomInventoryRepository, StoreRoomInventoryRepository>();
}


void ConfigureHost(IHostBuilder hostBuilder)
{
    hostBuilder.UseSerilog((context, services, configuration) =>
    {
        configuration
            .ReadFrom.Configuration(context.Configuration)
            .ReadFrom.Services(services)
            .Enrich.WithProperty("Application Version", Assembly.GetExecutingAssembly().GetName().Version)
            .Enrich.FromLogContext();
    });
}


void ConfigureApp(WebApplication app)
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseSerilogRequestLogging();

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
