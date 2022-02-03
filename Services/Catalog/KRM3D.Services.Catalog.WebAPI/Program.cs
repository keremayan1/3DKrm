using Autofac;
using Autofac.Extensions.DependencyInjection;
using KRM3D.Core.DependencyResolvers.MongoDb;
using KRM3D.Core.Extensions;
using KRM3D.Services.Catalog.Business.DependencyResolvers.Autofac;
using KRM3D.Services.Catalog.DataAccess.Mapping.AutoMapper;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());
});
// Add services to the container.
builder.Services.AddDependencyResolvers(builder.Configuration, new MongoDbModule());
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(CategoryMapping));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
