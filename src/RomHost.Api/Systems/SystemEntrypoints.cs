using Microsoft.AspNetCore.Http.HttpResults;

using RomHost.Api.Systems.Roms;
using RomHost.Core;

namespace RomHost.Api.Systems;
public static class SystemEntrypoints
{
    public static RouteGroupBuilder AddSystemsEntrypoints(this RouteGroupBuilder apiBuilder)
    {
        apiBuilder.MapGet("systems", GetSystems).WithSummary("returns a list of systems").WithTags("Systems");
        apiBuilder.MapGet("{system}", GetSystem).WithSummary("returns a list of roms (paged) for that system").WithTags("Systems");

        apiBuilder.AddRomEntrypoints();

        return apiBuilder;
    }

    private static async Task<Ok<RomHost.Models.System>> GetSystem(string system)
    {
        return TypedResults.Ok(await Task.FromResult(new RomHost.Models.System()
        {
            Name = system
        }));

    }

    public static async Task<Ok<RomHost.Models.System[]>> GetSystems(SystemsManger systemsManger)
    {
        return TypedResults.Ok(await systemsManger.GetSystems());
    }
}