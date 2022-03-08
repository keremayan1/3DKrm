using Autofac;
using Autofac.Extensions.DependencyInjection;
using KRM3D.Services.Course.Business.Consumer;
using KRM3D.Services.Course.Business.DependencyResolvers.Autofac;
using KRM3D.Services.Course.DataAccess.Concrete.EntityFramework.Context;
using KRM3D.Services.Course.DataAccess.Mapping;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<CategoryNameChangedEventConsumer>();
    x.UsingRabbitMq((context, configuration) =>
    {
        configuration.Host(builder.Configuration.GetConnectionString("RabbitMQConnectionStrings"));
        configuration.ReceiveEndpoint("category-changed-name-queue", e =>
        {
            e.ConfigureConsumer<CategoryNameChangedEventConsumer>(context);
        });
    });
});
builder.Services.AddMassTransitHostedService();
// Add services to the container.
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SqlContext>();
builder.Services.AddAutoMapper(typeof(CourseMapping));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
