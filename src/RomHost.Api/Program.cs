using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapGet("/api/v1/systems", () => "ok").WithDescription("returns a list of systems").WithOpenApi();
app.MapGet("/api/v1/{system}", () => "ok").WithDescription("returns a list of roms (paged) for that system").WithOpenApi();
app.MapGet("/api/v1/{system}/{romId}", () => "ok").WithDescription("returns basic metadata for the rom").WithOpenApi();
app.MapPost("/api/v1/{system}/{romId}", () => "ok").WithDescription("create new rom entry").WithOpenApi();
app.MapPut("/api/v1/{system}/{romId}", () => "ok").WithDescription("update the rom entry").WithOpenApi();
app.MapDelete("/api/v1/{system}/{romId}", () => "ok").WithDescription("deletes a rom and any files, metadata and patches").WithOpenApi();
app.MapGet("/api/v1/{system}/{romId}/file", () => "ok").WithDescription("returns the rom file/files").WithOpenApi();
app.MapGet("/api/v1/{system}/{romId}/file/{region}", () => "ok").WithDescription("returns a rom file for that region or falls back to the default rom if there is no region").WithOpenApi();
app.MapDelete("/api/v1/{system}/{romId}/file/{region}", () => "ok").WithDescription(" deletes the file for the region").WithOpenApi();
app.MapPost("/api/v1/{system}/{romId}/file", () => "ok").WithDescription("upload a file").WithOpenApi();
app.MapPost("/api/v1/{system}/{romId}/file/{region}", () => "ok").WithDescription("uploads a rom file for a specific region").WithOpenApi();
app.MapGet("/api/v1/{system}/{romId}/metadata/{metaId}", () => "ok").WithDescription("returns the content of a metadata item").WithOpenApi();
app.MapPost("/api/v1/{system}/{romId}/metadata/{metaId}", () => "ok").WithDescription("posts a bit of metadata").WithOpenApi();
app.MapDelete("/api/v1/{system}/{romId}/metadata/{metaId}", () => "ok").WithDescription("deletes a specific piece of metadata").WithOpenApi();
app.MapGet("/api/v1/{system}/{romId}/patches", () => "ok").WithDescription("get a list of patch").WithOpenApi();
app.MapGet("/api/v1/{system}/{romId}/file/patch/{patchId}", () => "ok").WithDescription("get the default rom file for a rom with a patch applied").WithOpenApi();
app.MapGet("/api/v1/{system}/{romId}/file/{region}/patch/{patchId}", () => "ok").WithDescription(" get the rom file for a region with a patch applied").WithOpenApi();
app.MapPost("/api/v1/{system}/{romId}/patch", () => "ok").WithDescription("create a patch entity").WithOpenApi();
app.MapPost("/api/v1/{system}/{romId}/patch/{patchId} ", () => "ok").WithDescription(" save the patch file for a patch entity").WithOpenApi();
app.MapDelete("/api/v1/{system}/{romId}/patch/{patchId}", () => "ok").WithDescription(" deletes a patch").WithOpenApi();
app.MapGet("/api/v1/search", (string q) => "ok").WithDescription(" do a full text search and returns a list of roms").WithOpenApi();
app.MapPost("/api/v1/search", () => "ok").WithDescription("do a search for specific fields and returns a list of roms").WithOpenApi();
app.MapPost("/api/v1/job", () => "ok").WithDescription("kicks off a background job with the posted parameters").WithOpenApi();
app.MapGet("/api/v1/jobs", () => "ok").WithDescription("get a list all current jobs and their status").WithOpenApi();
app.MapGet("/api/v1/job/{jobId}", () => "ok").WithDescription(" gets that status of a job").WithOpenApi();
app.MapDelete("/api/v1/job/{jobId}", () => "ok").WithDescription(" cancel a job").WithOpenApi();
app.MapPut("/api/v1/job/{jobId}", () => "ok").WithDescription("append parameters to a job").WithOpenApi();

app.Run();

