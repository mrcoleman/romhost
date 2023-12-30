namespace RomHost.Api.Systems.Roms;

public static class PatchesEntrypoints
{
    public static RouteGroupBuilder AddPatchesEntrypoints(this RouteGroupBuilder apiBuilder)
    {
        apiBuilder.MapGet("{system}/{romId}/patches", () => "ok").WithSummary("get a list of patch").WithTags("Patches");
        apiBuilder.MapGet("{system}/{romId}/file/patch/{patchId}", () => "ok").WithSummary("get the default rom file for a rom with a patch applied").WithTags("Patches");
        apiBuilder.MapGet("{system}/{romId}/file/{region}/patch/{patchId}", () => "ok").WithSummary(" get the rom file for a region with a patch applied").WithTags("Patches");
        apiBuilder.MapPost("{system}/{romId}/patch", () => "ok").WithSummary("create a patch entity").WithTags("Patches");
        apiBuilder.MapPost("{system}/{romId}/patch/{patchId} ", () => "ok").WithSummary(" save the patch file for a patch entity").WithTags("Patches");
        apiBuilder.MapDelete("{system}/{romId}/patch/{patchId}", () => "ok").WithSummary(" deletes a patch").WithTags("Patches");
        return apiBuilder;
    }
}