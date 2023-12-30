namespace RomHost.Api.Systems.Roms;

public static class MetadataEntrypoints
{
    public static RouteGroupBuilder AddMetadataEntrypoints(this RouteGroupBuilder apiBuilder)
    {
        apiBuilder.MapGet("{system}/{romId}/metadata/{metaId}", () => "ok").WithSummary("returns the content of a metadata item").WithTags("Metadata");
        apiBuilder.MapPost("{system}/{romId}/metadata/{metaId}", () => "ok").WithSummary("posts a bit of metadata").WithTags("Metadata");
        apiBuilder.MapDelete("{system}/{romId}/metadata/{metaId}", () => "ok").WithSummary("deletes a specific piece of metadata").WithTags("Metadata");
        return apiBuilder;
    }
}