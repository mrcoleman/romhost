using RomHost.Api.Systems.Roms;
using RomHost.Core;
using SystemType = RomHost.Models.System;
using System.Text.Json;

namespace RomHost.Api.Systems;
public static class Types
{
    public static IServiceCollection RegisterSystemTypes(this IServiceCollection services)
    {
        services.AddTransient<SystemsManger>();

        var systems = JsonSerializer.Deserialize<Dictionary<string,SystemType>>(File.ReadAllText("./Systems/systems.json"));
        services.AddSingleton<Dictionary<string,SystemType>>(systems);

        services.RegisterRomTypes();

        return services;
    }
}