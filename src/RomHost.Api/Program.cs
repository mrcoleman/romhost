using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

using RomHost.Api.Jobs;
using RomHost.Api.Search;
using RomHost.Api.Systems;
using RomHost.Core;
using RomHost.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterSystemTypes()
    .RegisterSearchTypes()
    .RegisterJobsTypes();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(options =>{
    options.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
});

var api = app.MapGroup("/api/v1/").WithOpenApi();

api.AddSystemsEntrypoints()
   .AddSearchEntrypoints()
   .AddJobsEntrypoints();

app.Run();