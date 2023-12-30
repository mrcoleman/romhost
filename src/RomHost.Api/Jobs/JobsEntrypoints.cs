namespace RomHost.Api.Jobs;

public static class JobsEntrypoints
{
    public static RouteGroupBuilder AddJobsEntrypoints(this RouteGroupBuilder apiBuilder)
    {
        apiBuilder.MapPost("job", () => "ok").WithSummary("kicks off a background job with the posted parameters").WithTags("Jobs");
        apiBuilder.MapGet("jobs", () => "ok").WithSummary("get a list all current jobs and their status").WithTags("Jobs");
        apiBuilder.MapGet("job/{jobId}", () => "ok").WithSummary(" gets that status of a job").WithTags("Jobs");
        apiBuilder.MapDelete("job/{jobId}", () => "ok").WithSummary(" cancel a job").WithTags("Jobs");
        apiBuilder.MapPut("job/{jobId}", () => "ok").WithSummary("append parameters to a job").WithTags("Jobs");

        return apiBuilder;
    }
}