using RomHost.Models;

namespace RomHost.Core;

public class SystemsManger
{
    public async Task<RomHost.Models.System[]> GetSystems()
    {
        return await Task.FromResult(Array.Empty<RomHost.Models.System>());
    }
}