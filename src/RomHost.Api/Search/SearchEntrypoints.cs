namespace RomHost.Api.Search;

public static class SearchEntrypoints
{
    public static RouteGroupBuilder AddSearchEntrypoints(this RouteGroupBuilder api)
    {
        api.MapGet("search", (string q) => "ok").WithSummary(" do a full text search and returns a list of roms").WithTags("Search");
        api.MapPost("search", () => "ok").WithSummary("do a search for specific fields and returns a list of roms").WithTags("Search");
        return api;
    }
}