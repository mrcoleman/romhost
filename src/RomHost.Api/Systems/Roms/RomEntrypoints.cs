




namespace RomHost.Api.Systems.Roms;

public static class RomEntrypoints
{
    public static RouteGroupBuilder AddRomEntrypoints(this RouteGroupBuilder apiBuilder)
    {
        apiBuilder.MapGet("{system}/{romId}", GetRomById).WithSummary("returns basic metadata for the rom").WithTags("Roms");
        apiBuilder.MapPost("{system}/{romId}", CreateRom).WithSummary("create new rom entry").WithTags("Roms");
        apiBuilder.MapPut("{system}/{romId}", UpdateRom).WithSummary("update the rom entry").WithTags("Roms");
        apiBuilder.MapDelete("{system}/{romId}", DeleteRom).WithSummary("deletes a rom and any files, metadata and patches").WithTags("Roms");

        apiBuilder.AddFilesEntrypoints()
                  .AddMetadataEntrypoints()
                  .AddPatchesEntrypoints();


        return apiBuilder;
    }

    private static async Task GetRomById(string system, string romId)
    {
        throw new NotImplementedException();
    }

    private static async Task CreateRom(string system, string romId)
    {
        throw new NotImplementedException();
    }

    private static async Task UpdateRom(string system, string romId)
    {
        throw new NotImplementedException();
    }

    private static async Task DeleteRom(string system, string romId)
    {
        throw new NotImplementedException();
    }


}