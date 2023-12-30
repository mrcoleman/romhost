
using System.ComponentModel;

namespace RomHost.Api.Systems.Roms;

public static class FilesEntrypoints
{
    public static RouteGroupBuilder AddFilesEntrypoints(this RouteGroupBuilder apiBuilder)
    {
        apiBuilder.MapGet("{system}/{romId}/file", GetDefaultRomFile).WithSummary("returns the rom file/files").WithTags("Rom Files");
        apiBuilder.MapGet("{system}/{romId}/file/{region}", GetRomFileByRegion).WithSummary("returns a rom file for that region or falls back to the default rom if there is no region").WithTags("Rom Files");
        apiBuilder.MapDelete("{system}/{romId}/file/{region}", DeleteRomFileByregion).WithSummary(" deletes the file for the region").WithTags("Rom Files");
        apiBuilder.MapPost("{system}/{romId}/file", CreateDefaultRomFile).WithSummary("upload a file").WithTags("Rom Files");
        apiBuilder.MapPost("{system}/{romId}/file/{region}", CreateRomFileForRegion).WithSummary("uploads a rom file for a specific region").WithTags("Rom Files");
        return apiBuilder;
    }

    private static async Task GetDefaultRomFile(string system, string romId)
    {
        throw new NotImplementedException();
    }

    private static async Task GetRomFileByRegion(string system, string romId, string region)
    {
        throw new NotImplementedException();
    }

    private static async Task DeleteRomFileByregion(string system, string romId, string region)
    {
        throw new NotImplementedException();
    }

    private static async Task CreateDefaultRomFile(string system, string romId)
    {
        throw new NotImplementedException();
    }

    private static async Task CreateRomFileForRegion(string system, string romId, string region)
    {
        throw new NotImplementedException();
    }
}